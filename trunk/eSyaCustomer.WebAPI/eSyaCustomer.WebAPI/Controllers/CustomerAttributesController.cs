using HCP.Customer.DO;
using HCP.Customer.IF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCP.Customer.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerAttributesController : ControllerBase
    {
        private readonly ICustomerAttributesRepository _CustomerAttributesRepository;
        public CustomerAttributesController(ICustomerAttributesRepository CustomerAttributesRepository)
        {
            _CustomerAttributesRepository = CustomerAttributesRepository;
        }
        /// <summary>
        /// Get Patient Type Detail Information By CodeType
        /// UI Reffered - PatientTypes for Tree View
        /// </summary>
        /// <param name="CodeType"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllPatientTypesforTreeView(int CodeType)
        {
            var pa_types = await _CustomerAttributesRepository.GetAllPatientTypesforTreeView(CodeType);
            return Ok(pa_types);
        }

        /// <summary>
        /// Getting  Patient Category Info by PatientTypeId and  PatientCategoryId.
        /// UI Reffered - Customer Attributes.
        /// UI Params-PatientTypeId and  PatientCategoryId
        /// </summary>

        [HttpGet]
        public async Task<IActionResult> GetPatientCategoryInfo(int PatientTypeId, int PatientCategoryId)
        {
            var pa_cat = await _CustomerAttributesRepository.GetPatientCategoryInfo(PatientTypeId, PatientCategoryId);
            return Ok(pa_cat);
        }
        /// <summary>
        /// Insert into Patient Category.
        /// UI Reffered - Patient Category
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertPatientCategory(DO_PatientTypeCategory obj)
        {
            var msg = await _CustomerAttributesRepository.InsertPatientCategory(obj);
            return Ok(msg);

        }
        /// <summary>
        /// Update Patient Category.
        /// UI Reffered - Patient Category
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> UpdatePatientCategory(DO_PatientTypeCategory obj)
        {
            var msg = await _CustomerAttributesRepository.UpdatePatientCategory(obj);
            return Ok(msg);

        }
        /// <summary>
        /// Getting  GetSpecialty Master for jqgrid.
        /// UI Reffered - Customer Attributes.
        /// </summary>

        [HttpGet]
        public async Task<IActionResult> GetSpecialtyMaster()
        {
            var sp_master = await _CustomerAttributesRepository.GetSpecialtyMaster();
            return Ok(sp_master);
        }

        /// <summary>
        /// Getting  Patient Specialty  by Patient Type Id and  Patient Category Id.
        /// UI Reffered - Customer Attributes.
        /// UI Params-Patient Type Id and  Patient Category Id
        /// </summary>

        [HttpGet]
        public async Task<IActionResult> GetSpecialtyByPatientTypeAndCategory(int PatientTypeId, int PatientCategoryId)
        {
            var pt_sp = await _CustomerAttributesRepository.GetSpecialtyByPatientTypeAndCategory(PatientTypeId, PatientCategoryId);
            return Ok(pt_sp);
        }

        /// <summary>
        /// Getting  Patient Rate Type  by Patient Type Id and  Patient Category Id.
        /// UI Reffered - Customer Attributes.
        /// UI Params-Patient Type Id and  Patient Category Id
        /// </summary>

        [HttpGet]
        public async Task<IActionResult> GetPatientRateTypeByPatientTypeAndCategory(int PatientTypeId, int PatientCategoryId)
        {
            var pt_rt = await _CustomerAttributesRepository.GetPatientRateTypeByPatientTypeAndCategory(PatientTypeId, PatientCategoryId);
            return Ok(pt_rt);
        }

        /// <summary>
        /// Getting  Patient Category Document Type  by Patient Type Id and  Patient Category Id.
        /// UI Reffered - Customer Attributes.
        /// UI Params-Patient Type Id and  Patient Category Id
        /// </summary>

        [HttpGet]
        public async Task<IActionResult> GetPatientCategoryDocumentTypeByPatientTypeAndCategory(int PatientTypeId, int PatientCategoryId)
        {
            var pt_rt = await _CustomerAttributesRepository.GetPatientCategoryDocumentTypeByPatientTypeAndCategory(PatientTypeId, PatientCategoryId);
            return Ok(pt_rt);
        }
    }
}