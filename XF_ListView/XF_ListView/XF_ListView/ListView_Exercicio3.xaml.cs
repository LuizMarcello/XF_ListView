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
    public partial class ListView_Exercicio3 : ContentPage
    {
        public ListView_Exercicio3()
        {
            InitializeComponent();
            listview.ItemsSource = GetProdutos();
        }

        public List<Produto> GetProdutos()
        {
            return new List<Produto>()
            {
                new Produto {Nome="Câmera", Preco="269,00", Imagem="http://macoratti.net/Imagens/produtos/camera64.jpg"},
                new Produto {Nome="Tablet", Preco="367,50",Imagem="http://macoratti.net/Imagens/produtos/tablet64.jpg"},
                new Produto {Nome="Celular", Preco="564,00",Imagem="http://macoratti.net/Imagens/produtos/celular64.jpg"},
                new Produto {Nome="iPhone5", Preco="1962,00",Imagem="http://macoratti.net/Imagens/produtos/iphone64.jpg"}
            };
        }
    }
}



