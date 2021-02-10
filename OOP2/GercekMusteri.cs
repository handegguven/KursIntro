using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Musteri evbebeyin
    class GercekMusteri:Musteri //biz : bu olaya miras //inheratance diyoruz. Gercek musteriyi musteriye
        //baglyoruz. 
    {

        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
