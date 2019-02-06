using System;
using System.Linq;
using static System.Console;

namespace EduHub.Data.Samples
{
    public static class WriteBackSample
    {

        public static void Run()
        {

            WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Write-Back Sample");
            ForegroundColor = ConsoleColor.White;
            WriteLine("Checks the status of the latest Half-Day Attendance write-back.");
            WriteLine("Imports an attendance file for the previous day for all students.");
            WriteLine();

            // Create an EduHubContext
            var Context = new EduHubContext();

            // Explore latest response
            var latestResponse = Context.WriteBack.ATT_HALF_DAY.LatestResponse;
            if (latestResponse == null)
                WriteLine("No write-back response file was available");
            else
            {
                WriteLine($"Data Set: {latestResponse.DataSet.Description} [{latestResponse.DataSet.Name}]");
                WriteLine($"Processed: {latestResponse.Age}");
                WriteLine($"Is Success: {latestResponse.IsSuccess}");
                WriteLine($"Message: {latestResponse.Message}");
                if (!latestResponse.IsSuccess)
                {
                    WriteLine("Errors: ");
                    foreach (var error in latestResponse.Records)
                        WriteLine($"{error.Entity}:{error.EntityKey} = {error.ErrorText}");
                }
            }

            // Create write-back
            // gather sample data
            var yesterday = DateTime.Now.AddDays(-1).Date;
            var students = Context.ST.Where(s => s.STATUS == "ACTV").Take(100);

            using (var writeBack = Context.WriteBack.ATT_HALF_DAY.CreateWriteBack(FromDate: yesterday, ToDate: yesterday))
            {
                // fill writeBack with sample data
                foreach (var student in students)
                {
                    writeBack.Write(
                            StudentId: student.STKEY,
                            AbsenceDate: yesterday,
                            YearLevel: student.SCHOOL_YEAR,
                            AmCode: "100",
                            PmCode: "100");
                }

                // commit the write back from memory to the eduHub directory
                writeBack.Commit();
            }
        }

    }
}
