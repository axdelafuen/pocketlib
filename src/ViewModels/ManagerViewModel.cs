using System.Net.Mail;
using Model;
using StubLib;

namespace ViewModels;

public class ManagerViewModel
{
    public Manager Manager { get; set; }
    
    public ManagerViewModel(Manager manager)
    {
        Manager = manager;
    }
    
    public ManagerViewModel(ILibraryManager libraryManager, IUserLibraryManager userLibraryManager)
        :this(new Manager(libraryManager, userLibraryManager)){}
    
    
}