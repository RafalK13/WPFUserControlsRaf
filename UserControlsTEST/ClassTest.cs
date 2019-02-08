using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlsTEST
{
    public class Person {
        public string name { get; set; }
        public string city { get; set; }
    }

    public class ClassTest : ViewModelBase
    {
        #region public string nameProp
        private string _nameProp;
        public string nameProp
        {
            get => _nameProp;

            set
            {
                _nameProp = value;
                RaisePropertyChanged("nameProp");
            }
        }
        #endregion

        public List<Person> person { get; set; } = new List<Person>();

        public ClassTest()
        {
            nameProp = "Hanka";

            person.Add(new Person { name="Rafałek", city="Gdańsk"});
            person.Add(new Person { name = "Hanka", city = "NY" });
            person.Add(new Person { name = "Beti", city = "Sybir" });
        }
    }
}
