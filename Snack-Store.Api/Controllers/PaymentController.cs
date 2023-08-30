using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SnackStore.Core.Services.Implementation;
using SnackStore.Data.Context;
using SnackStore.Data.Domains.Dto;
using SnackStore.Data.Domains.Models;
using System.Net;

namespace Snack_Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly PaystackService _paystackService;

        public PaymentController(PaystackService paystackService)
        {
             _paystackService = paystackService;
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse>> MakePayment([FromBody] PaystackTransactionRequest transactionRequest, string userId)
        {
            var response = await _paystackService.MakePayment(userId, transactionRequest);
            return Ok(response);
        }
    }
}
