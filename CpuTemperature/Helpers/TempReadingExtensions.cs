﻿using CpuTemperature.Models;
using System.Threading.Tasks;

namespace CpuTemperature.Helpers
{
    public static class TempReadingExtensions
    {
        public async static Task<string> ToDisplayText(this TempReading reading)
        {
            return reading == null ? "NULL" : await JsonHelper.Serialize(reading);
        }
    }
}