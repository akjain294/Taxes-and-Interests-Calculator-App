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
    public partial class CIPage : ContentPage
    {
        public CIPage()
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
                return;
            }


            if (picker.SelectedItem.ToString() == "Yearly")
            {
                
                
                double amt =Convert.ToDouble((((input2 + 100) / 100)));
                double rate = Convert.ToDouble(Math.Pow(amt, input3));
                double netamt=Convert.ToDouble(rate*input1);
                
                double ci= Convert.ToDouble(netamt - input1);
                result.Text = Convert.ToString(netamt);
                result1.Text = Convert.ToString(ci);
            }
            else if(picker.SelectedItem.ToString() == "Half yearly")
            {
                
                double amt = Convert.ToDouble((((input2/2) + 100) / 100));
                double rate = Convert.ToDouble(Math.Pow(amt, input3*2));
                double netamt = Convert.ToDouble(rate * input1);

                double ci = Convert.ToDouble(netamt - input1);
                result.Text = Convert.ToString(netamt);
                result1.Text = Convert.ToString(ci);
            }
            else
            {
                
                double amt = Convert.ToDouble((((input2 / 4) + 100) / 100));
                double rate = Convert.ToDouble(Math.Pow(amt, input3 * 4));
                double netamt = Convert.ToDouble(rate * input1);

                double ci = Convert.ToDouble(netamt - input1);
                result.Text = Convert.ToString(netamt);
                result1.Text = Convert.ToString(ci);
            }
           

        }

        private void BtnClr_Clicked(object sender, EventArgs e)
        {
            principal.Text = String.Empty;
            Rate.Text = String.Empty;
            Time.Text = String.Empty;
            result.Text = String.Empty;
            result1.Text = String.Empty;
            picker.SelectedIndex = -1;
        }
    }
}