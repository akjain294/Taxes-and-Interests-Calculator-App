using Android.Content.Res;
using Login.Pages;
using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
namespace Login.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            if (email != "macoratti@yahoo.com" || password != "secret")
            {
                DisplayInvalidLoginPrompt();
            }
            else
            {
                // Navigation.PushAsync(new HomePage());
                // Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.HomePage());
              //  LoginPage l = new LoginPage();
               // l.navigatetohome();
            }
        }
    }
}