using HCP.Customer.DL.Entities;
using HCP.Customer.DO;
using HCP.Customer.IF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Customer.DL.Repository
{
    public class CommonDataRepository : ICommonDataRepository
    {
        public async Task<List<DO_CountryCodes>> GetISDCodes()
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEccncd
                        .Where(w => w.ActiveStatus)
                        .AsNoTracking()
                        .Select(r => new DO_CountryCodes
                        {
                            Isdcode = r.Isdcode,
                            CountryName = r.CountryName
                        }).ToListAsync();

                    return await ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_ApplicationCodes>> GetApplicationCodesByCodeType(int codeType)
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEcapcd
                        .Where(w => w.CodeType == codeType && w.ActiveStatus)
                        .AsNoTracking()
                        .Select(r => new DO_ApplicationCodes
                        {
                            ApplicationCode = r.ApplicationCode,
                            CodeDesc = r.CodeDesc
                        }).OrderBy(o => o.CodeDesc).ToListAsync();

                    return await ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_BusinessLocation>> GetBusinessKey()
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var bk = db.GtEcbsln
                        .Where(w => w.ActiveStatus)
                        .AsNoTracking()
                        .Select(r => new DO_BusinessLocation
                        {
                            BusinessKey = r.BusinessKey,
                            LocationDescription = r.BusinessName + " - " + r.LocationDescription,
                            SegmentDesc = r.GtEcbssg.SegmentDesc
                        }).ToListAsync();

                    return await bk;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_ServiceGroup>> GetServiceGroup()
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var sg = db.GtEssrgr
                        .Where(w => w.ActiveStatus)
                        .AsNoTracking()
                        .Select(r => new DO_ServiceGroup
                        {
                            ServiceGroupId = r.ServiceGroupId,
                            ServiceGroupDesc = r.ServiceGroupDesc
                        }).ToListAsync();

                    return await sg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_ServiceClass>> GetServiceClassBySrGroupId(int serviceGroupId)
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var sg = db.GtEssrcl
                        .Where(w => w.ServiceGroupId == serviceGroupId && w.ActiveStatus)
                        .AsNoTracking()
                        .Select(r => new DO_ServiceClass
                        {
                            ServiceClassId = r.ServiceClassId,
                            ServiceClassDesc = r.ServiceClassDesc
                        }).ToListAsync();

                    return await sg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_ApplicationCodes>> GetApplicationCodesByCodeTypeList(List<int> l_codeType)
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEcapcd
                        .Where(w => w.ActiveStatus
                        && l_codeType.Contains(w.CodeType))
                        .Select(r => new DO_ApplicationCodes
                        {
                            CodeType = r.CodeType,
                            ApplicationCode = r.ApplicationCode,
                            CodeDesc = r.CodeDesc
                        }).OrderBy(o => o.CodeDesc).ToListAsync();

                    return await ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
