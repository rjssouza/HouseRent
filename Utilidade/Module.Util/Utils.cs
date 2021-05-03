using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Module.Util
{
    public class Utils
    {
        public static bool IsFakeMail(string mail)
        {
            if (mail is null)
                return false;

            return !IsValidEmail(mail);
        }

        public static bool IsValidEmail(string mail)
        {
            if (string.IsNullOrWhiteSpace(mail))
                return false;

            try
            {
                // Normalize the domain
                mail = Regex.Replace(mail, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                static string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            return ValidateMailUsingRegex(mail);
        }

        private static bool ValidateMailUsingRegex(string mail)
        {
            try
            {
                return Regex.IsMatch(mail,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}