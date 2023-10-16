using ViewModels;

namespace PocketLib.ViewModels;

public class DetailsPageViewModel
{
    public ManagerViewModel Mgr { get; set; }

    public string Id { get; set; }

    public DetailsPageViewModel(ManagerViewModel managerViewModel)
    {
        Mgr = managerViewModel;
    }
}