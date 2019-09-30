using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;


namespace Practica
{
    public partial class Hierarchical_Navigation : ContentPage
    {
        public Hierarchical_Navigation()
        {
            InitializeComponent();
            btnClose.Clicked += async (sender, e) => { await Navigation.PopAsync(); };
        }
        async void OnNextPageButtonClicked(object sender, EventArgs e) { await Navigation.PushAsync(new Hierarchical_Navigation2()); }
    }

}