using System.Linq;
using System.Runtime.CompilerServices; 

namespace SchoolManagementSystem.BLL.Validation
{
    public static class ValidationExtensions
    {
        
        public static bool IsRequired(this string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        
        public static bool IsValidNameFormat(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;
            return text.All(c => char.IsLetter(c) || c == ' ');
        }

        
        public static bool IsDigitsOnly(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;
            return text.All(char.IsDigit);
        }

        
        public static bool IsNumeric(this string text)
        {
            return double.TryParse(text, out _);
        }

       
        public static bool IsSelected(this string selectedValue)
        {
            return !string.IsNullOrWhiteSpace(selectedValue);
        }

        
        public static bool IsValidGenderSelected(bool maleChecked, bool femaleChecked)
        {
            return maleChecked || femaleChecked;
        }

        public static bool IsValidPhone(this string text, int requiredLength = 10)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;
            string cleanedText = text.Replace(" ", ""); 
                                                        
            return cleanedText.Length == requiredLength && cleanedText.All(char.IsDigit);
        }
        

        
        public static bool IsValidNumericPassword(this string text, int minLength = 8)
        {
            
            if (string.IsNullOrWhiteSpace(text)) return false;

            
            if (text.Length < minLength) return false;

            
            return text.All(char.IsDigit);
        }

        public static bool IsIdSelected(this string id)
        {
            
            return !string.IsNullOrWhiteSpace(id) && id != "0";
        }
    }
}