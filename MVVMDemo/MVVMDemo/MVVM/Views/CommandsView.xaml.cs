using MVVMDemo.MVVM.ViewModels;

namespace MVVMDemo.MVVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
        BindingContext = new CommandsViewModel();
    }

    //private void Button_Clicked(object sender, EventArgs e)
    //{

    //}
}