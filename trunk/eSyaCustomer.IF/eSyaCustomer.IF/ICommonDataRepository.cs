﻿using HCP.Customer.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Customer.IF
{
    public interface ICommonDataRepository
    {
        Task<List<DO_CountryCodes>> GetISDCodes();

        Task<List<DO_ApplicationCodes>> GetApplicationCodesByCodeType(int codeType);

        Task<List<DO_BusinessLocation>> GetBusinessKey();

        Task<List<DO_ServiceGroup>> GetServiceGroup();

        Task<List<DO_ServiceClass>> GetServiceClassBySrGroupId(int serviceGroupId);

        Task<List<DO_ApplicationCodes>> GetApplicationCodesByCodeTypeList(List<int> l_codeType);
    }
}
