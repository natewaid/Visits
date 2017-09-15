using System;
using System.Collections.Generic;
using System.Linq;

namespace Visits
{
    public class Visit
    {
        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public static Tuple<int, DateTime> Find(Visit[] visits)
        {
            int peak = 0;
            int occupants = 0;
            DateTime peakAchieved = DateTime.MinValue;

            List<DateTime> starts = visits
                .OrderBy(v => v.Start)
                .Select(v => v.Start)
                .ToList();

            for (int i = 0; i < starts.Count(); i++)
            {
                occupants++;

                if (occupants > peak)
                {
                    peak = occupants;
                    peakAchieved = starts.ElementAt(i);
                }

                if (i == 0)
                {
                    continue;
                }

                occupants -= visits.Where(v =>
                    v.End > starts.ElementAt(i - 1)
                    && v.End < starts.ElementAt(i))
                    .Count();
            }

            return new Tuple<int, DateTime>(peak, peakAchieved);
        }
    }
}
