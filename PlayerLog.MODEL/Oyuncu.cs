using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerLog.MODEL
{
    public class Oyuncu
    {
         #region Fields
        public int oyuncuId;
        public int takımId;
        public int bolgeId;
        public string overall;
        public string ad;
        public string soyad;
        public string numara;
        public string boy;
        public DateTime dogumTarihiId;
        #endregion

        #region Properties
        public int Oyun { get => oyuncuId; set => oyuncuId = value; }
        public int ID { get; set; }
        public int TAKIMID { get => takımId; set => takımId = value; }
        public int BOLGEID { get => bolgeId; set => bolgeId = value; }
        public string Overall { get => overall; set => overall = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Numara { get => numara; set => numara = value; }
        public string Boy { get => boy; set => boy = value; }
        public DateTime DogumTarihi { get => dogumTarihiId; set => dogumTarihiId = value; }

        #endregion

       
    }
}
