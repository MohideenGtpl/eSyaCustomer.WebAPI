using System;
using System.Collections.Generic;
using System.Text;

namespace HCP.Customer.DO
{
    public class DO_CustomerAttributes
    {
        public List<DO_PatientType> l_PatientType { get; set; }
        public List<DO_PatientTypeCategory> l_PatienTypeCategory { get; set; }
        
    }

    public class DO_PatientTypeCategory
    {
        public int PatientTypeId { get; set; }
        public int PatientCategoryId { get; set; }
        public bool TreatmentAllowedOp { get; set; }
        public bool TreatmentAllowedIp { get; set; }
        public bool IsSpecialtyLink { get; set; }
        public bool CareCardApplicable { get; set; }
        public string ServiceWiseRateType { get; set; }
        public int RateType { get; set; }
        public bool ValidateDocument { get; set; }
        public bool ActiveStatus { get; set; }
        public List<int> Speialtylink { get; set; }
        public List<DO_PatientRateType> PatientRateTypeList { get; set; }
        public List<DO_PatientCategoryDocumentType> PatientCategoryDocumentTypeList { get; set; }
        public string Description { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }

    public class DO_PatientTypeSpecialty
    {
        public int PatientTypeId { get; set; }
        public int PatientCategoryId { get; set; }
        public int SpecialtyId { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }

    public class DO_PatientType
    {
        public int PatientTypeId { get; set; }
        public string Description { get; set; }
        public bool ActiveStatus { get; set; }
    }

    public class DO_SpecialtyMaster
    {
        public int SpecialtyId { get; set; }
        public string SpecialtyDesc { get; set; }
        public string Gender { get; set; }
        public string SpecialtyType { get; set; }
        public string AlliedServices { get; set; }
        public bool ActiveStatus { get; set; }
    }

    public class DO_PatientRateType
    {
        public int PatientTypeId { get; set; }
        public int PatientCategoryId { get; set; }
        public int ServiceType { get; set; }
        public int RateType { get; set; }
        public string ServiceTypeDescription { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }

    public class DO_PatientCategoryDocumentType
    {
        public int PatientTypeId { get; set; }
        public int PatientCategoryId { get; set; }
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
