using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMDemo.MVVM.Models;

namespace MVVMDemo.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        //public List<string> People { get; set; }

        public List<Person> People { get; set; } = new List<Person>();


        public PeopleViewModel()
        {
            //People = new List<string>()
            //{
            //    "Sunil",
            //    "Sakshata",
            //    "Divisha",
            //    "Suman",
            //    "Suma",
            //    "Punarvi"
            //};

            People.Add(new Person(){ Name= "Sunil", Age = 29, Married = true, BirthDate = new DateTime(1993, 9, 15), Weight = 78, LunchTime = new TimeSpan(1, 30, 0)});
            People.Add(new Person(){ Name= "Sakshata", Age = 30, Married = true, BirthDate = new DateTime(1992, 6, 21), Weight = 74, LunchTime = new TimeSpan(1, 0, 0)});
            People.Add(new Person(){ Name= "Manu", Age = 30, Married = true, BirthDate = new DateTime(1992, 9, 28), Weight = 93, LunchTime = new TimeSpan(2, 30, 0)});
            People.Add(new Person(){ Name= "Anok", Age = 32, Married = false, BirthDate = new DateTime(1992, 6, 2), Weight = 86, LunchTime = new TimeSpan(12, 30, 0)});
            People.Add(new Person(){ Name= "Pradeep", Age = 31, Married = false, BirthDate = new DateTime(1992, 7, 31), Weight = 82, LunchTime = new TimeSpan(2, 0, 0)});
        }
    }
}
