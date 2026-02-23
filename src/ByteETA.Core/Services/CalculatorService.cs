using ByteETA.Core.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ByteETA.Core.Services
{
    public class CalculatorService
    {
        public TimeSpan CalculateDownloadTime(InternetInfo internet, ByteETA.Core.Models.FileInfo file)
        {
            double totalBytes = ConvertToBytes(file);
            double bytePerSecond = ConvertToBytePerSecond(internet);

            if (bytePerSecond <= 0) return TimeSpan.Zero;

            //double seconds = totalBytes / bytePerSecond;
            TimeSpan downloadTime = TimeSpan.FromSeconds(totalBytes / bytePerSecond);
            return downloadTime;
        }

        private double ConvertToBytes(ByteETA.Core.Models.FileInfo file)
        {
            double multiplier = Math.Pow(1024, (int)file.Unit + 1); //Veri Depolama 1024 tabanını kullanır.
            return file.Value * multiplier;
        }

        private double ConvertToBytePerSecond(InternetInfo internet)
        { 
            double multiplier = Math.Pow(1000, (int)internet.Unit + 1); //Ağ Hızı 1000 tabanını kullanır.
            return (internet.Value * multiplier) /8;
        }

        public string GetReadableTime(TimeSpan ts)
        {
            if (ts == TimeSpan.Zero) return "0 seconds";

            var parts = new List<string>();

            if (ts.Days > 0) parts.Add($"{ts.Days} Day\n");
            if (ts.Hours > 0) parts.Add($"{ts.Hours} Hour\n");
            if (ts.Minutes > 0) parts.Add($"{ts.Minutes} Minutes\n");
            if (ts.Seconds > 0) parts.Add($"{ts.Seconds} Seconds");

            return string.Join(" ", parts);
        }
    }
}