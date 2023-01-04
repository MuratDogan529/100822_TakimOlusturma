using System;
using System.Linq;

namespace _100822_TakimOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Takım Oyunu
            //1.Adım:Kullanıcıya kaç isim gireceği sorulup,
            //girilen adet boyutunda dizi tanımlanacak
            int adet = 0;
            string[] isimler = new string[0];

            do
            {
                Console.Write("Kaç isim girilecek:");
                adet = Convert.ToInt32(Console.ReadLine());
                if(adet %2 == 0)//çift sayı
                {
                    isimler = new string[adet];
                    
                }
                else
                {
                    Console.WriteLine("Lütfen çift sayı giriniz:");

                }

            }
            while (adet %2 != 0);

            //2.adım:Kullanıcının belirtmiş olduğu adet kadar oyuncu ismi girmesini sağlamak
            //ve bu isimleri diziye atmak.Ancak bir isim dizide iki kez bulunmasın.

            for(int i = 0; i < isimler.Length; i++)
            {
                Console.Write("{0}. İsmi Giriniz:",i+1);
                string isim =Console.ReadLine();

                if(isimler.Contains(isim)==true)
                {
                    i--; 
                }
                else
                {
                    isimler[i] = isim;

                }

            }
            //3.Adım:2 tane takım oluşturulmalı ve oyuncular eşit sayılarda rastgele dağıtılmalı.
            //Kural1:Bir oyuncu sadece 1 takımda bulunabilir.
            //Kural2:Bir oyuncu bir takımda bir kez bulunabilir.


            string[] aTakimi = new string[isimler.Length / 2];
            string[] bTakimi = new string[isimler.Length / 2];

            Random rnd = new Random();
            //a takımı ataması
            for (int i = 0; i < isimler.Length/2; i++)
            {
                string isim = isimler[rnd.Next(0, isimler.Length)];

                if(aTakimi.Contains(isim)==true)
                {
                    i--;
                }
                else
                {
                    aTakimi[i] = isim;

                }
                 
            }
            //btakımı ataması
            for(int i = 0; i < isimler.Length/2; i++)
            {
                string isim = isimler[rnd.Next(0, isimler.Length)];

                if( bTakimi.Contains(isim)==false)
                {
                    bTakimi[i] = isim;
                }
                else
                {
                    i--;
                }
            }

            //4.adım: Kullanıcıya A takımı ve B takımı listesinin bilgisi verilmeli.

            Console.WriteLine("A Takımı:");
            foreach(string a in aTakimi)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("B Takımı:");
            foreach(string b in bTakimi)
            {
                Console.WriteLine(b);
            }
        }
    }
}
