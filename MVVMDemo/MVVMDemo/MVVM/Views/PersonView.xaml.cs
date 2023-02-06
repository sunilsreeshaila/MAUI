using MVVMDemo.MVVM.Models;
using MVVMDemo.MVVM.ViewModels;

namespace MVVMDemo.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();

        //Person person = new Person()
        //{
        //    Name = "Sunil",
        //    Age = 30
        //};
        //BindingContext = person;

        BindingContext = new PersonViewModel();
    }
}