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
    public partial class ListViewPageCode : ContentPage
    {
        public ListViewPageCode()
        {
            InitializeComponent();

            var listview = new ListView();
            listview.ItemsSource = new List<Time>
            {
                new Time { Nome="Palmeiras", Pontos=69, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" },
                new Time { Nome="Santos", Pontos=55, Imagem="http://macoratti.net/Imagens/times/santos64.png" },
                new Time { Nome="Flamengo", Pontos=33, Imagem="http://macoratti.net/Imagens/times/flamengo64.png" },
                new Time { Nome="Atletico", Pontos=38, Imagem="http://macoratti.net/Imagens/times/atletico64.png" },
                new Time { Nome="Botafogo", Pontos=74, Imagem="http://macoratti.net/Imagens/times/botafogo64.png"}
            };

            listview.ItemTemplate = new DataTemplate(typeof(ImageCell));

            listview.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "Imagem");
            listview.ItemTemplate.SetBinding(ImageCell.TextProperty, "Nome");
            listview.ItemTemplate.SetBinding(ImageCell.DetailProperty, "Pontos");
            listview.ItemTemplate.SetBinding(ImageCell.TextColorProperty, "Yellow");
            listview.ItemTemplate.SetBinding(ImageCell.DetailColorProperty, "Silver");

            //this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            Content = listview;
        }
    }
}
