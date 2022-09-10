using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace Login.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {


            int TotalIncome = 0;
            int TotalIncome1 = 0;
            if (Income.Text!="")
            {
                TotalIncome= Convert.ToInt32(Income.Text);

            }
            TotalIncome1 = TotalIncome;
            //int cess = Convert.ToInt32(ans);
            //  int relief = Convert.ToInt32(50000);
            int incometax=0;
            int cess=0;
            if (picker1.SelectedItem.ToString() == "New Tax Regime")
            {
                if (TotalIncome <= 0)
                {
                    DisplayAlert("Total Income", "please enter correct income", "cancel");
                }
             
                if (TotalIncome <= 500000)
                {
                    result.Text = Convert.ToString(TotalIncome * 0);
                    ans.Text = Convert.ToString(0);
                }
                else if (TotalIncome > 500000 && TotalIncome <= 750000)
                {
                    TotalIncome = TotalIncome - 500000;
                    incometax = Convert.ToInt32(((TotalIncome * 0.1) + 12500) );


                }
                else if (TotalIncome > 750000 && TotalIncome <= 1000000)
                {
                    TotalIncome = TotalIncome - 750000;
                    incometax = Convert.ToInt32(((TotalIncome * 0.15) + 12500 + 25000));

                }
                else if (TotalIncome > 100000 && TotalIncome <= 1250000)
                {
                    TotalIncome = TotalIncome - 1000000;
                    incometax = Convert.ToInt32(((TotalIncome * 0.15) + 12500 + 25000 + 37500) );
                }
                else if (TotalIncome > 1250000 && TotalIncome <= 1500000)
                {
                    TotalIncome = TotalIncome - 1250000;

                    incometax = Convert.ToInt32(((TotalIncome * 0.25) + 12500 + 25000 + 37500 + 50000) );
                }
                else if (TotalIncome > 1500000)
                {
                    TotalIncome = TotalIncome - 1500000;
                    result.Text = Convert.ToString(TotalIncome * 0.3);
                    int net = Convert.ToInt32(result.Text);
                    ans.Text = Convert.ToString(net);
                    incometax = Convert.ToInt32(((TotalIncome * 0.3) + 12500 + 25000 + 37500 + 50000) );
                }
            }
            else
            {
                int total_Deduction = 0;
                if (TotalIncome <= 0)
                {
                    DisplayAlert("Total Income", "please enter correct income", "cancel");
                }
                if(Deduct.Text!="")
                {
                    total_Deduction = Convert.ToInt32(Deduct.Text);
                }

                TotalIncome=TotalIncome - total_Deduction;
                if (TotalIncome <= 500000)
                {
                    result.Text = Convert.ToString(TotalIncome * 0);
                    ans.Text = Convert.ToString(0);
                }
                else if (TotalIncome > 500000 && TotalIncome <= 1000000)
                {
                    TotalIncome = TotalIncome - 500000;
                    incometax = Convert.ToInt32(((TotalIncome * 0.2) + 12500));


                }
                else if (TotalIncome > 1000000)
                {
                    TotalIncome = TotalIncome - 1000000;
                    incometax = Convert.ToInt32(((TotalIncome * 0.3) + 12500 + 100000));

                }
               
            }
            result.Text = Convert.ToString(incometax);
            cess = Convert.ToInt32(incometax * 0.04);
            ecess.Text = Convert.ToString(cess);
            ans.Text = Convert.ToString(incometax+cess);
            DependencyService.Get<IWirteService>().wirteFile("myfile.txt", TotalIncome1, incometax);
            
        }

        private void picker1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            
        }

        private void picker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (picker1.SelectedItem.ToString() == "New Tax Regime")
            {
                Deduct.IsEnabled = false;
            }
            else
            {
                Deduct.IsEnabled = true;
            }
        }

        public async void navigatetohome()
        {
            await Navigation.PushAsync(new browse());
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            navigatetohome();

        }
    }
}