using HCP.Customer.DO;
using HCP.Customer.IF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaCustomer.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientCategoryDiscountController : ControllerBase
    {
        private readonly IPatientCategoryDiscountRepository _PatientCategoryDiscountRepository;
        public PatientCategoryDiscountController(IPatientCategoryDiscountRepository patientCategoryDiscountRepository)
        {
            _PatientCategoryDiscountRepository = patientCategoryDiscountRepository;
        }

        /// <summary>
        /// Get Patient Category Discount Class By Business Key , Patient category , Service For and Service Group
        /// UI Reffered - Patient Category Discount Class
        /// </summary>
        /// <param name="businessKey"></param>
        /// <param name="patientCategory"></param>
        /// <param name="serviceFor"></param>
        /// <param name="serviceGroupId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPatientCatDiscClassByBkPtCatSfSg(int businessKey, int patientCategory, string serviceFor, int serviceGroupId)
        {
            var pa_rm = await _PatientCategoryDiscountRepository.GetPatientCatDiscClassByBkPtCatSfSg(businessKey, patientCategory, serviceFor, serviceGroupId);
            return Ok(pa_rm);
        }

        /// <summary>
        /// Insert into Patient Category Discount Class.
        /// UI Reffered - Patient Category Discount Class
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertOrUpdatePatientCatDiscClass(List<DO_PatientCategoryDiscount> obj)
        {
            var msg = await _PatientCategoryDiscountRepository.InsertOrUpdatePatientCatDiscClass(obj);
            return Ok(msg);

        }

        /// <summary>
        /// Get Patient Category Discount Service By Business Key , Patient category , Service For and Service Group
        /// UI Reffered - Patient Category Discount
        /// </summary>
        /// <param name="businessKey"></param>
        /// <param name="patientCategory"></param>
        /// <param name="serviceFor"></param>
        /// <param name="serviceGroupId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPatientCatDiscServiceByBkPtCatSfSg(int businessKey, int patientCategory, string serviceFor, int serviceGroupId)
        {
            var pa_rm = await _PatientCategoryDiscountRepository.GetPatientCatDiscServiceByBkPtCatSfSg(businessKey, patientCategory, serviceFor, serviceGroupId);
            return Ok(pa_rm);
        }

        /// <summary>
        /// Insert into Patient Category Discount Service.
        /// UI Reffered - Patient Category Discount
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertOrUpdatePatientCatDiscService(List<DO_PatientCategoryDiscount> obj)
        {
            var msg = await _PatientCategoryDiscountRepository.InsertOrUpdatePatientCatDiscService(obj);
            return Ok(msg);

        }

    }
}
