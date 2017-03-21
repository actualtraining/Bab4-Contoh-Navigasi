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
    public partial class FormNavigasi1 : ContentPage
    {
        public FormNavigasi1()
        {
            InitializeComponent();
            btnHal2.Clicked += BtnHal2_Clicked;

            menuHome.Clicked += MenuHome_Clicked;
            menuNavigasi2.Clicked += MenuNavigasi2_Clicked;
        }

        private async void MenuNavigasi2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormNavigasi2());
        }

        private async void MenuHome_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Keterangan", "Menu Home", "OK");
        }

        private async void BtnHal2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormNavigasi2());
        }
    }
}
