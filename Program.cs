using oopbank.Classes;

namespace oopbank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Xaridor xaridor = new Xaridor(bank);
            string adUs;
            bool t = true;
            while(t)
            {
                do
                {
                    System.Console.WriteLine("\nadmin/user bo'limi mavjud \nadmin - bank xodimi\nuser - mijoz");
                    System.Console.Write("admin/user/0.exit bittasini kiriting: ");
                    adUs = Console.ReadLine();
                    if(adUs == "admin" || adUs == "user" || adUs == "0")
                    {
                        break;
                    }
                } while (true);
                while(true)
                {
                    if(adUs == "admin") // admin bo'limi
                    {
                        System.Console.WriteLine("0.exit\n1.Hisob ochish\n2.Hisob yopish\n3.Pul o'tkazish\n4.Mijozlar soni");
                        System.Console.Write("Tanlang: ");
                        string tanlang = Console.ReadLine();
                        if(tanlang == "1")// Hisob ochish
                        {
                            System.Console.WriteLine("Hisob ochish bo'limiga xush kelibsiz!");
                            System.Console.Write("ism: ");
                            string ism = Console.ReadLine();
                            System.Console.WriteLine("na'muna(1234 1234 1234 1234):");
                            System.Console.Write("hisob raqam: ");
                            string hisobRaqam = Console.ReadLine();
                            bank.HisobOchish(ism, hisobRaqam);
                        }
                        else if(tanlang == "2") //Hisob yopish
                        {
                            System.Console.WriteLine("Hisob yopish bo'limiga xush kelibsiz!");
                            System.Console.Write("ism: ");
                            string ism = Console.ReadLine();
                            System.Console.WriteLine("na'muna(1234 1234 1234 1234):");
                            System.Console.Write("hisob raqam: ");
                            string hisobRaqam = Console.ReadLine();
                            bank.HisobYopish(ism, hisobRaqam);
                        }
                        else if(tanlang == "3") //Pul o'tkazish
                        {
                            System.Console.WriteLine("Pul o'tkazish bo'limiga xush kelibsiz!");
                            System.Console.WriteLine("na'muna(1234 1234 1234 1234):");
                            System.Console.Write("qabul qilivchi raqam: ");
                            string qabul = Console.ReadLine();
                            System.Console.Write("so'm: ");
                            decimal som = Convert.ToDecimal(Console.ReadLine());
                            bank.PulOtkazish(qabul, som);
                        }
                        else if(tanlang == "4")
                        {
                            bank.BankMijozlarSoni();
                        }
                        else if(tanlang == "0")
                        {
                            break;
                        }
                    }
                    else if(adUs == "user") //mijoz bo'limi
                    {
                        System.Console.WriteLine("0.exit\n1.Balans\n2.Pul o'tkazish\n3.Depozit qo'yish");
                        System.Console.Write("Tanlang: ");
                        string tanlang = Console.ReadLine();
                        if(tanlang == "1")
                        {
                            System.Console.WriteLine("Balansni ko'rish bo'limiga xush kelibsiz!");
                            System.Console.Write("ism: ");
                            string ism = Console.ReadLine();
                            System.Console.Write("hisob raqam: ");
                            string hisobRaqam = Console.ReadLine();
                            xaridor.Balans(ism,hisobRaqam);
                        }
                        else if(tanlang == "2")
                        {
                            System.Console.WriteLine("Pul o'tkazish bo'limiga xush kelibsiz!");
                            System.Console.Write("pul o'tkazuvchi raqam: ");
                            string otkaz = Console.ReadLine();
                            System.Console.Write("qabul qilivchi raqam: ");
                            string qabul = Console.ReadLine();
                            System.Console.Write("so'm: ");
                            decimal som = Convert.ToDecimal(Console.ReadLine());
                            xaridor.PulOtkazish(otkaz, qabul, som);
                        }
                        else if(tanlang == "3")
                        {
                            System.Console.WriteLine("Depozit qo'yish bo'limiga xush kelibsiz\nDepozit oyiga 10%lik");
                            System.Console.Write("ism: ");
                            string ism = Console.ReadLine();
                            System.Console.Write("hisob raqam: ");
                            string hisobRaqam = Console.ReadLine();
                            System.Console.Write("so'm: ");
                            decimal som = Convert.ToDecimal(Console.ReadLine());
                            System.Console.Write("oy: ");
                            int oy = Convert.ToInt32(Console.ReadLine());
                            xaridor.Depozit(ism,hisobRaqam,oy,som);
                        }
                        else if(tanlang == "0")
                        {
                            break;
                        }
                    }
                    else if(adUs == "0")
                    {
                        t = false;
                        break;                        
                    }
                }
            }
            


        }
    }
}
