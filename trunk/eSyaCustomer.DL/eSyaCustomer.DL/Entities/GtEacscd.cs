﻿using System;
using System.Collections.Generic;

namespace HCP.Customer.DL.Entities
{
    public partial class GtEacscd
    {
        public int CustomerId { get; set; }
        public int CustomerLocationId { get; set; }
        public string CustomerLocation { get; set; }
        public bool IsLocationDefault { get; set; }
        public int Isdcode { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string RegisteredMobileNumber { get; set; }
        public string EMailId { get; set; }
        public string SecondaryMobileNumber { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }
    }
}
