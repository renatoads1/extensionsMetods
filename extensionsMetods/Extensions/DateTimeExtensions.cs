using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionsMetods.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ElapedTime( this DateTime thisDate) {

            TimeSpan timeSpan = DateTime.Now - thisDate;
            if (timeSpan.Days > 0)
            {
                return $"{timeSpan.Days} days ago";
            }
            else if (timeSpan.Hours > 0)
            {
                return $"{timeSpan.Hours} hours ago";
            }
            else if (timeSpan.Minutes > 0)
            {
                return $"{timeSpan.Minutes} minutes ago";
            }
            else if (timeSpan.Seconds > 0)
            {
                return $"{timeSpan.Seconds} seconds ago";
            }
            return "";
        }
    }
}
