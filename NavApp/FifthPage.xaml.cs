using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavApp
{
    public partial class FifthPage : ContentPage
    {
        void VoltarTela(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public FifthPage()
        {
            InitializeComponent();
        }
    }
}
