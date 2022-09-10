using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Login.ViewModels;

namespace Login.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginViewModel vm = new LoginViewModel();
        public LoginPage()
        {
           
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            InitializeComponent();

            Email.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
                
            };            
        }

        public async void navigatetohome()
        {
          await  Navigation.PushAsync(new FirstPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (vm.Email != "ajain294@gmail.com" || vm.Password != "secret")
            {
                vm.DisplayInvalidLoginPrompt();
            }
            else
            {
                navigatetohome();
            }
        }
    }
}