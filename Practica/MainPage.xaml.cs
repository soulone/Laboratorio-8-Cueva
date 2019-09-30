using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) => { await Navigation.PushAsync(new StackLayout());
            };
            Item2.Clicked += async (sender, e) => { await Navigation.PushAsync(new Grid());
            };
            Item3.Clicked += async (sender, e) => { await Navigation.PushAsync(new Hierarchical_Navigation());
            };
            Item4.Clicked += async (sender, e) => { await Navigation.PushAsync(new StackLayout());
            };
        }
    }
}
