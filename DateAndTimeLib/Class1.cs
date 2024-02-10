namespace DateAndTimeLib
{
    public static class DateTimeUtils
    {
        public static TimeSpan GetDateDifference(DateTime firstDate, DateTime secondDate)
        {
            return secondDate - firstDate;
        }

        public static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        public static string GetTimeOfDay(DateTime time)
        {
            if (time.TimeOfDay < TimeSpan.FromHours(6))
            {
                return "Ночь";
            }
            else if (time.TimeOfDay < TimeSpan.FromHours(12))
            {
                return "Утро";
            }
            else if (time.TimeOfDay < TimeSpan.FromHours(18))
            {
                return "День";
            }
            else
            {
                return "Вечер";
            }
        }
        public static string FormatDateTime(DateTime dateTime, string format)
        {
            return dateTime.ToString(format);
        }   
    }
}
