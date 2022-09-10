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
    public partial class SIPage : ContentPage
    {
        public SIPage()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
           
            double input1 = Convert.ToDouble(principal.Text);
            double input2 = Convert.ToDouble(Rate.Text);
            double input3 = Convert.ToDouble(Time.Text);
           
            if (input1 <= 0 || input2<=0 || input3<=0)
            {
                DisplayAlert("Total Amount", "please enter correct value", "cancel");
                return;
            }
            if (input1 == null || input2 == null || input3 == null)
            {
                DisplayAlert("Total Amount", "please enter some value", "cancel");
                return ;
            }
            result.Text = Convert.ToString((input1 * input2 * input3) / 100);
        }
        private void Button_Clicked1(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(principal.Text);
            double input4=Convert.ToDouble(Si.Text);
            double input3 = Convert.ToDouble(Time.Text);
            
            if (input1 <= 0 || input4<=0 || input3<=0)
            {
                DisplayAlert("Total Amount", "please enter correct value", "cancel");
                return;
            }
            if (input1 == null || input4 == null || input3 == null)
            {
                DisplayAlert("Total Amount", "please enter some value", "cancel");
                return;
            }

            result1.Text = Convert.ToString((input4 * 100) / (input1 * input3));
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(principal.Text);
            double input2 = Convert.ToDouble(Rate.Text);
            double input4 = Convert.ToDouble(Si.Text);
           
            if (input1 <= 0 || input4<=0 || input2<=0)
            {
                DisplayAlert("Total Amount", "please enter correct value", "cancel");
                return;
            }
            if (input1 == null || input2 == null || input4 == null)
            {
                DisplayAlert("Total Amount", "please enter some value", "cancel");
                return;
            }

            result2.Text = Convert.ToString((input4 * 100) / (input1 * input2));
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            double input3 = Convert.ToDouble(Time.Text);
            double input2 = Convert.ToDouble(Rate.Text);
            double input4 = Convert.ToDouble(Si.Text);
            
            if (input2 <= 0 || input3<=0 || input4<=0)
            {
                DisplayAlert("Total Amount", "please enter correct value", "cancel");
                return;
            }
            if (input4 == null || input2 == null || input4 == null)
            {
                DisplayAlert("Total Amount", "please enter some value", "cancel");
                return;
            }

            result3.Text = Convert.ToString((input4 * 100) / (input3 * input2));
        }

        private void BtnClr_Clicked(object sender, EventArgs e)
        {
            principal.Text = String.Empty;
            Rate.Text = String.Empty;
            Time.Text = String.Empty;
            Si.Text = String.Empty;
            result.Text = String.Empty;
            result1.Text = String.Empty;
            result2.Text = String.Empty;
            result3.Text = String.Empty;
        }

    }
}