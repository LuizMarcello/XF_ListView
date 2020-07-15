using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF_ListView.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage8 : ContentPage
    {
        //Com parâmetro recebendo null, na invocação do método,
        //não é obrigado a passar parâmetros.
        private List<Time> GetTimess(string filtro = null)
        {
            var times = new List<Time>
            {
                new Time { Nome="Palmeiras", Pontos=69, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" },
                new Time { Nome="Santos", Pontos=55, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" },
                new Time { Nome="Flamengo", Pontos=33, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" },
                new Time { Nome="Atletico", Pontos=38, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" },
                new Time { Nome="Botafogo", Pontos=74, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" },
                new Time { Nome="America", Pontos=46, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" }
            };

            if (string.IsNullOrWhiteSpace(filtro))
                return times;

            return times.Where(t => t.Nome.Contains(filtro)).ToList();
        }

        public ListViewPage8()
        {
            InitializeComponent();

            listview.ItemsSource = GetTimess();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listview.ItemsSource = GetTimess(e.NewTextValue);
        }
    }
}

