using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Model;
using LibraryProject.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeeStatusController : ControllerBase
    {
        private readonly IFeeStatusService _feestatusService;

        public FeeStatusController(IFeeStatusService feestatusService)
            {
                this._feestatusService = feestatusService;
            }


            [HttpGet("getallfeestatus")]
            public IActionResult GetAllFeeStatus()
            {

                return Ok(this._feestatusService.GetAllFeeStatus());
            }

            [HttpPost("addfeestatus")]
            public IActionResult AddFeeStatus(FeeStatus feestatus)
            {
                return Ok(this._feestatusService.AddFeeStatus(feestatus));
            }


            [HttpPut("updatefeestatus")]
            public IActionResult UpdateFeeStatus(FeeStatus feestatus)
            {
                return Ok(this._feestatusService.UpdateFeeStatus(feestatus));
            }

            [HttpDelete("deletefeestatus/{feestatusId}")]
            public IActionResult DeleteFeeStatus(int feestatusid)
            {
                return Ok(this._feestatusService.DeleteFeeStatus(feestatusid));
            }

        }
    }

