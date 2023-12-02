using System;

public class DateHelper
{
    public static DateTime GetDate(string date)
    {
        return DateTime.Parse(date);
    }

    public static string GetDateString(DateTime date)
    {
        return date.ToString("yyyy-MM-dd");
    }

    public static string GetTimeString(DateTime date)
    {
        return date.ToString("HH:mm:ss");
    }
}
