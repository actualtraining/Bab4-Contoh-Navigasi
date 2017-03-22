using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bab4_Contoh_Navigasi
{
    public class Global
    {
        private static Global _instance;
        public static Global Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Global();
                }
                return _instance;
            }
        }

        public Pengguna DataPengguna { get; set; }
    }

   
}
