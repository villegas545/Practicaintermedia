using System.Text.RegularExpressions;
using System;
using System.Linq;
namespace RegexProgram
{
    public static class ExtentionMethod
    {
        //regex method validar cadena, 1 mayuscula, seguido de 3 minusculas y 4 digitos
        public static bool IsValid(this string cadena)
        {
            return Regex.IsMatch(cadena, @"^[A-Z]{1}[a-z]{3}[0-9]{4}$");
            
        }
        
    }
}