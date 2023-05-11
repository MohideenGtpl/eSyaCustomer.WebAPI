using HCP.Customer.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Customer.IF
{
    public interface ICustomerAttributesRepository
    {
        Task<DO_CustomerAttributes> GetAllPatientTypesforTreeView(int CodeType);

        Task<DO_PatientTypeCategory> GetPatientCategoryInfo(int PatientTypeId, int PatientCategoryId);

        Task<DO_ReturnParameter> InsertPatientCategory(DO_PatientTypeCategory obj);

        Task<DO_ReturnParameter> UpdatePatientCategory(DO_PatientTypeCategory obj);

        Task<List<DO_SpecialtyMaster>> GetSpecialtyMaster();

        Task<List<DO_PatientTypeSpecialty>> GetSpecialtyByPatientTypeAndCategory(int PatientTypeId, int PatientCategoryId);

        Task<List<DO_PatientRateType>> GetPatientRateTypeByPatientTypeAndCategory(int PatientTypeId, int PatientCategoryId);

        Task<List<DO_PatientCategoryDocumentType>> GetPatientCategoryDocumentTypeByPatientTypeAndCategory(int PatientTypeId, int PatientCategoryId);
    }
}
