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
    public partial class ListView_Exercicio9 : ContentPage
    {
        public ListView_Exercicio9()
        {
            InitializeComponent();
            listview.ItemsSource = GetProdutos();
        }

        public List<Produto> GetProdutos(string filtro = null)
        {
            var produtoos = new List<Produto>()
            {
                new Produto {Nome="Câmera", Preco="269,00", Imagem="http://macoratti.net/Imagens/produtos/camera64.jpg"},
                new Produto {Nome="Tablet", Preco="367,50",Imagem="http://macoratti.net/Imagens/produtos/tablet64.jpg"},
                new Produto {Nome="Celular", Preco="564,00",Imagem="http://macoratti.net/Imagens/produtos/celular64.jpg"},
                new Produto {Nome="iPhone5", Preco="1962,00",Imagem="http://macoratti.net/Imagens/produtos/iphone64.jpg"}
            };

            if (string.IsNullOrWhiteSpace(filtro))
                return produtoos;

            return produtoos.Where(p => p.Nome.Contains(filtro)).ToList();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listview.ItemsSource = GetProdutos(e.NewTextValue);
        }
    }
}



