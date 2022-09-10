using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages._1());
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages._2());
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages._3());
        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages._4());
        }
    }
}