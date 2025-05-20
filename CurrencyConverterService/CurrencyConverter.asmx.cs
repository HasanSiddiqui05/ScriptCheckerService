using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;

namespace CurrencyConverterService
{
    /// <summary>
    /// Summary description for CurrencyConverter
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class CurrencyConverter : System.Web.Services.WebService
    {
        private static readonly List<string> MaliciousPatterns = new List<string>
        {
            @"SELECT\s+\*",  // SQL SELECT *
            @"DROP\s+TABLE", // SQL DROP TABLE
            @"<script>",     // XSS script tag
            @"rm\s+-rf"      // Shell command to remove files recursively
        };

        [WebMethod]
        public string CheckForMaliciousPatterns(string inputScript)
        {
            if (string.IsNullOrWhiteSpace(inputScript))
                return "Error: Input script cannot be empty.";

            foreach (var pattern in MaliciousPatterns)
            {
                if (Regex.IsMatch(inputScript, pattern, RegexOptions.IgnoreCase))
                {
                    return "Malicious pattern detected.";
                }
            }

            return "The script is safe.";
        }
    }
}
