using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse
{
    public static class Extensions
    {
        // Форматирование в string
        public static string ToFormatedString(this IpAdress ipadress)
        {
            return string.Format("IP: {0}\nRegion: {1}\nCountry: {2}\nLocation: {3}\nOrg: {4}\nTimezone: {5}\nCity: {6}\n", ipadress.ip, ipadress.city, ipadress.region, ipadress.country, ipadress.loc, ipadress.org, ipadress.timezone);
        }
    }
}
