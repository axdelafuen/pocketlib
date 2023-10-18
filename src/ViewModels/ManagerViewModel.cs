using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
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
    }

    public ManagerViewModel(ILibraryManager libraryManager, IUserLibraryManager userLibraryManager)
        :this(new Manager(libraryManager, userLibraryManager)){}

    //Model properties
    
    public int Index { get; set; }

    private int count = 10;
    public int Count
    {
        get { return count; }
        set
        {
            if (count != value)
            {
                count = value;
                OnPropertyChanged();
            }
        }
    }
    
    private long NbBooks { get; set; }

    private long NbPages { get; set; }

    private BookViewModel selectedBook;

    public BookViewModel SelectedBook
    {
        get => selectedBook;
        set
        {
            selectedBook = value;
            OnPropertyChanged();
        }
    }

    public ReadOnlyObservableCollection<BookViewModel> Books
    {
        get;
        set;
    }

    private readonly ObservableCollection<BookViewModel> books = new ObservableCollection<BookViewModel>();
    
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
    }
    
    // Command to load datas

    public ICommand GetBooksFromCollectionCommand { get; set; }

    private async void GetBooksFromCollectionCommandExecute(EventArgs args)
    {
        await GetBooksFromCollection(Index,count); 
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