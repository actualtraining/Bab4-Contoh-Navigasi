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
    public partial class SampleModalForm : ContentPage
    {
        private List<Contact> listContacts;
        public SampleModalForm()
        {
            InitializeComponent();

            SetupData();
            listview.ItemsSource = listContacts;
            listview.ItemSelected += Listview_ItemSelected;
        }

        private async void Listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listview.SelectedItem != null)
            {
                var detailPage = new DetailContact();
                var currContanct = e.SelectedItem as Contact;
                detailPage.BindingContext = currContanct;
                await Navigation.PushModalAsync(detailPage);
            }
        }

        void SetupData()
        {
            listContacts = new List<Contact>
            {
                new Contact
                {
                    Name = "Tim Olsen",
                    Age = 35,
                    Occupation = "Lecturer",
                    Country = "USA"
                },
                new Contact
                {
                    Name = "Mika Shaura",
                    Age = 50,
                    Occupation = "Lecturer",
                    Country = "Japan"
                },
                new Contact
                {
                    Name = "Iwan Setiawan",
                    Age = 45,
                    Occupation = "Dean",
                    Country = "Indonesia"
                }
            };
        }
    }
}
