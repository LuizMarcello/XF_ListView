﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_ListView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListView_Exercicio3();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
