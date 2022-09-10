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
    public partial class _4 : ContentPage
    {
        public _4()
        {
            InitializeComponent();
        }

        public async void navigatetohome()
        {
            await Navigation.PushAsync(new CIPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            navigatetohome();

        }
    }
}