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
            var currUser = new Pengguna
            {
                Username = "erick",
                Password = "rahasia",
                Aturan = "admin"
            };
            Application.Current.Properties["pengguna"] = currUser;

            btnHal2.Clicked += BtnHal2_Clicked;

            menuHome.Clicked += MenuHome_Clicked;
            menuNavigasi2.Clicked += MenuNavigasi2_Clicked;

            btnCurrAppParam.Clicked += BtnCurrAppParam_Clicked;
            btnGlobal.Clicked += BtnGlobal_Clicked;
        }

        private void BtnGlobal_Clicked(object sender, EventArgs e)
        {
            Global.Instance.DataPengguna = new Pengguna { Username = "Budi", Password = "rahasia", Aturan = "admin" };
        }

        private async void BtnCurrAppParam_Clicked(object sender, EventArgs e)
        {
            var param = (Pengguna)Application.Current.Properties["pengguna"];

            //Application.Current.Properties["pengguna"] = "Budi";
            await DisplayAlert("Keterangan", "Param dr app param : " + param.Username + " " + param.Aturan,"OK");
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
            await Navigation.PushAsync(new FormNavigasi2(txtParameter.Text));
        }
    }
}
