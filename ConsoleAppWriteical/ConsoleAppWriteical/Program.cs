using System;

namespace ConsoleAppWriteical
{
    class Program
    {
        static void Main(string[] args)
        {
            // from mac
            string[] lines;
            lines = new string[] {
            "2018/07/01,http://a.com/sample.pdf,Name"
            };

            System.Console.WriteLine("BEGIN:VCALENDAR");

            foreach (var line in lines)
            {
                var values = line.Split(',');
                foreach (var value in values)
                {
                    //System.Console.WriteLine("{0} ", value);
                }

                System.Console.WriteLine("BEGIN:VEVENT");

                DateTime DateStart = DateTime.Parse(values[0]);
                DateTime DateEnd = DateStart.AddDays(1);

                System.Console.WriteLine("DTSTART;VALUE=DATE:" + DateStart.ToString("yyyyMMdd"));
                System.Console.WriteLine("DTEND;VALUE=DATE:" + DateEnd.ToString("yyyyMMdd"));
          

                System.Console.WriteLine("SUMMARY:" + values[2] + "");
                System.Console.WriteLine("LOCATION:" + values[2] + "");
                System.Console.WriteLine("DESCRIPTION:<a href=\"" + values[1] + "\">" + values[1] + "</a><br>" + 
                    "<a href=\"" + values[1] + "\">" + values[1] + "</a>" );

                System.Console.WriteLine("END:VEVENT");
            }
            System.Console.WriteLine("END:VCALENDAR");
        }
    }
}
