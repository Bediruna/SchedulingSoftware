using System.Linq;

namespace SchedulingSoftware.SupportCode
{

    //Helper class that contains methods to help the program.
    class Helper
    {

        public static void validateApptTime()
        {
            var evens = Enumerable.Range(1, 100).Where(x => (x % 2) == 0).ToList();
        }

    }
}
