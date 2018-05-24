using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTE_Assistant
{
    public class WTEHelper
    {
        public static string HOMEDRIVE = System.Environment.GetEnvironmentVariable("HOMEDRIVE");
        public static string WOR = System.Environment.GetEnvironmentVariable("WOR");
        public static string IntegrationTestsDir = HOMEDRIVE + "\\TestBin\\IntegrationTests";
        public static string TestResultsDir = IntegrationTestsDir + "\\TestResults";


        public static List<string> GetTestResultsNameList()
        {
            List<string> TestResultsNameList = new List<string>();

            var files = Directory.GetFiles(TestResultsDir, "*.trx");
            int index = 1;
            foreach (var file in files)
            {
                TestResultsNameList.Add(file);
                Console.WriteLine("{0}: {1}", index++, file);
            }

            return TestResultsNameList;
        }

    }
}
