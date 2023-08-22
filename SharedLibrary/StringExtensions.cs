using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace SharedLibrary
{
    public static class StringExtensions
    {
        public static bool IsValidXmlTag(this string input)
        {
            return Regex.IsMatch(input,@"^<([a-z]+)([^<]+)*(?:>(.*)<\/\1>|s+\/>)$");
        }
        public static bool IsValidPassword(this string input)
        {
            return Regex.IsMatch(input,"^[a-zA-Z0-9_-]{8,}$");
        }

        public static bool isValidHex(this string input)
        {
            //3개 혹은 6개의 유효한 16진수
            return Regex.IsMatch(input,"^@?([a-fA-F0-9]{3}|[a-fA-f0-9]{6})$");
        }
    }
}
