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
    public partial class ListViewPage1 : ContentPage
    {
        public ListViewPage1()
        {
            InitializeComponent();

            List<String> itens = new List<string>()
            {
                "Palmeiras","Flamengo","Santos","Atletico","Botafogo"
            };

            listview.ItemsSource = itens;

        }

        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Item Selecionado: ", e.SelectedItem.ToString(), "OK");
        }
    }
}