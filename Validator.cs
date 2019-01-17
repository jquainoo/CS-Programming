using System;
using System.Linq;

namespace DayTwoExercises.StaticMCV
{
    public static class Validator
    {
     
        static Validator()
        {

        }

        public static bool HasCapitalLetter(string value)
        {
            return value.Any(char.IsUpper);
        }

        public static bool HasDigit(string value)
        {
            return value.Any(char.IsDigit);
        }

        public static bool HasLength(string value, int minimumLength)
        {
            return value.Length >= minimumLength;
        }

        public static bool HasLength(string value, int minimumLength, int maximunLength)
        {
            return (value.Length >= minimumLength && value.Length <= maximunLength);
        }

        public static bool HasSmallLetter(string value)
        {
            return value.Any(char.IsLower);
        }

        public static bool HasSpecialCharacter(string value)
        {
            return value.Any(character => !char.IsLetterOrDigit(character));
        }

        public static bool IsAlphabet(string value)
        {
            return (value.Length == 1 && !value.All(char.IsWhiteSpace));
        }

        public static bool IsAlphaNumeric(string value)
        {
            return value.Any(char.IsLetterOrDigit);
        }


        public static bool IsEmailId(string value)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(value);
                return addr.Address == value;
            }
            catch
            {
                return false;
            }
        }


        public static bool IsInteger(string value)
        {
            return (!string.IsNullOrEmpty(value) && value.All(char.IsDigit));
        }


        public static bool isName(string value)
        {
            if(value.Length >= 5 && value.Length <= 20)
                return (!string.IsNullOrWhiteSpace(value));
            return false;
        }

      
        public static bool IsNullOrEmpty(string value)
        {
            return (value == null || value == string.Empty);
        }


        public static bool ValidateAge(DateTime dateOfBirth, int minimumAgeRequired)
        {
            int age = 0;
            age = (int.Parse(DateTime.Now.ToString("yyyyMMdd")) - int.Parse(dateOfBirth.ToString("yyyyMMdd"))) / 10000;
            return (age >= minimumAgeRequired);

        }


        public static bool ValidateAge(DateTime dateOfBirth, int minimumAgeRequired, int maximumAgeRequired)
        {
            int age = 0;
            age = (int.Parse(DateTime.Now.ToString("yyyyMMdd")) - int.Parse(dateOfBirth.ToString("yyyyMMdd"))) / 10000;
            return (age >= minimumAgeRequired && age <= maximumAgeRequired);

        }

    }
}
