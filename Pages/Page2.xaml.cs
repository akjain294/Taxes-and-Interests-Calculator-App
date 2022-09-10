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
    public partial class _2 : ContentPage
    {
        public _2()
        {
            InitializeComponent();
        }

        public async void navigatetohome()
        {
            await Navigation.PushAsync(new SIPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            navigatetohome();

        }
    }
}