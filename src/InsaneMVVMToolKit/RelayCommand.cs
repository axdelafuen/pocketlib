using System.Windows.Input;

namespace InsaneMVVMToolKit;

public class RelayCommand<T>:ICommand
{
    public event EventHandler? CanExecuteChanged;
    
    private readonly Action<T> execute;
    private readonly Func<T, bool> canExecute;

    public RelayCommand(Action<T> execute, Func<T, bool> canExecute = null)
    {
        this.execute = execute;
        this.canExecute = canExecute;
    }
    
    public bool CanExecute(object? parameter)
    {
        if (parameter == null)
        {
            return true;
        }
        return canExecute((T)parameter);
    }

    public void Execute(object? parameter)
    {
        execute((T)parameter);
    }

    public async Task ExecuteAsync(object? parameter)
    {
        await ExecuteAsync((T)parameter);
    }

}