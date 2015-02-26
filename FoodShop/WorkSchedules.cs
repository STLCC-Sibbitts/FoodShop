using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShop
{
    class WorkSchedules
    {
        int workScheduleID { get; set; }
        int storeID { get; set; }
        int employeeID { get; set; }
        DateTime workDate { get; set; }
        DateTime startTime { get; set; }
        DateTime endTime { get; set; }
        DateTime clockIn { get; set; }
        DateTime clockOut { get; set; }

        // Constructor
        public WorkSchedules (int scheduleID, int store, int empID, DateTime date, DateTime start, DateTime end, DateTime inTime, DateTime outTime)
        {
            workScheduleID = scheduleID;
            storeID = store;
            employeeID = empID;
            workDate = date;
            startTime = start;
            endTime = end;
            clockIn = inTime;
            clockOut = outTime;
        }
    }
}
