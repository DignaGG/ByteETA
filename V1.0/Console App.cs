using System;
using System.Diagnostics.Metrics;

namespace ByteRace
{
    public class AppC
    {
        //Gerekli Değişkenler

        //Tip Girişleri ve Yazıları
        string? NetSpeedTypeInput;
        string NetSpeedTypeInputLabel = "Enter your internet speed unit (Kbps/Mbps/Gbps) : ";
        string? FileSizeTypeInput;
        string FileSizeTypeInputLabel = "Enter your file size unit (KB/MB/GB) : ";
        string NetSpeedInputLabel = "Enter your internet speed : ";
        string FileSizeInputLabel = "Enter your file size : ";

        //Boyutlar
        int NetSpeedInput;
        long FileSizeInput;
        double NetSpeedBytesPerSecond;
        double FileSizeToByte;

        //Süreler
        double TimeInSeconds;
        int SecondToHour;
        int SecondsRemainingAfterHourCalculation;
        int SecondToMinute;
        int RemainSeconds;

        //Ana Başlangıç
        public void Run()
        {
            NetSpeedTypeMethod();
            NetSpeedMethod();
            FileSizeTypeMethod();
            FileSizeMethod();
            NetSpeedToBytes();
            FileSizeToBytes();
            CalculatingTimeInSeconds();
            FormattingTimeInSeconds();
            Console.ReadLine();
        }

        //İnternet Hız Tipi
        private void NetSpeedTypeMethod()
        {
            while (true)
            {
                Console.Write(NetSpeedTypeInputLabel);
                NetSpeedTypeInput = Console.ReadLine()!.ToLower().Trim();

                switch (NetSpeedTypeInput)
                {
                    case "kbps":
                        return;

                    case "mbps":
                        return;

                    case "gbps":
                        return;
                    default:
                        Console.WriteLine("Invalid entry! Please try again.");
                        break;
                }
            }
        }


        //İnternet Hızı Alma
        private void NetSpeedMethod()
        {
            try
            {
                Console.Write(NetSpeedInputLabel);
                NetSpeedInput = int.Parse(Console.ReadLine()!);
            }
            catch
            {
                Console.WriteLine("Invalid entry!");
                NetSpeedMethod();
            }
        }

        //Dosya Boyut Tipi Alma
        private void FileSizeTypeMethod()
        {
            Console.Write(FileSizeTypeInputLabel);
            FileSizeTypeInput = Console.ReadLine()!.ToLower().Trim();

            switch (FileSizeTypeInput)
            {
                case "kb":
                    break;
                case "mb":
                    break;
                case "gb":
                    break;
                default:
                    Console.WriteLine("Invalid entry!");
                    FileSizeTypeMethod();
                    return;
            }
        }

        //Dosya Boyutu Alma
        private void FileSizeMethod()
        {
            try
            {
                Console.Write(FileSizeInputLabel);
                FileSizeInput = long.Parse(Console.ReadLine()!);
            }
            catch
            {
                Console.WriteLine("Invalid entry! Please enter a number.");
                FileSizeMethod();
            }
        }

        //İnternet Hızını Byte Çevirme
        private void NetSpeedToBytes()
        {
            switch(NetSpeedTypeInput)
            {
                case "kbps":
                    NetSpeedBytesPerSecond = (double)NetSpeedInput / 8;
                    NetSpeedBytesPerSecond = NetSpeedBytesPerSecond * 1024;
                    break;
                case "mbps":
                    NetSpeedBytesPerSecond = (double)NetSpeedInput / 8;
                    NetSpeedBytesPerSecond = NetSpeedBytesPerSecond * 1024 * 1024;
                    break;
                case "gbps":
                    NetSpeedBytesPerSecond = (double)NetSpeedInput / 8;
                    NetSpeedBytesPerSecond = NetSpeedBytesPerSecond * 1024 * 1024 * 1024;
                    break;
                default:
                    Console.WriteLine("Error");
                    return;
            }
        }

        //Dosya Boyutunu Byte Çevirme
        private void FileSizeToBytes()
        {
            switch(FileSizeTypeInput)
            {
                case "kb":
                    FileSizeToByte = FileSizeInput * 1024;
                    break;
                case "mb":
                    FileSizeToByte = FileSizeInput * 1024 * 1024;
                    break;
                case "gb":
                    FileSizeToByte = FileSizeInput * 1024 * 1024 * 1024;
                    break;
                default:
                    Console.WriteLine("Error");
                    return;
            }
        }

        //Saniye Cinsinden Süre Hesabı
        private void CalculatingTimeInSeconds()
        {
            TimeInSeconds = FileSizeToByte / NetSpeedBytesPerSecond;
        }

        //Saniyeyi Formatlama
        private void FormattingTimeInSeconds()
        {
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
