﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Başkenti Giriniz. ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Giriniz.");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");
            //}
            //int number;
            //Console.WriteLine("Sayıyı Giriniz");
            //number=int.Parse(Console.ReadLine());
            //if(number==6)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata";

            //Console.Write("1.Sınav: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("2.Sınav: ");
            //exam2=int.Parse(Console.ReadLine());
            //Console.Write("3.Sınav: ");
            //exam3=int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav Ortalamanız: "+average);
            //if(average>=0 & average<= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if(average>50 & average<=70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if(average>70 & average<=84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if(average>84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Giriniz:");
            //city = Console.ReadLine();
            //if (city == "bursa" | city == "ankara" | city == "istanbul" | city == "bolu")
            //{
            //    Console.WriteLine("Şehir Mevcuttur.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değildir.");
            //}

            //Console.Write("Lütfen Kullanıcı Adı Giriniz: ");
            //string username=Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı adı kabul edilemez.");
            //}
            //else 
            //{ 
            //    Console.WriteLine("Hoş geldiniz.");
            //}
            #endregion

            #region Mod İşlemleri
            //int number;
            //number = 26;

            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("Lütfen 1.Sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sayıyı giriniz: ");
            //int number2=int.Parse(Console.ReadLine());

            //int result=number1 % number2;

            //Console.WriteLine("1.Sayının 2. Sayıya bölümünden kalan: "+result);

            //Console.Write("Lütfen Sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir.");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir.");
            //}
            #endregion

            #region Char Değişkenler İle Karar Yapıları
            //char team;
            //Console.Write("Lütfen Takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team =='g'|team=='G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menüyü seçimi: ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- Ana Yemekler -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızatma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("----------- Ana Yemekler -----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- Çorbalar -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimekj");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("----------- Çorbalar -----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- Pizzalar -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margaritha");
            //    Console.WriteLine("2-Tavuklu");
            //    Console.WriteLine("3-4 Peynirli");
            //    Console.WriteLine("4-Akdeniz");
            //    Console.WriteLine("5-Şarküteri");
            //    Console.WriteLine("----------- Pizzalar -----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- İçecekler -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("----------- İçecekler -----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- Tatlılar -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Supangle");
            //    Console.WriteLine("----------- Tatlılar -----------");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch, Case Yapıları

            //Console.WriteLine("Lütfen Ay Girişi Yapınız.");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{ 
            // case 1:Console.WriteLine("Ocak");break;
            // case 2:Console.WriteLine("Şubat");break;
            // case 3:Console.WriteLine("Mart");break;
            // case 4:Console.WriteLine("Nisan");break;
            // case 5:Console.WriteLine("Mayıs");break;
            // case 6:Console.WriteLine("Hazira");break;
            // case 7:Console.WriteLine("Temmuz");break;
            // case 8:Console.WriteLine("Ağustos");break;
            // case 9:Console.WriteLine("Eylül");break;
            // case 10:Console.WriteLine("Ekim");break;
            // case 11:Console.WriteLine("Kasım");break;
            // case 12:Console.WriteLine("Aralık");break;
            // default:Console.WriteLine("Hatalı veri girişi");break;
            //}

            #endregion

            #region Switch, Case Hesap Makinası

            int number1, number2, result;
            char symbol;

            Console.Write("1.Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    {
                        result = number1 + number2;
                        Console.WriteLine("Toplam: " + result);
                        break;
                    }
                case '-':
                    {
                        result = number1 - number2;
                        Console.WriteLine("Fark: " + result);
                        break;
                    }
                case '*':
                    {
                        result = number1 * number2;
                        Console.WriteLine("Çarpım: " + result);
                        break;
                    }
                case '/':
                    {
                        result = number1 / number2;
                        Console.WriteLine("Bölüm: " + result);
                        break;
                    }
            }
            #endregion

            Console.Read();

        }
    }
}
