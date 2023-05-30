using System;

namespace DateTimeM
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(DateTime.Now);// günün tarihini
           Console.WriteLine(DateTime.Now.Date); // gün.ay.yıl karşılığ
           Console.WriteLine(DateTime.Now.Day);
           Console.WriteLine(DateTime.Now.Month);
           Console.WriteLine(DateTime.Now.Year);
           Console.WriteLine(DateTime.Now.Hour);
           Console.WriteLine(DateTime.Now.Minute);
           Console.WriteLine(DateTime.Now.Second);

           Console.WriteLine(DateTime.Now.DayOfWeek);
           Console.WriteLine(DateTime.Now.DayOfYear);

           Console.WriteLine(DateTime.Now.ToLongDateString());
           Console.WriteLine(DateTime.Now.ToShortDateString());
           Console.WriteLine(DateTime.Now.ToLongTimeString());
           Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));


            // DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); // int karşılığunı getirir
            Console.WriteLine(DateTime.Now.ToString("ddd")); // günün ilk 3 harfi
            Console.WriteLine(DateTime.Now.ToString("dddd"));// günün direkt ismini direkt getirir

            Console.WriteLine(DateTime.Now.ToString("mm")); // int karşılığı
            Console.WriteLine(DateTime.Now.ToString("mmm"));// ayın ilk 3 harfi
            Console.WriteLine(DateTime.Now.ToString("mmmm")); // ayın direkt ismini getirir
            
            Console.WriteLine(DateTime.Now.ToString("yy")); // yılın son 2 sayısını verir
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // yılı direkt yazdırır

             Console.WriteLine("********Math Kütüphanesi********");
            //Math Kütüphanesi
            Console.WriteLine(Math.Asin(-25)); //25
            Console.WriteLine(Math.Sin(10)); //sinüsünü alır
            Console.WriteLine(Math.Cos(10)); //Cosiniüsü alır
            Console.WriteLine(Math.Tan(10)); //Tanjantını alır

            Console.WriteLine(Math.Ceiling(22.3)); // 22.3 den büyük en büyük tam sayıya yuvarlar
            Console.WriteLine(Math.Round(22.3)); // en yakın tam sayıya yuvarlar
             Console.WriteLine(Math.Round(22.7));
            Console.WriteLine(Math.Floor(22.7));// 22.7 ye yakın en düşük tam sayıya yuvarlar

             Console.WriteLine(Math.Max(2,6));
              Console.WriteLine(Math.Min(2,6));

             Console.WriteLine(Math.Pow(3,4)); //3^4 ü verir 
             Console.WriteLine(Math.Sqrt(9)); // karekök alır 

             Console.WriteLine(Math.Log(9));//9 un e tabanındaki logaritmik karşılığını geitirir
             Console.WriteLine(Math.Exp(3));//e üzeri 3ü verir
             Console.WriteLine(Math.Log10(10));// 10 sayısının logaritma 10 tabanındaki karşlığı
             
             




            






            




           




        }
    }
}