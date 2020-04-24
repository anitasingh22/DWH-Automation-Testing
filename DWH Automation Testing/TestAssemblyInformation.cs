using System;
using System.Collections.Generic;

namespace DWH_Automation_Testing
{
    public static class TestAssemblyInformation
    {
        public static int AssemblyTestCount { get { return 17; } }
    
        public static IDictionary<Guid, int> SuiteTestCounts
        {
            get
            {
                return new Dictionary<Guid, int>
                {
                    { new Guid("{ae79b540-c994-4d59-9294-b3d13bfa03a9}"), 9 },
                    { new Guid("{5f8cbcf1-fbf3-4dbb-a5ba-9a5c63b60082}"), 8 },
                };
            }
        }
    }
}
