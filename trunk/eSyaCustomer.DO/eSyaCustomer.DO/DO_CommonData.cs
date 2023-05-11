using System;
using System.Collections.Generic;
using System.Text;

namespace HCP.Customer.DO
{
    public class DO_ApplicationCodes
    {
        public int ApplicationCode { get; set; }
        public int CodeType { get; set; }
        public string CodeDesc { get; set; }
    }

    public class DO_BusinessLocation
    {
        public int BusinessKey { get; set; }
        public string LocationDescription { get; set; }
        public string SegmentDesc { get; set; }
        public bool ActiveStatus { get; set; }
    }

    public class DO_CountryCodes
    {
        public int Isdcode { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CountryFlag { get; set; }
        public string CurrencyCode { get; set; }
        public string MobileNumberPattern { get; set; }
        public string Uidlabel { get; set; }
        public string Uidpattern { get; set; }
        public string Nationality { get; set; }
        public bool IsPoboxApplicable { get; set; }
        public string PoboxPattern { get; set; }
        public bool IsPinapplicable { get; set; }
        public string PincodePattern { get; set; }
    }

    public class DO_ServiceGroup
    {
        public int ServiceGroupId { get; set; }
        public string ServiceGroupDesc { get; set; }
    }

    public class DO_ServiceClass
    {
        public int ServiceClassId { get; set; }
        public int ServiceGroupId { get; set; }
        public string ServiceClassDesc { get; set; }
    }

    public class DO_ServiceCodes
    {
        public int ServiceId { get; set; }
        public int ServiceClassId { get; set; }
        public string ServiceDesc { get; set; }
    }
}
