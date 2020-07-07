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
    public partial class ListViewPage2 : ContentPage
    {
        public ListViewPage2()
        {
            InitializeComponent();

            listview.ItemsSource = new List<Time>
            {
              new Time { Nome="Palmeiras", Pontos=69,
                    Imagem ="http://macoratti.net/Imagens/times/palmeiras64.png" },
              new Time { Nome="Flamengo", Pontos=67,
                    Imagem ="http://macoratti.net/Imagens/times/flamengo64.jpg" },
              new Time { Nome="Santos", Pontos=64,
                    Imagem ="http://macoratti.net/Imagens/times/santos64.jpg" },
              new Time { Nome="Atletico", Pontos=62,
                    Imagem ="http://macoratti.net/Imagens/times/atletico64.jpg" },
              new Time { Nome="Botafogo", Pontos=59,
                    Imagem ="http://macoratti.net/Imagens/times/botafogo64.jpg" }
            };
        }
    }
}



