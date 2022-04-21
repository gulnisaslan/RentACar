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
    public class PaymentsController : ControllerBase
    {
    //    IPaymentService _paymentService;

    //    public OperationClaimsController IPaymentService paymentService)
    //    {
    //        _paymentService = paymentService;
    //    }


    //    [HttpGet("getall")]
    //    public IActionResult GetAll()
    //    {
    //        var result = _paymentService.GetAll();
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest();
    //    }

    //    [HttpGet("getbyid")]
    //    public IActionResult GetById(int id)
    //    {
    //        var result = _paymentService.GetById(id);
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest();
    //    }
    //    [HttpPost("add")]
    //    public IActionResult Add(FakeCard fakeCard)
    //    {
    //        var result = _paymentService.Add(fakeCard);
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest();
    //    }

    //    [HttpPut("update")]
    //    public IActionResult Update(FakeCard fakeCard)
    //{
    //        var result = _paymentService.Update(fakeCard);
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest();
    //    }

    //    [HttpDelete("delete")]
    //    public IActionResult Delete(FakeCard fakeCard)
    //{
    //        var result = _paymentService.Delete(fakeCard);
    //        if (result.Success)
    //        {
    //            return Ok(result);
    //        }
    //        return BadRequest();
    //    }
    }
}
