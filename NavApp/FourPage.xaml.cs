using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavApp
{
    public partial class FourPage : ContentPage
    {
        void VoltarTela(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        void ProximaTela(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FifthPage());
        }
        public FourPage()
        {
            InitializeComponent();
        }
    }
}
