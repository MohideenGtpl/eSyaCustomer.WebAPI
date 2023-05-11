using System;
using System.Collections.Generic;
using System.Text;

namespace HCP.Customer.DO
{
    public class DO_CustomerCodes
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int CreditPeriod { get; set; }
        public decimal CreditLimit { get; set; }
        public bool ValidateLimit { get; set; }
        public string CustomerOnHold { get; set; }
        public int HoldReason { get; set; }
        public bool IsLimitBreakupReqd { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
