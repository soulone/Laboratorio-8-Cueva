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
    public partial class Hierarchical_Navigation2 : ContentPage
    {
        public Hierarchical_Navigation2()
        {
            InitializeComponent();

            async void OnPreviousPageButtonClicked(object sender, EventArgs e) { await Navigation.PopAsync(); }
        }
    }
}