using System;

namespace CS6232GroupProject.Model
{
    /// <summary>
    /// This class creates a TestResult object with auto-implemented properties.
    /// </summary>
    class LabTestResult
    {
        public int ResultID { get; set; }
        public int TestID { get; set; }
        public int VisitID { get; set; }
        public string Result { get; set; }
        public DateTime? TestOrderedDate { get; set; }
        public DateTime? TestResultDate { get; set; }
        public string Name { get; set; }
    }
}
