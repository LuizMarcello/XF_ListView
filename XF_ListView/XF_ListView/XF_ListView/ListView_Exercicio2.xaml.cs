using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView_Exercicio2 : ContentPage
    {
        public ListView_Exercicio2()
        {
            InitializeComponent();


            ListView listview = new ListView();
            listview.SeparatorColor = Color.Black;
            listview.BackgroundColor = Color.Aqua;

            //List<string> itens = new List<string>()
            listview.ItemsSource = new List<string>
            {
               "Abacate", "Abacaxi", "Banana", "Caju", "Figo", "Goiaba", "Laranja", "Melancia", "Pêssego", "Tangerina"
            };

            //listview.ItemsSource = itens;

            Content = listview;



        }
    }
}