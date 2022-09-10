using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class browse : ContentPage
    {
        public browse()
        {
            InitializeComponent();
           string[] calculations = DependencyService.Get<IWirteService>().Readfile("myfile.txt");
            ObservableCollection<test> akash = new ObservableCollection<test>();
            foreach (var item in calculations)
            {
                akash.Add(new test() { Item = item.ToString() });
            }
            listv.ItemsSource = akash;
        }
    }
    public class test
    {
        public string Item { get; set; }
    }
}