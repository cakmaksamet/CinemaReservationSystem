using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace deneme
{
    class ResimIslemleri
    {
        public static string defResimYolu = @"C:\Users\Public\görsel\las.jpg";
            
        public static Image Get_Bitmap(string ResimYolu)
        {
            using (Image im = Image.FromFile(ResimYolu))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

    }
}
