namespace DataBindingDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var person = new Models.Person()
		{
			Name = "Sunil",
			Phone = "9738715787",
			Address = "Bangalore"
		};

		Binding personBinding = new Binding();
		personBinding.Source = person;
		personBinding.Path = "Name";

		txtName.SetBinding(Label.TextProperty, personBinding);

		//Binding using BindingContext
		txtNameBindingContext.BindingContext = person;
		txtNameBindingContext.SetBinding(Label.TextProperty, "Name");

		//Using BindingContext for entirepage
		BindingContext = person;
	}
}

