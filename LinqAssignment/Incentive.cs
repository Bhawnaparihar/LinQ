using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAssignment
{
    class Incentive
    {
        public int Employee_Ref_Id { get; set; }
        public System.DateTime Incentive_Date { get; set; }
        public double Incentive_Amount { get; set; }

        public static List<Incentive> GetIncentives()
        {
            List<Incentive> incentives = new List<Incentive>
            {
                new Incentive {Employee_Ref_Id = 1,Incentive_Date = new DateTime(2013,02,01),  Incentive_Amount = 5000 },
                new Incentive {Employee_Ref_Id = 2, Incentive_Date = new DateTime(2013,02,01),  Incentive_Amount = 3000},
                new Incentive {Employee_Ref_Id = 3,  Incentive_Date = new DateTime(2013,02,01),  Incentive_Amount = 4000},
                new Incentive {Employee_Ref_Id = 1, Incentive_Date = new DateTime(2013,01,01),  Incentive_Amount = 4500},
                new Incentive {Employee_Ref_Id = 2,  Incentive_Date = new DateTime(2013,01,01),  Incentive_Amount = 3500},
            };
            return incentives;
        }
    }
}
