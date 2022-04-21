using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace LinqWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var session = new SQLiteConnection("..\\..\\..\\event_data.db", false);
            var events = session.Query<Event>("select * from events").ToList();

            var event_count = events.Count();
            Console.WriteLine("Number of events : " + event_count);

            // 1. select clause

            // 2. select where clause

            // 3. order by / orderby descending
           
            // 4. Reverse

            // 5. First or default 

            // 6. Sum / Min / Max / Average

            // 7. take / skip

            // 8. group by



#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif


        }
    }
}
