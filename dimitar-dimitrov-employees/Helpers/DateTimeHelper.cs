namespace dimitar_dimitrov_employees.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime MaxDateTime(DateTime dateTime1, DateTime dateTime2)
        {
            return dateTime1 < dateTime2 ? dateTime2 : dateTime1;
        }
        public static DateTime MinDateTime(DateTime dateTime1, DateTime dateTime2)
        {
            return dateTime1 > dateTime2 ? dateTime2 : dateTime1;
        }
    }
}
