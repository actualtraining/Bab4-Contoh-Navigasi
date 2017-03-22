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

        private string param;
        public FormNavigasi2(string param)
        {
            InitializeComponent();
            this.param = param;
            btnForm1.Clicked += BtnForm1_Clicked;
            btnParam.Clicked += BtnParam_Clicked;
            btnGetAppParam.Clicked += BtnGetAppParam_Clicked;

            btnAmbilGlobal.Clicked += BtnAmbilGlobal_Clicked;
        }

        private async void BtnAmbilGlobal_Clicked(object sender, EventArgs e)
        {
            var pengguna = (Pengguna)Global.Instance.DataPengguna;
            await DisplayAlert("Keterangan", "Data pengguna " + pengguna.Username + " " + pengguna.Password,"OK");
        }

        private async void BtnGetAppParam_Clicked(object sender, EventArgs e)
        {
            var param = (Pengguna)Application.Current.Properties["pengguna"];
            await DisplayAlert("Keterangan", "Param dr app param : " + param.Username + " "+param.Aturan, "OK");
        }

        private async void BtnParam_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Keterangan", "Param : " + param, "OK");
        }

        private async void BtnForm1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


    }
}
