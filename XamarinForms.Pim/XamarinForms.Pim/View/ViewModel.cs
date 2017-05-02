using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinForms.Pim
{
    public class ViewModel
    {

        public ObservableCollection<List<Person>> Data
        {
            get
            {
                return Person.Data;
            }

        }

        public ViewModel()
        {

            Person.Data.Add(new List<Person>()
            {
                new Person { Pagamento = "MasterCard Debito", Valor = 520 },
                new Person { Pagamento = "MasterCard Credito", Valor = 320 },
                new Person { Pagamento = "Visa Debito", Valor = 165.65M },
                new Person { Pagamento = "Visa Credito", Valor = 120.5M },
                new Person { Pagamento = "Sodexo", Valor = 65 },
                new Person { Pagamento = "Alelo", Valor = 75 },
                new Person { Pagamento = "RedeCard", Valor = 45 },
                new Person { Pagamento = "Dinheiro", Valor = 25},
                new Person { Pagamento = "Cheque", Valor = 5 }
            });


        }


    }
    public class Person
    {

        public string Pagamento { get; set; }

        public decimal Valor { get; set; }

        private static ObservableCollection<List<Person>> _data = new ObservableCollection<List<Person>>();

        public static ObservableCollection<List<Person>> Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
            }
        }




    }
}
