using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavApp
{
    public partial class MainPage : ContentPage
    {
        void ProximaTela(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
