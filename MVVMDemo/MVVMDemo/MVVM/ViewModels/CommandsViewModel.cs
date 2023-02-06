using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        //public ICommand ClickCommand => new Command(() => App.Current.MainPage.DisplayAlert("Title", "Message", "OK"));

        //public ICommand ClickCommand => new Command(Alert);

        public ICommand ClickCommand { get; }

        public CommandsViewModel()
        {
            ClickCommand = new Command(Alert);
            //SearchCommand = new Command(() =>
            //{
            //    var data = SearchTerm;
            //});

            SearchCommand = new Command((s) =>
            {
                var data = s;
            });
        }

        private void Alert()
        {
            App.Current.MainPage.DisplayAlert("Title", "Message", "OK");
        }

        public ICommand SearchCommand { get; }

        public string SearchTerm { get; set; }
    }
}
