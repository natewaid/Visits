using System;

namespace Visits
{
    class Program
    {        
        static void Main(string[] args)
        {
            var visits = new[]
            {
                new Visit { Start = new DateTime(2017,9,15,1,0,0), End = new DateTime(2017,9,15,1,30,0) },
                new Visit { Start = new DateTime(2017,9,15,1,5,0), End = new DateTime(2017,9,15,1,8,0) },
                new Visit { Start = new DateTime(2017,9,15,1,10,0), End = new DateTime(2017,9,15,1,40,0) },
                new Visit { Start = new DateTime(2017,9,15,1,15,0), End = new DateTime(2017,9,15,1,30,0) },
                new Visit { Start = new DateTime(2017,9,15,1,20,0), End = new DateTime(2017,9,15,1,23,0) },
                new Visit { Start = new DateTime(2017,9,15,1,25,0), End = new DateTime(2017,9,15,1,30,0) },
                new Visit { Start = new DateTime(2017,9,15,1,27,0), End = new DateTime(2017,9,15,1,32,0) },
                new Visit { Start = new DateTime(2017,9,15,1,45,0), End = new DateTime(2017,9,15,1,50,0) },
                new Visit { Start = new DateTime(2017,9,15,1,51,0), End = new DateTime(2017,9,15,2,0,0) }
            };

            var result = Visit.Find(visits);

            Console.WriteLine($"Peak:  {result.Item1}");
            Console.WriteLine($"Peak Achieved:  {result.Item2}");
            Console.ReadKey();
        }
    }
}