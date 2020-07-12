﻿using System;
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
    public partial class ListViewPage4 : ContentPage
    {
        public ListViewPage4()
        {
            InitializeComponent();

            listview.ItemsSource = new List<TimeGrupo>
            {
                new TimeGrupo("A","A")
                {
                    new Time { Nome="Atletico", Pontos=38, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" },
                    new Time { Nome="America", Pontos=48, Imagem="http://macoratti.net/Imagens/times/palmeiras.png" }
                },

                new TimeGrupo("B","B")
                {
                    new Time { Nome="Botafogo", Pontos=74, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png"}
                },

                new TimeGrupo("F","F")
                {
                    new Time { Nome="Flamengo", Pontos=33, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" }
                },

                new TimeGrupo("P","P")
                {
                    new Time {Nome="Palmeiras", Pontos=69, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png" }
                },

                new TimeGrupo("S","S")
                {
                    new Time {Nome="Santos", Pontos=55, Imagem="http://macoratti.net/Imagens/times/palmeiras64.png"}
                },
            };
        }
    }
}


                
                
                
                
                
           

