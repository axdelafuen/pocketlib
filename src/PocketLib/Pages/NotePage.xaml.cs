using PocketLib.Models;
namespace PocketLib.Pages
{
    public partial class NotePage : ContentPage
    {
        public NotePage()
        {
            InitializeComponent();
            BindingContext = new NotePageViewModel();
    
    }
    }
}