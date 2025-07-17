using System;
using System.Diagnostics.Metrics;

namespace ByteETA
{
    public class AppC
    {
        //Gerekli Değişkenler

        //İnternet
        (string? Unit, double Value, double BytesPerSecond) netSpeed;

        //Dosya
        (string? Unit, double Value) fileSize;

        //Süreler
        double TimeInSeconds;
        int SecondToHour;
        int SecondsRemainingAfterHourCalculation;
        int SecondToMinute;
        int RemainSeconds;

        //Ana Başlangıç
        public void Run()
        {
            GetSpeedData();
            GetFileData();
            TimeCalculation();
            Console.ReadLine();
        }

        //İnternet Verileri
        private void GetSpeedData()
        {
            //Hız Birimi
            while(true)
            {
                Console.Write("Enter your internet speed unit (Kbps/Mbps/Gbps) : ");
                netSpeed.Unit = Console.ReadLine()?.ToLowerInvariant().Trim();

                if(netSpeed.Unit is "kbps" or "mbps" or "gbps")
                {
                    break;
                }

                Console.WriteLine("Invalid entry! Please try again.");
            }

            //Hız Değeri
            while (true)
            {
                Console.Write("Enter your internet speed : ");
                try
                {
                    netSpeed.Value = double.Parse(Console.ReadLine()!);

                    if (netSpeed.Value > 0) { break;}
                    else {Console.WriteLine("Please enter a positive value.");}
                }
                catch
                {
                    Console.WriteLine("Please enter a valid value.");
                }
            }

            //Hızı Byte Çevirme
            switch(netSpeed.Unit)
            {
                case "kbps":
                    netSpeed.BytesPerSecond = ((netSpeed.Value * 1024) / 8);
                    break;
                case "mbps":
                    netSpeed.BytesPerSecond = ((netSpeed.Value * 1024 * 1024) / 8);
                    break;
                case "gbps":
                    netSpeed.BytesPerSecond = ((netSpeed.Value * 1024 * 1024 * 1024) / 8);
                    break;
                default:
                    Console.WriteLine("Error");
                    return;
            }
        }

        //Dosya Verileri
        private void GetFileData()
        {
            //Boyut Birimi
            while(true)
            {
                Console.Write("Enter your file size unit (KB/MB/GB) : ");
                fileSize.Unit = Console.ReadLine()?.ToLower().Trim();

                if(fileSize.Unit is "kb" or "mb" or "gb")
                {
                    break;
                }

                Console.WriteLine("Invalid entry! Please try again.");
            }

            //Boyut
            while (true)
            {
                Console.Write("Enter your file size : ");
                try
                {
                    fileSize.Value = double.Parse(Console.ReadLine()!);

                    if (fileSize.Value > 0){break;}
                    else{ Console.WriteLine("Please enter a positive value.");}
                }
                catch
                {
                    Console.WriteLine("Please enter a valid value.");
                }
            }

            //Dosya Boyutunu Byte Çevirme
            switch (fileSize.Unit)
            {
                case "kb":
                    fileSize.Value = (fileSize.Value * 1024);
                    break;
                case "mb":
                    fileSize.Value = (fileSize.Value * 1024 * 1024);
                    break;
                case "gb":
                    fileSize.Value = (fileSize.Value * 1024 * 1024 * 1024);
                    break;
                default:
                    Console.WriteLine("Error");
                    return;
            }
        }

        //Süre Hesaplama
        private void TimeCalculation()
        {
            //Saniye Cinsinden Süre Hesabı
            TimeInSeconds = fileSize.Value / netSpeed.BytesPerSecond;

            //Saniyeyi Formatlama
            SecondToHour = (int)(TimeInSeconds / 3600);//Saat
            SecondsRemainingAfterHourCalculation = (int)(TimeInSeconds % 3600);//Saat hesabı sonra kalan saniye
            SecondToMinute = (int)(SecondsRemainingAfterHourCalculation / 60);//Dakika
            RemainSeconds = (int)(SecondsRemainingAfterHourCalculation % 60);//Kalan Saniye

            Console.WriteLine(SecondToHour + " Hours " + SecondToMinute + " Minutes " + RemainSeconds + " Seconds");
        }

        //Nesne Oluşturup Konsolu Çalıştırma
        static void Main(string[] args)
        {
            AppC app = new AppC();
            app.Run();

        }
    }
}