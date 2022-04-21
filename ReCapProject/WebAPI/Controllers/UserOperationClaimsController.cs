using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOperationClaimsController : ControllerBase
    {
        IUserOperationClaimService _userOperationClaim;

        public UserOperationClaimsController(IUserOperationClaimService userOperationClaim)
        {
            _userOperationClaim = userOperationClaim;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userOperationClaim.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _userOperationClaim.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("getbyuserid")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _userOperationClaim.GetByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(UserOperationClaim userOperationClaim)
        {
            var result = _userOperationClaim.Add(userOperationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
       
        [HttpPut("update")]
        public IActionResult Update(UserOperationClaim userOperationClaim)
        {
            var result = _userOperationClaim.Update(userOperationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete("delete")]
        public IActionResult Delete(UserOperationClaim userOperationClaim)
        {
            var result = _userOperationClaim.Delete(userOperationClaim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
