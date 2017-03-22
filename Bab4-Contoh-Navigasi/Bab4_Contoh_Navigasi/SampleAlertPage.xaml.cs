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
    public partial class SampleAlertPage : ContentPage
    {
        public SampleAlertPage()
        {
            InitializeComponent();

            btnAlertYesNo.Clicked += BtnAlertYesNo_Clicked;
            btnAlert.Clicked += BtnAlert_Clicked;
        }

        private async void BtnAlert_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Bahasa pemrograman favorite ?", "Cancel", null,
                "C#", "Java", "VB", "Swift", "Phyton", "Go");

            await DisplayAlert("Keterangan", "Anda memilih " + action,"OK");
        }

        private async void BtnAlertYesNo_Clicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Konfirmasi", "Apakah anda yakin untuk mendelete data?",
                "Yes", "No");
            if (answer)
            {
                await DisplayAlert("Keterangan", "Data berhasil di delete !", "OK");
            }
            else
            {
                await DisplayAlert("Keterangan", "Data gagal untuk di delete !", "OK");
            }
        }
    }
}
