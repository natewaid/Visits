#if DEBUG

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Visits
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void finds_peak_for_visits_with_no_exits_in_between()
        {
            var visits = new[]
            {
                new Visit { Start = new DateTime(2017,9,15,1,0,0), End = new DateTime(2017,9,15,1,30,0) },
                new Visit { Start = new DateTime(2017,9,15,1,5,0), End = new DateTime(2017,9,15,1,25,0) },
                new Visit { Start = new DateTime(2017,9,15,1,10,0), End = new DateTime(2017,9,15,1,20,0) }
            };

            var result = Visit.Find(visits);
            var expectedPeak = 3;
            var expectedPeakAchieved = new DateTime(2017, 9, 15, 1, 10, 0);            

            Assert.AreEqual(expectedPeak, result.Item1);
            Assert.AreEqual(expectedPeakAchieved, result.Item2);
        }

        [TestMethod]
        public void finds_peak_for_visits_with_exits_in_between()
        {
            var visits = new[]
            {
                new Visit { Start = new DateTime(2017,9,15,1,0,0), End = new DateTime(2017,9,15,1,11,0) },
                new Visit { Start = new DateTime(2017,9,15,1,5,0), End = new DateTime(2017,9,15,2,0,0) },
                new Visit { Start = new DateTime(2017,9,15,1,10,0), End = new DateTime(2017,9,15,1,12,0) },
                new Visit { Start = new DateTime(2017,9,15,1,15,0), End = new DateTime(2017,9,15,1,20,0) },
                new Visit { Start = new DateTime(2017,9,15,1,21,0), End = new DateTime(2017,9,15,1,50,0) },
                new Visit { Start = new DateTime(2017,9,15,1,25,0), End = new DateTime(2017,9,15,1,26,0) },
                new Visit { Start = new DateTime(2017,9,15,1,30,0), End = new DateTime(2017,9,15,1,45,0) },
                new Visit { Start = new DateTime(2017,9,15,1,50,0), End = new DateTime(2017,9,15,1,53,0) },
                new Visit { Start = new DateTime(2017,9,15,2,5,0), End = new DateTime(2017,9,15,2,10,0) }
            };

            var result = Visit.Find(visits);
            var expectedPeak = 3;
            var expectedPeakAchieved = new DateTime(2017, 9, 15, 1, 10, 0);            

            Assert.AreEqual(expectedPeak, result.Item1);
            Assert.AreEqual(expectedPeakAchieved, result.Item2);
        }
    }
}

#endif