using DataBindingDemo.Models;

namespace DataBindingDemo.Pages;

public partial class NotifiedPageDemo : ContentPage
{
	Person person = new Person();

	public NotifiedPageDemo()
	{
		InitializeComponent();

        person = new Person()
        {
            Name = "Sunil",
            Phone = "9738715787",
            Address = "Bangalore"
        };

        BindingContext = person;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
        person.Name = "Sakshata";
        person.Phone = "8050957600";
        person.Address = "Challakere";
	}
}