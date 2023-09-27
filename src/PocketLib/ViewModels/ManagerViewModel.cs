using Model;
using StubLib;

namespace PocketLib.ViewModels;

public class ManagerViewModel : BindableObject
{
    
    public ManagerViewModel()
    {
        Manager = new LibraryStub();
    }
    public ILibraryManager Manager { get; set; }

}