using Azure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Paystack.Net.SDK.Models;
using Paystack.Net.SDK.Transactions;
using SnackStore.Data.Context;
using SnackStore.Data.Domains.Dto;
using SnackStore.Data.Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SnackStore.Core.Services.Implementation
{
    public class PaystackService
    {
        private readonly string _apiKey;
        private readonly PaystackTransaction _paystackTransaction;
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public PaystackService(string apiKey, AppDbContext db, UserManager<ApplicationUser> userManager)
        {
            _apiKey = apiKey;
            _db = db;
            _paystackTransaction = new PaystackTransaction(apiKey);
            _userManager = userManager;
        }

        public async Task<ResponseDto<PaystackTransactionResponse>> MakePayment(string userId, PaystackTransactionRequest transactionRequest)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {

            }
            ShoppingCart shoppingCart = _db.ShoppingCarts
                .Include(u => u.CartItems)
                .ThenInclude(u => u.MenuItem).FirstOrDefault(u => u.UserId == userId);

            var responseDto = new ResponseDto<PaystackTransactionResponse>();

            if (shoppingCart == null || shoppingCart.CartItems == null || shoppingCart.CartItems.Count() == 0)
            {
                responseDto.StatusCode = 400;
                responseDto.DisplayMessage = "";
                responseDto.Result = null;
            }

            #region Create Payment Intent
            shoppingCart.CartTotal = shoppingCart.CartItems.Sum(u => u.Quantity * u.MenuItem.Price);

            var request = new TransactionInitializationRequestModel
            {
                reference = transactionRequest.Reference,
                amount = (int)(shoppingCart.CartTotal * 100),
                email =  user.Email,
                callbackUrl = transactionRequest.CallbackUrl
            };
            var response = await _paystackTransaction.InitializeTransaction(request);

            if (response.data == null)
            {
                responseDto.DisplayMessage = "Paystack API returned a null response for transaction initialization.";
                responseDto.StatusCode = 400;
                responseDto.Result = null;
            }
            else
            {
                var transactionResponse = new PaystackTransactionResponse
                {
                    Status = response.status,
                    Message = response.message,
                    Data = new TransactionData
                    {
                        AuthorizationUrl = response.data.authorization_url,
                        AccessCode = response.data.access_code,
                        Reference = response.data.reference
                    }
                };

                responseDto.DisplayMessage = "Paystack transaction created successfully.";
                responseDto.StatusCode = 200;
                responseDto.Result = transactionResponse;

                if (shoppingCart != null)
                {
                    shoppingCart.PaymentReference = response.data.reference;
                }
            }
            #endregion

            return responseDto;
        }
    }
}
