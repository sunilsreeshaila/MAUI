using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyChanged;

namespace MVVMDemo.MVVM.ViewModels
{
    //public class NotifyPropertyChangedViewModel
    //{
    //    public int Number1 { get; set; }
    //    public int Number2 { get; set; }
    //    public int Result { get; set; }

    //    public ICommand AddCommand => new Command(() => Result = Number1 + Number2);
    //}

    //public class NotifyPropertyChangedViewModel : INotifyPropertyChanged
    //{
    //    private int number1;

    //    public int Number1
    //    {
    //        get { return number1; }
    //        set
    //        {
    //            number1 = value;
    //            OnPropertyChanged();
    //        }
    //    }

    //    private int number2;

    //    public int Number2
    //    {
    //        get { return number2; }
    //        set
    //        {
    //            number2 = value;
    //            OnPropertyChanged();
    //        }
    //    }

    //    private int result;

    //    public int Result
    //    {
    //        get { return result; }
    //        set
    //        {
    //            result = value;
    //            OnPropertyChanged();
    //        }
    //    }




    //    public ICommand AddCommand => new Command(() => Result = Number1 + Number2);


    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}

    


    //After installing PropertyChanged.Fody nuget package. NotifyPropertyChanged works automatically
    [AddINotifyPropertyChangedInterface]
    public class NotifyPropertyChangedViewModel
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Result { get; set; }

        public ICommand AddCommand => new Command(() => Result = Number1 + Number2);
    }
}
