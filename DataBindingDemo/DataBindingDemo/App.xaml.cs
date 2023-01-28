using DataBindingDemo.Pages;

namespace DataBindingDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		//MainPage = new SliderPage();
		//MainPage = new BindingModes();
		MainPage = new NotifiedPageDemo();

    }
}
