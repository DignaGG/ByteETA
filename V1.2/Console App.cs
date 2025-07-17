using System;

namespace ByteETA
{
    public class AppC
    {
        //Gerekli Değişkenler
        (string? Unit, double Value, double BytesPerSecond) netSpeed;//İnternet
        (string? Unit, double Value) fileSize;//Dosya
        string? userChoice;//Tekrar Onayı


        //Ana Başlangıç
        public void Run()
        {
            GetSpeedData();
            GetFileData();
            TimeCalculation();
            AskForRetry();
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
            TimeSpan downloadTime = TimeSpan.FromSeconds(fileSize.Value / netSpeed.BytesPerSecond);
            Console.WriteLine($"{downloadTime.Hours} Hours {downloadTime.Minutes} Minutes {downloadTime.Seconds} Seconds");
        }

        //Tekrar işlem isteği sorgulama
        private void AskForRetry()
        {
            while (true)
            {
                Console.Write("Would you like to perform another calculation? (y, yes / n, no): ");
                userChoice = Console.ReadLine()?.ToLower().Trim();

                if (userChoice is "y" or "yes")
                {
                    Run();
                    break;
                }
                else if (userChoice is "n" or "no")
                {
                    Console.Write("Press any key to continue...");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
            }
        }

        //Nesne Oluşturup Konsolu Çalıştırma
        static void Main(string[] args)
        {
            AppC app = new AppC();
            app.Run();
        }
    }
}