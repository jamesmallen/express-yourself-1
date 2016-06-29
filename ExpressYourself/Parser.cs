using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpressYourself
{
    public class Parser
    {
        /// <summary>
        /// Looks for a title in a Media file string.
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>the title string if it exists</returns>
        public static string GetTitle(string str)
        {
            // TODO
            var re = new Regex(@"Title\: (.*),+");
            var match = re.Match(str);
            if (!match.Success)
            {
                return "Title Not Found";
            }
            else
            {
                return match.Groups[1].Value;
            }
        }

        public static string GetType(string str)
        {
            var re = new Regex(@"Type: (Book|DVD|Magazine),", RegexOptions.IgnoreCase);
            var match = re.Match(str);

            if (!match.Success)
            {
                return "Type Not Found";
            }
            else
            {
                return match.Groups[1].Value;
            }
        }

        public static string GetLength(string str)
        {
            var re = new Regex(@"Length: ([\w ]+)", RegexOptions.IgnoreCase);
            var match = re.Match(str);

            if (!match.Success)
            {
                return "Length Not Found";
            }
            else
            {
                return match.Groups[1].Value;
            }
        }

        public static bool IsValidLine(string str)
        {
            var re = new Regex(@"Type: (Book|DVD|Magazine),Title\: (.*),+Length: ([\w ]+)", RegexOptions.IgnoreCase);
            var match = re.Match(str);

            return match.Success;
        }
    }
}
