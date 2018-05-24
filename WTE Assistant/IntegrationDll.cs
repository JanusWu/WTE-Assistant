using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTE_Assistant
{
    public class IntegrationDll
    {
        string DllName;
        int TotalTestNum;
        int PassedTestNum;
        int NotExecutedTestNum;
        int FailedTestNum;

        public List<Test> Tests;
        public List<Test> FailedTests;
    }

    public class Test
    {
        string TestName;
        string ErrorMessage;
        string ErrorStackTrace;
        string DllName;
        TestResult Result;
    }

    public enum TestResult
    {
        Passed,
        Failed,
        NotExecuted
    }
}
