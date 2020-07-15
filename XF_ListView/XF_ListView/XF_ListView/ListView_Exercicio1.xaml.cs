using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_ListView.Models;

namespace XF_ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView_Exercicio1 : ContentPage
    {
        public ListView_Exercicio1()
        {
            InitializeComponent();

            //List<String> itens = new List<string>()
            listview.ItemsSource = new List<String>()
            {
               "Abacate","Abacaxi","Banana","Caju","Goiaba","Laranja","Melancia","Pêssego","Tangerina"
            };

            //listview.ItemsSource = itens;
        }

        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Item Selecionado: ", e.SelectedItem.ToString(), "OK");
        }
    }
}

