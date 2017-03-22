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
    public partial class PEBMasterDetailMenu : ContentPage
    {
        public ListView ListViewMenu { get { return listView; } }
        public PEBMasterDetailMenu()
        {
            InitializeComponent();

            var masterPageItem = new List<PEBMasterPageItem>()
            {
                new PEBMasterPageItem
                {
                    Title = "Home",
                    IconSource = "home.png",
                    TargetType = typeof(PEBMasterDetailHome)
                },
                new PEBMasterPageItem
                {
                    Title = "Contact",
                    IconSource = "home.png",
                    TargetType = typeof(PEBMasterDetailContact)
                }
            };
        }
    }
}
