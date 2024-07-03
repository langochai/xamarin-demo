using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        private string[] questions = { "no1no1no1no1no1no1no1no1no1no1no1", "no2no2no2no2no2no2no2no2no2no2no2", "no3no3no3no3no3no3no3no3no3no3no3" };
        private string[] colors = { "red", "blue", "purple", "green", "yellow", "brown" };
        public GreetPage()
        {
            InitializeComponent();
        }
    }
}