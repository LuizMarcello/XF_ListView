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
    public partial class ListViewPage2 : ContentPage
    {
        public ListViewPage2()
        {
            InitializeComponent();

            listview.ItemsSource = new List<Time>
            {
                new Time {Nome="Palmeiras", Pontos=69,
                          Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" }
            };
        }
    }
}
