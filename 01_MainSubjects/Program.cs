﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma komutları
            //  //Console.WriteLine("Merhaba Dünya");
            //  //Console.Write("Selam");

            //  Console.WriteLine("*****Yemek Kategorileri****");
            //  Console.WriteLine();
            //  Console.WriteLine("1-Çorbalar");
            //  Console.WriteLine("2-Ana Yemekler");
            //  Console.WriteLine("3-Soğuk Başlangıçlar");
            //  Console.WriteLine("4-Salatalar");
            //  Console.WriteLine("5-Tatlılar");
            //  Console.WriteLine("6-İçecekler");
            //  Console.WriteLine();
            //  Console.WriteLine("*****Yemek Kategorileri****");

            #endregion

            #region String Değişkenler
            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Furkan";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,district,city;

            //customerName = "Furkan";
            //customerSurname = "İnce";
            //customerPhone = "111111";
            //customerEmail="f@hotmail.com";
            //district = "Nilüfer";
            //city = "Bursa";

            //Console.WriteLine("Rezervasyon Kartı");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName +" "+ customerSurname);
            //Console.WriteLine("İletişim: "+customerPhone);
            //Console.WriteLine("E-mail: "+ customerEmail);
            //Console.WriteLine("Adres: " + district + " " + city);
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Rezervasyon Kartı");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine("Müşteri: " + customerName +" "+ customerSurname);
            //Console.WriteLine("İletişim: "+customerPhone);
            //Console.WriteLine("E-mail: "+ customerEmail);
            //Console.WriteLine("Adres: " + district + " " + city);
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Rezervasyon Kartı");


            //Console.WriteLine(customerName);

            #endregion

            #region Int Değişkenler
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 50;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("******Restoran Menü Fiyat*******");
            Console.WriteLine();
            Console.WriteLine("------Hamburger:" + hamburgerPrice + "TL");
            Console.WriteLine("------Kola:" + cokePrice + "TL");
            Console.WriteLine("------Pizza:" + pizzaPrice + "TL");
            Console.WriteLine("------Kızartma:" + friesPrice + "TL");
            Console.WriteLine("------Limonata:" + lemonadePrice + "TL");
            Console.WriteLine("------Su:" + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("******Restoran Menü Fiyat*******");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice= lemonadePrice * lemonadePrice;
            totalFriesPrice= friesCount * friesPrice;
            totalPizzaPrice=pizzaCount * pizzaPrice;
           

            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice+totalWaterPrice+totalLemonadePrice+totalFriesPrice+totalPizzaPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice +"TL");

            #endregion
            Console.Read();

        }
    }
}