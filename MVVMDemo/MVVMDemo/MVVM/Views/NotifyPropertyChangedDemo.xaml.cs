using MVVMDemo.MVVM.ViewModels;

namespace MVVMDemo.MVVM.Views;

public partial class NotifyPropertyChangedDemo : ContentPage
{
	public NotifyPropertyChangedDemo()
	{
		InitializeComponent();
        BindingContext = new NotifyPropertyChangedViewModel();
    }
}