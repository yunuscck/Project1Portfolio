using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1Portfolio.Extension
{
    public static class StringExtensions
    {
        public static string ConvertTurkishCharacters(this string input)
        {
            return input.Replace("ş", "s")
                        .Replace("Ş", "S")
                        .Replace("ı", "i")
                        .Replace("İ", "I")
                        .Replace("ğ", "g")
                        .Replace("Ğ", "G")
                        .Replace("ç", "c")
                        .Replace("Ç", "C")
                        .Replace("ö", "o")
                        .Replace("Ö", "O")
                        .Replace("ü", "u")
                        .Replace("Ü", "U")
                        .Replace(" ", "-");
        }
    }
}