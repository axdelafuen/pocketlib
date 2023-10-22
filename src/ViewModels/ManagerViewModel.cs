using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using InsaneMVVMToolKit;
using Model;

namespace ViewModels;

public class ManagerViewModel : INotifyPropertyChanged
{
    // Manager
    public Manager Manager { get; set; }
    
    public ManagerViewModel(Manager manager)
    {
        Manager = manager;
        Books = new ReadOnlyObservableCollection<BookViewModel>(books);
        GetBooksFromCollectionCommand = new RelayCommand<EventArgs>(GetBooksFromCollectionCommandExecute);
        AddBookToCollectionByIsbnCommand = new RelayCommand<string>(AddBookToCollectionByIsbnCommandExecute);
        GetToBeReadBooksCommand = new RelayCommand<EventArgs>(GetToBeReadBooksCommandExecute);
        GetBooksCount(Index, Count);
        GetToBeReadBooksCount(Index, Count);
    }

    public ManagerViewModel(ILibraryManager libraryManager, IUserLibraryManager userLibraryManager)
        :this(new Manager(libraryManager, userLibraryManager)){}

    //Model properties

    private string pageTitle;
    
    public string PageTitle
    {
        get { return pageTitle;}
        set
        {
            pageTitle = value;
            OnPropertyChanged();
        }
    }

    private int index = 0;

    public int Index
    {
        get => index;
        set
        {
            index = value;
            GetBooksFromCollection(Index, Count);
            OnPropertyChanged();
        }
    }

    private int count = 10;
    public int Count
    {
        get => count;
        set
        {
            if (count != value)
            {
                count = value;
                OnPropertyChanged();
            }
        }
    }
    
    public long NbBooks {get;set;}
    
    public long NbBooksAll { get; private set; }

    public long NbBookToBeRead { get; private set; }
    
    public int NbPages => (int)NbBooks / Count;

    private BookViewModel selectedBook;

    public BookViewModel SelectedBook
    {
        get => selectedBook;
        set
        {
            selectedBook = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(GroupedBooks));
        }
    }
    
    public IEnumerable<IGrouping<string, BookViewModel>> GroupedBooks => Books.GroupBy(b => b.Author.Name).OrderBy(group => group.Key);

    public ReadOnlyObservableCollection<BookViewModel> Books { get; set; }

    private readonly ObservableCollection<BookViewModel> books = new ObservableCollection<BookViewModel>();
    
    // Model methods
    
    private async Task GetBooksFromCollection(int index, int count)
    {
        var result = await Manager.GetBooksFromCollection(index, count);
        NbBooks = result.count;
        IEnumerable<Book> resBooks = result.books;
        books.Clear();
        foreach (var b in resBooks.Select(b => new BookViewModel(b)))
        {
            books.Add(b);
        }

        OnPropertyChanged(nameof(GroupedBooks));
        OnPropertyChanged(nameof(NbBooks));
        OnPropertyChanged(nameof(NbPages));

    }

    private async Task GetToBeReadBooks(int index, int count)
    {
        var result = await Manager.GetBooksFromCollection(index, count);
        IEnumerable<Book> resBooks = result.books;
        NbBooks = 0;
        books.Clear();
        foreach (var b in resBooks.Select(b => new BookViewModel(b)))
        {
            if (b.Status == Status.ToBeRead)
            {
                books.Add(b);
                NbBooks++;
            }
        }
        OnPropertyChanged(nameof(GroupedBooks));
        OnPropertyChanged(nameof(NbBooks));
        OnPropertyChanged(nameof(NbPages));
    }

    private async Task GetToBeReadBooksCount(int index, int count)
    {
        var result = await Manager.GetBooksFromCollection(index, count);
        NbBooks = result.count;
        IEnumerable<Book> resBooks = result.books;
        NbBookToBeRead = 0;
        foreach (var b in resBooks.Select(b => new BookViewModel(b)))
        {
            if (b.Status == Status.ToBeRead)
            {
                NbBookToBeRead++;
            }
        }
    }
    
    private async Task GetBooksCount(int index, int count)
    {
        var result = await Manager.GetBooksFromCollection(index, count);
        NbBooksAll = result.count;
    }

    private async Task AddBookToCollectionByIsbn(string isbn)
    {
        try
        {
            var isbnResult = await Manager.GetBookByISBN(isbn);
            var bookResult = await Manager.AddBookToCollection(isbnResult);
            if(bookResult == null) _ = Toast.Make("Erreur : livre déja dans la bibliothèque", ToastDuration.Short, 14).Show(new CancellationTokenSource().Token);
            else
            {
                GetBooksCount(Index, Count);
                OnPropertyChanged(nameof(NbBooks));
                OnPropertyChanged(nameof(GroupedBooks));
                _ = Toast.Make("Livre ajouté !", ToastDuration.Short, 14).Show(new CancellationTokenSource().Token);
            }
        }
        catch (Exception e)
        {
            _ = Toast.Make("Erreur : ISBN introuvable", ToastDuration.Short, 14).Show(new CancellationTokenSource().Token);
        }
    }
    
    // Command to load datas

    public ICommand GetBooksFromCollectionCommand { get; set; }

    private async void GetBooksFromCollectionCommandExecute(EventArgs args)
    {
        await GetBooksFromCollection(Index,count);
    }
    
    public ICommand AddBookToCollectionByIsbnCommand { get; set; }

    private async void AddBookToCollectionByIsbnCommandExecute(string args)
    {
        await AddBookToCollectionByIsbn(args);
    }
    
    public ICommand GetToBeReadBooksCommand { get; set; }

    private async void GetToBeReadBooksCommandExecute(EventArgs args)
    {
        await GetToBeReadBooks(index, count);
    }
    
    // Property changed method 
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}