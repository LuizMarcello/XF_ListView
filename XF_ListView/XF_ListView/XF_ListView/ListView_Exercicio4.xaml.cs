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
    public partial class ListView_Exercicio4 : ContentPage
    {
        public List<Produto> GetProdutos() 
        {
            List<Produto> prod = new List<Produto>()
            {
               new Produto {Nome="Linguiça", Preco="24,00", Imagem="http://macoratti.net/Imagens/produtos/camera64.jpg"},
               new Produto {Nome="Carro", Preco="45.000,00", Imagem="http://macoratti.net/Imagens/produtos/tablet64.jpg"},
               new Produto {Nome="Roupa", Preco="123,00", Imagem="http://macoratti.net/Imagens/produtos/celular64.jpg"},
               new Produto {Nome="Mesa", Preco="123,67", Imagem="http://macoratti.net/Imagens/produtos/iphone64.jpg"}
            };
            return prod;
        }

        public ListView_Exercicio4()
        {
            InitializeComponent();

            var listview = new ListView();
            listview.ItemsSource = GetProdutos();

            listview.ItemTemplate = new DataTemplate(typeof(ImageCell));

            listview.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "Imagem");
            listview.ItemTemplate.SetBinding(ImageCell.TextProperty, "Nome");
            listview.ItemTemplate.SetBinding(ImageCell.DetailProperty, "Preco");
            
            Content = listview;
        }
    }
}

            
            



            
