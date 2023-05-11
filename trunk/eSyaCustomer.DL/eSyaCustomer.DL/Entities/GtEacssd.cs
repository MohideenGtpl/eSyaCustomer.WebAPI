using System;
using System.Collections.Generic;

namespace HCP.Customer.DL.Entities
{
    public partial class GtEacssd
    {
        public int CustomerId { get; set; }
        public int CustomerLocationId { get; set; }
        public int StatutoryCode { get; set; }
        public string StatutoryDescription { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }

        public virtual GtEacscc Customer { get; set; }
    }
}
