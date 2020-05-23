using System;

namespace PNTask01
{
    /// <summary>
    /// Task2. Implement TimeSpanExtended. 
    /// <see cref="TimeSpan"/> class doesn't have "years,months,weeks" properties.
    /// Extend them.
    /// as for in/out data,  refer to <see cref="UnitTest1.TimeSpanExtendedTest"/>.
    /// </summary>
    public class TimeSpanExtended
    { 
        public int Years { get; set; }

        public int Months { get; set; }
				
        public int Weeks { get; set; }
				
        public int Days { get; set; }
			
        public int Hours { get; set; }
			
        public int Minutes { get; set; }
				
        public int Seconds { get; set; }

        public TimeSpanExtended(DateTime  from, DateTime to)
        {
            //1. 
            //*** need to refer to calendar
            //months and years depend on DateTime(Apr=30days, May=31days...  ). 
            throw new NotImplementedException();
        }
            
        public string ToStringEx(bool onlyTopLevel = false, string sec = "Seconds", string min = "Minutes",
            string hour = "Hours", string day = "Days", string week = "Weeks",
            string month = "Months", string year = "Years")
        {
				
            //2. To Text
            //onlyTopLevel: ex. true-> 1 day, false-> 1 days 2 minutes.
            //if property == 0 not show 
            throw new NotImplementedException();
        }
			
    }
}