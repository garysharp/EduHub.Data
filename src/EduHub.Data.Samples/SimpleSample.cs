using System;
using System.Linq;
using static System.Console;

namespace EduHub.Data.Samples
{
    public static class SimpleSample
    {
        public static void Run()
        {
            WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Simple Sample");
            ForegroundColor = ConsoleColor.White;
            WriteLine("Selects all active students.");
            WriteLine();

            // Create an EduHubContext
            var Context = new EduHubContext();

            // Test for availability of data set
            Context.ST.EnsureAvailable();

            // Data Updated
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("eduHub Students Updated: {0:G}", Context.ST.Age);

            // Build using Query Syntax
            var activeStudents = (
                from st in Context.ST
                where st.STATUS == "ACTV"
                select new
                {
                    StudentCode = st.STKEY,
                    Name = $"{st.SURNAME}, {st.FIRST_NAME}",
                    Surname = st.SURNAME,
                    HomeGroup = st.HOME_GROUP,
                    YearLevel = st.SCHOOL_YEAR
                });

            // Build using Method Syntax
            //   var activeStudents = Context.ST
            //       .Where(st => st.STATUS == "ACTV")
            //       .Select(st => new
            //       {
            //           StudentCode = st.STKEY,
            //           Name = $"{st.SURNAME}, {st.FIRST_NAME}",
            //           Surname = st.SURNAME,
            //           HomeGroup = st.HOME_GROUP,
            //           YearLevel = st.SCHOOL_YEAR
            //       });

            // Write Headers to Console
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"{"Code",-7} {"Name",-52} {"HG",-4} {"YL",-4}");

            // Write Data to Console
            ForegroundColor = ConsoleColor.Gray;
            foreach (var student in activeStudents) // Evaluate Query
            {
                WriteLine($"{student.StudentCode,-7} {student.Name,-52} {student.HomeGroup,-4} {student.YearLevel,-4}");
            }
        }
    }
}
