using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerLog.MODEL
{
    public class Takim
    {
        private int takımId;
        private string takımAdi;
        private string eyaletAdi;
        public string resim;






        public int ID { get; set; }

        public string TAKIMADI { get => takımAdi; set => takımAdi = value; }

        public string EYALETADI { get => eyaletAdi; set => eyaletAdi = value; }

        public int TAKIMID { get => takımId; set => takımId = value; }

        public string Resim { get => resim; set => resim = value; }

    }
}
