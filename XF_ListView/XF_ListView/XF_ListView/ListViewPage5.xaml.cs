using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF_ListView.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.Collections.ObjectModel;

namespace XF_ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage5 : ContentPage
    {
        private ObservableCollection<Time> _timess;
        private ObservableCollection<Time> GetTimess()
        {
            _timess = new ObservableCollection<Time>
            {
                new Time { Nome="Palmeiras", Pontos=69, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" },
                new Time { Nome="Santos", Pontos=55, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" },
                new Time { Nome="Flamengo", Pontos=33, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" },
                new Time { Nome="Atletico", Pontos=38, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" },
                new Time { Nome="Botafogo", Pontos=74, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png"}
            };

            return _timess;
        }

        public ListViewPage5()
        {
            InitializeComponent();

            listview.ItemsSource = GetTimess();
        }

        private void Exibir_Clicked(object sender, EventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            Time time = menuItem.CommandParameter as Time;
            DisplayAlert("Time: ", time.Nome, "OK");
        }

        private void Deletar_Clicked(object sender, EventArgs e)
        {
            Time timee = (sender as MenuItem).CommandParameter as Time;
            _timess.Remove(timee);
        }

        private void lvw_Refreshing(object sender, EventArgs e)
        {
            listview.ItemsSource = GetTimess();
            //listview.IsRefreshing = false;
            listview.EndRefresh();
        }
    }
}

            
