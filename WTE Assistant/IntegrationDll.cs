﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTE_Assistant
{
    public class IntegrationDllResult
    {
        public string DllName { get; set; }

        public string DllPath { get; set; }

        public int TotalTestNum { get; set; }

        public int PassedTestNum { get; set; }

        public int NotExecutedTestNum { get; set; }

        public int FailedTestNum { get; set; }

        public List<TestResult> TestResults;

        public List<TestResult> FailedTestResults;
    }

    public class TestResult
    {
        public string TestName { get; set; }

        public string TestID { get; set; }

        public string ErrorMessage { get; set; }

        public string StackTrace { get; set; }

        public string DllName { get; set; }

        public string Outcome { get; set; }

        public string AssemblyPathName { get; set; }

        public string FullClassName { get;set; }
    }

    public enum Outcome
    {
        Passed,
        Failed,
        NotExecuted
    }
}
