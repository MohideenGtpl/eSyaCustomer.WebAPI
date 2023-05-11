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
    public class CommonDataController : ControllerBase
    {
        private readonly ICommonDataRepository _CommonDataRepository;
        public CommonDataController(ICommonDataRepository CommonDataRepository)
        {
            _CommonDataRepository = CommonDataRepository;
        }

        /// <summary>
        /// Get ISD Code
        /// UI Reffered - Customer Contact
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetISDCodes()
        {
            var pa_rm = await _CommonDataRepository.GetISDCodes();
            return Ok(pa_rm);
        }

        /// <summary>
        /// Get Application Code
        /// UI Reffered - Customer Hold
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetApplicationCodesByCodeType(int codeType)
        {
            var pa_rm = await _CommonDataRepository.GetApplicationCodesByCodeType(codeType);
            return Ok(pa_rm);
        }

        /// <summary>
        /// Get Business Key
        /// UI Reffered - Patient Category Discount
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetBusinessKey()
        {
            var pa_rm = await _CommonDataRepository.GetBusinessKey();
            return Ok(pa_rm);
        }

        /// <summary>
        /// Get Service Group
        /// UI Reffered - Patient Category Discount
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetServiceGroup()
        {
            var pa_rm = await _CommonDataRepository.GetServiceGroup();
            return Ok(pa_rm);
        }

        /// <summary>
        /// Get Service Class by Service Group Id
        /// UI Reffered - Patient Category Discount
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetServiceClassBySrGroupId(int serviceGroupId)
        {
            var pa_rm = await _CommonDataRepository.GetServiceClassBySrGroupId(serviceGroupId);
            return Ok(pa_rm);
        }
        /// <summary>
        /// Get Application Codes
        /// UI Reffered - Patient Pre Regsitration 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetApplicationCodesByCodeTypeList(List<int> l_codeType)
        {
            var pa_rm = await _CommonDataRepository.GetApplicationCodesByCodeTypeList(l_codeType);
            return Ok(pa_rm);
        }
    }
}
