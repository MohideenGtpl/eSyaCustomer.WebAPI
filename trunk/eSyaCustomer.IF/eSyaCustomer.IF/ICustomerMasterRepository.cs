﻿using HCP.Customer.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Customer.IF
{
    public interface ICustomerMasterRepository
    {
        Task<List<DO_CustomerCodes>> GetCustomerCodeInformationByNamePrefix(string customerNamePrefix);

        Task<List<DO_CustomerCodes>> GetCustomerCodeInformationByNamePrefixOnHold(string customerNamePrefix, string customerOnHold);

        Task<List<DO_CustomerCodes>> GetCustomerCodeInformationByCustomerId(int customerId);

        Task<DO_ReturnParameter> InsertIntoCustomerCode(DO_CustomerCodes obj);

        Task<DO_ReturnParameter> UpdateCustomerCode(DO_CustomerCodes obj);

        Task<DO_ReturnParameter> ActiveOrDeActiveCustomer(bool status, int customerId);

        Task<List<DO_CustomerContact>> GetCustomerContactInformationByCustomerId(int customerId);

        Task<DO_CustomerContact> GetCustomerContactInformationByCustomerIdLocId(int customerId, int locationId);

        Task<DO_ReturnParameter> InsertIntoCustomerContact(DO_CustomerContact obj);

        Task<DO_ReturnParameter> UpdateCustomerContact(DO_CustomerContact obj);

        Task<List<DO_CustomerBusinessLocation>> GetCustomerBusinessLocationByCustomerId(int customerId);

        Task<DO_ReturnParameter> InsertOrUpdateCustomerBusinessLocation(List<DO_CustomerBusinessLocation> obj);

        Task<List<DO_CustomerStatutoryDetail>> GetStatutoryInformationByCusIdLocIdIsdCode(int customerId, int locationId, int isdCode);

        Task<DO_ReturnParameter> InsertOrUpdateCustomerStatutoryDetail(List<DO_CustomerStatutoryDetail> obj);

        Task<DO_ReturnParameter> UpdateCustomerCodeForHold(DO_CustomerCodes obj);
    }
}
