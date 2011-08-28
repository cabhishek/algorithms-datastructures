using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodingPractice
{
    public static class TestMFD
    {
        private static int counter;
        private static string line;

        public static void run()
        {
            var garyList = new List<int>();
            var dbList = new List<int>();
            var garyReader = new StreamReader(@"B:\2011-03-02_My_Fool_Daily-html.apr");
            var dbReader = new StreamReader(@"B:\dbList.txt");
            string regEx1 = @"::\d+";
            string regEx2 = @"\d+";

            while ((line = garyReader.ReadLine()) != null)
            {
                counter++;

                var r1 = new Regex(regEx1, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                var r2 = new Regex(regEx2, RegexOptions.IgnoreCase | RegexOptions.Singleline);

                Match m = r1.Match(line);
                if (m.Success)
                {
                    Match m2 = r2.Match(m.ToString());
                    garyList.Add(int.Parse(m2.Groups[0].ToString()));
                }
            }

            while ((line = dbReader.ReadLine()) != null)
            {
                dbList.Add(int.Parse(line));
            }

            garyReader.Close();
            dbReader.Close();

            Console.WriteLine(garyList.Count);
            Console.WriteLine(dbList.Count);

            List<int> notInList = (from dbdata in dbList
                                   where !garyList.Contains(dbdata)
                                   select dbdata).OrderByDescending(a => a).ToList();

            List<int> inList = (from dbdata in dbList
                                where garyList.Contains(dbdata)
                                select dbdata).OrderByDescending(a => a).ToList();

            List<int> extraGaryData = (from dbdata in garyList
                                   where !dbList.Contains(dbdata)
                                   select dbdata).OrderByDescending(a => a).ToList();

            Console.WriteLine(notInList.Count);
            Console.WriteLine(inList.Count);

            using (var writer = new StreamWriter(@"B:\notIn.txt"))
            {
                foreach (int i in notInList)
                {
                    writer.WriteLine(i);
                }
            }

            using (var writer = new StreamWriter(@"B:\in.txt"))
            {
                foreach (int i in inList)
                {
                    writer.WriteLine(i);
                }
            }

            using (var writer = new StreamWriter(@"B:\extraGaryData.txt"))
            {
                foreach (int i in extraGaryData)
                {
                    writer.WriteLine(i);
                }
            }
        }
    }
}