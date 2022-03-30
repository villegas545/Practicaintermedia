
using System.Text.RegularExpressions;

namespace RegexProgram
{
    public static class RegexClass
    {
        public static bool IsValid(this string cadena)
        {
            return Regex.IsMatch(cadena, @"^[A-Z]{1}[a-z]{3}[0-9]{4}$");
        }
        
    }
}