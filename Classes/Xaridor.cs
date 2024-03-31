namespace oopbank.Classes
{
    public class Xaridor
    {
        private Bank xaridorUchun;
        public Xaridor(Bank bank)
        {
            xaridorUchun = bank;
        }

        public void Balans(string ism, string hisobRaqam)
        {
            ism = ism.ToUpper();
            if(xaridorUchun.ismlar.Contains(ism))
            {
                if(xaridorUchun.hisobRaqamlar.Contains(hisobRaqam))
                {
                    int ind = xaridorUchun.hisobRaqamlar.IndexOf(hisobRaqam);
                    decimal balans = xaridorUchun.balanslar[ind];
                    System.Console.WriteLine(ism + "ning balansi "+balans+"so'm");
                }
                else
                {
                    System.Console.WriteLine("Bunday hisob raqam topilmadi");
                }
            }
            else
            {
                System.Console.WriteLine("Bunday ism topilmadi");
            }
        }
        
        public void PulOtkazish(string otkazuvchiRaqam, string qabulQiluvchiRaqam, decimal som)
        {
            if(xaridorUchun.hisobRaqamlar.Contains(otkazuvchiRaqam) && xaridorUchun.hisobRaqamlar.Contains(qabulQiluvchiRaqam))
            {
                int otkazuvchiUchunIndex = xaridorUchun.hisobRaqamlar.IndexOf(otkazuvchiRaqam);
                int qabulQiluvchiUchunIndex = xaridorUchun.hisobRaqamlar.IndexOf(qabulQiluvchiRaqam);
                if(xaridorUchun.balanslar[otkazuvchiUchunIndex]>=som)
                {
                    xaridorUchun.balanslar[otkazuvchiUchunIndex] = xaridorUchun.balanslar[otkazuvchiUchunIndex] - som;
                    xaridorUchun.balanslar[qabulQiluvchiUchunIndex] = xaridorUchun.balanslar[qabulQiluvchiUchunIndex] + som;
                    System.Console.WriteLine("o'tkazma muvoffaqitli bajarildi");
                }
                else
                {
                    System.Console.WriteLine("hisobingizda mablag' yetarli emas");
                }              
            }
            else
            {
                System.Console.WriteLine("Bunaqa karta topilmadi");
            }
        }
        
        public void Depozit(string ism, string hisobRaqam, int oy, decimal som) //10%li
        {
            ism = ism.ToUpper();
            if(xaridorUchun.ismlar.Contains(ism))
            {
                if(xaridorUchun.hisobRaqamlar.Contains(hisobRaqam))
                {
                    if(oy>0 && oy<13)
                    {
                        if(xaridorUchun.balanslar[xaridorUchun.hisobRaqamlar.IndexOf(hisobRaqam)] >= som)
                        {
                            decimal foiz = som * 10/100; //10foizi
                            decimal hisob = som + foiz; //1oylik
                            decimal hammasi = hisob * oy;
                            xaridorUchun.balanslar[xaridorUchun.hisobRaqamlar.IndexOf(hisobRaqam)] -= som;
                            xaridorUchun.depozit[xaridorUchun.hisobRaqamlar.IndexOf(hisobRaqam)] = hammasi;
                            System.Console.WriteLine("Sizning hisobingizdan "+som+"so'm yechib olindiz va "+oy+"oyga Depozitga qo'yildi \n"+oy+"oydan keyin sizga "+hammasi+"so'm pul tushadi");
                        }
                        else
                        {
                            System.Console.WriteLine("Balansingizda mablag' yetarli emas");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("faqat 1oydan 1yilgacha");
                    }
                }
                else
                {
                    System.Console.WriteLine("Bunday hisob raqam topilmadi");
                }
            }
            else
            {
                System.Console.WriteLine("Bunday ism topilmadi");
            }
        }

    }
}