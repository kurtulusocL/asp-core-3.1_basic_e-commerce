using System;
using System.Collections.Generic;
using System.Text;

namespace ShowProduct.Core.CrossCuttingConcert.Toolbox
{
    public static class ReadMore
    {
        public static string SafeSubstring(string text, int uzunluk)
        {
            if (text.Length > uzunluk)
            {
                return text.Substring(0, uzunluk);
            }
            return text;
        }
    }
}
