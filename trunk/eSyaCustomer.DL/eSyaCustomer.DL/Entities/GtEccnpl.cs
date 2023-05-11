﻿using System;
using System.Collections.Generic;

namespace HCP.Customer.DL.Entities
{
    public partial class GtEccnpl
    {
        public int Isdcode { get; set; }
        public int PlaceId { get; set; }
        public int PlaceType { get; set; }
        public string PlaceName { get; set; }
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
