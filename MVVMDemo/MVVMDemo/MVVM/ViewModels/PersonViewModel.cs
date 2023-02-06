using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMDemo.MVVM.Models;

namespace MVVMDemo.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }

        public PersonViewModel()
        {
            //Person = new Person()
            //{
            //    Name = "Sunil",
            //    Age = 30
            //};

            Person = new Person()
            {
                Name = "Sunil",
                Age = 30,
                Married = true,
                BirthDate = new DateTime(2000, 08, 05),
                Weight = 100,
                LunchTime = new TimeSpan(10, 0, 0)
            };
        }
    }
}
