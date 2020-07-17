using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_ListView.Models;

namespace XF_ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView_Exercicio8 : ContentPage
    {
        public ListView_Exercicio8()
        {
            InitializeComponent();
            listview.ItemsSource = GetProdutos();
        }

        private ObservableCollection<Produto> produtoss;

        public ObservableCollection<Produto> GetProdutos()
        {
            produtoss = new ObservableCollection<Produto>()
            {
                new Produto {Nome="Câmera", Preco="269,00", Imagem="http://macoratti.net/Imagens/produtos/camera64.jpg"},
                new Produto {Nome="Tablet", Preco="367,50",Imagem="http://macoratti.net/Imagens/produtos/tablet64.jpg"},
                new Produto {Nome="Celular", Preco="564,00",Imagem="http://macoratti.net/Imagens/produtos/celular64.jpg"},
                new Produto {Nome="iPhone5", Preco="1962,00",Imagem="http://macoratti.net/Imagens/produtos/iphone64.jpg"}
            };
            return produtoss;
        }

        private void Exibir_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var produto = menuItem.CommandParameter as Produto;
            DisplayAlert("Produto: ", produto.Nome, "OK");
        }

        private void Deletar_Clicked_1(object sender, EventArgs e)
        {
            var produto = (sender as MenuItem).CommandParameter as Produto;
            produtoss.Remove(produto);
        }
    }
}




