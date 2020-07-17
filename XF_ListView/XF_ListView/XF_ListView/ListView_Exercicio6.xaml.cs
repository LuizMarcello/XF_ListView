using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_ListView.Models;


namespace XF_ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView_Exercicio6 : ContentPage
    {
        public ListView_Exercicio6()
        {
            InitializeComponent();
            //listview.ItemsSource = GetProdutosAgrupados();
            
        }

        //public List<ProdutoGrupo> GetProdutosAgrupados()
        //{
        //    return new List<ProdutoGrupo>
        //    {
        //        new ProdutoGrupo("C", "C")
        //        {
        //          new Produto { Nome="Câmera", Preco="R$ 269,00",
        //                Imagem ="http://macoratti.net/Imagens/produtos/camera64.jpg" },
        //          new Produto { Nome="Celular", Preco="R$ 564,00",
        //                Imagem ="http://macoratti.net/Imagens/produtos/celular64.jpg"}
        //        },
        //        new ProdutoGrupo("I", "I")
        //        {
        //             new Produto { Nome="iPhone S", Preco="R$ 1962,00",
        //                Imagem ="http://macoratti.net/Imagens/produtos/iphone64.jpg" }
        //        },
        //        new ProdutoGrupo("T", "T")
        //        {
        //             new Produto { Nome="Tablet", Preco="R$ 367,50",
        //                Imagem ="http://macoratti.net/Imagens/produtos/tablet64.jpg" }
        //        }
        //    };
        //}
    }
}






