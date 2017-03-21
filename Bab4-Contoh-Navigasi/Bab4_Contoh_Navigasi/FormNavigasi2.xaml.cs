using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bab4_Contoh_Navigasi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormNavigasi2 : ContentPage
    {
        public FormNavigasi2()
        {
            InitializeComponent();
            btnForm1.Clicked += BtnForm1_Clicked;
        }

        private async void BtnForm1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
