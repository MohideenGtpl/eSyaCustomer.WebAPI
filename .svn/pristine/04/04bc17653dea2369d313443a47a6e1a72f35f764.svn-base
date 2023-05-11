using HCP.Customer.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Customer.IF
{
   public interface IPatientPreRegistrationRepository
    {
        Task<List<DO_PatientPreRegistration>> GetPatientPreRegistrationsbyBusinessKey(int Businesskey);

        Task<DO_ReturnParameter> InsertPatientPreRegistration(DO_PatientPreRegistration obj);

        Task<List<DO_IsdCodes>> GetISDCodes();

        Task<List<DO_Place>> GetStateList(int isdCode);

        Task<List<DO_Place>> GetCityList(int isdCode, int? stateCode);

        Task<List<DO_AddressIN>> GetAreaList(int isdCode, int? stateCode, int? cityCode, string pincode);

        Task<DO_AddressIN> GetAreaDetailsbyPincode(int isdCode, string pincode);

        Task<DO_AddressIN> GetPinCodebyAreaCode(int isdCode, int? stateCode, int? cityCode, int areacode);
    }
}
