
namespace oopbank.Classes
{
    public class Bank
    {
        public List<string> hisobRaqamlar { get; set; } = new List<string>();
        public List<string> ismlar { get; set; } = new List<string>();
        public List<decimal> balanslar { get; set; } = new List<decimal>();
        public List<decimal> depozit {get; set;} = new List<decimal>();

        public void HisobOchish(string ism, string hisobRaqam)
        {
            int qoshildi = 0;
            if(!string.IsNullOrEmpty(ism))
            {
                int son = 0;
                for (int i = 0; i < ism.Length; i++) //ismda raqam yo'qligini tekshiradi;
                {
                    if((int)ism[i]-48 >=0 && (int)ism[i]-48 <=9)
                    {
                        son += 1; 
                    }
                }
                if(son == 0) //ismda bitta raqam ketib qolsa ham qabul qilmaydi
                {                       
                    qoshildi += 1;
                }
                else
                {
                    System.Console.WriteLine("ism noto'g'ri kiritilgan");
                }
                
            }

            int qiymat = 0;
            for (int i = 0; i < hisobRaqam.Length; i++)
            {
                if((int)hisobRaqam[i]-48 >=0 && (int)hisobRaqam[i]-48 <=9) 
                {
                    qiymat += 1;
                }
            }
            if(qiymat == 16 && hisobRaqam.Length == 19) //hisob raqamda string ketib qolsa ham hisobga olmaydi
            {
                if(hisobRaqam[4] == ' ' && hisobRaqam[9] == ' ' && hisobRaqam[14] == ' ')
                {
                    qoshildi += 1;
                }                
            }
            else
            {
                System.Console.WriteLine("hisob raqami noto'g'ri kiritilgan");
            }

            if(qoshildi == 2)
            {
                ism = ism.ToUpper();
                ismlar.Add(ism);
                hisobRaqamlar.Add(hisobRaqam);
                balanslar.Add(0);
                System.Console.WriteLine("muvoffaqiyatli qo'shildi");
            }
        }

        public void HisobYopish(string ism, string hisobRaqam)
        {
            ism = ism.ToUpper();
            if(ismlar.Contains(ism))
            {
                if(hisobRaqamlar.Contains(hisobRaqam))
                {
                    int i = hisobRaqamlar.IndexOf(hisobRaqam);
                    ismlar.Remove(ismlar[i]);
                    hisobRaqamlar.Remove(hisobRaqamlar[i]);
                    balanslar.Remove(balanslar[i]);

                    System.Console.WriteLine("muvoffaqiyatli o'chirildi");
                }
            }
            
        }

        public void PulOtkazish(string qabulQiluvchiRaqam, decimal som)
        {
            if(hisobRaqamlar.Contains(qabulQiluvchiRaqam))
            {
                int ind = hisobRaqamlar.IndexOf(qabulQiluvchiRaqam);
                balanslar[ind] = balanslar[ind] + som;
                System.Console.WriteLine("balans "+som+"so'mga to'ldirildi");
            }
            else
            {
                System.Console.WriteLine("Bunday karta mavjud emas");
            }
        }
        
        public void BankMijozlarSoni()
        {
            int countt = hisobRaqamlar.Count();
            System.Console.WriteLine("Bank mijozlari soni "+countt+"ta");
        }

        
    }
}

