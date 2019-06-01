namespace crgolden.Sage
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    public static class DateTimeExtensions
    {
        public static Dictionary<EntityState, string[]> ToGroupedKeys(
            this DateTime compareDate,
            Tuple<string, string>[] tuples)
        {
            var dictionary = new Dictionary<EntityState, string[]>();
            var createdKeys = new List<string>();
            var updatedKeys = new List<string>();
            foreach(var tuple in tuples)
            {
                var key = tuple.Item2;
                if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(key)) continue;
                var dateTimesArray = tuple.Item1.Split(',');
                if (dateTimesArray.Length != 4) continue;

                var yearMonthDay = dateTimesArray[0];
                var hourMinutes = decimal.Parse(dateTimesArray[1]);
                var date = FromSageValues(yearMonthDay, hourMinutes);
                if (date > compareDate)
                {
                    createdKeys.Add(key);
                    continue;
                }

                yearMonthDay = dateTimesArray[2];
                hourMinutes = decimal.Parse(dateTimesArray[3]);
                date = FromSageValues(yearMonthDay, hourMinutes);
                if (date > compareDate)
                {
                    updatedKeys.Add(key);
                }
            }

            if (createdKeys.Any()) dictionary.Add(EntityState.Added, createdKeys.ToArray());
            if (updatedKeys.Any()) dictionary.Add(EntityState.Modified, updatedKeys.ToArray());
            return dictionary;
        }

        private static DateTime FromSageValues(string yearMonthDay, decimal hourMinutes)
        {
            var hour = Math.Floor(hourMinutes);
            var minutes = Math.Floor((hourMinutes - hour) * 60);
            var seconds = Math.Floor((((hourMinutes - hour) * 60) - minutes) * 60);
            return DateTime.ParseExact(
                s: $"{yearMonthDay} {hour:00.##}:{minutes:00.##}:{seconds:00.##}",
                format: "yyyyMMdd HH:mm:ss",
                provider: CultureInfo.InvariantCulture,
                style: DateTimeStyles.None);
        }
    }
}
