using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Method injection
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggarService)
        {
            //Basvuru bilgilerini değerlendirme
            krediManager.Hesapla();
            loggarService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List <IKrediManager> krediler)

        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }

    }


}
