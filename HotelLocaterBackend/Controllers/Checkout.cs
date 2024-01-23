using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Security.Cryptography;
using PayPalCheckoutSdk.Orders;
using PayPalCheckoutSdk.Core;
using PayPal;
using HotelsBackend.Data;
using Stripe;
using Stripe.Checkout;
using Microsoft.Extensions.Primitives;

namespace HotelsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Checkout : ControllerBase
    {

        private readonly IConfiguration _config;

        public Checkout(IConfiguration config)
        {
            _config = config;

        }
     


        [HttpPost("Paypal")]

        public async Task<ActionResult<string>> CreateOrder(CustomerOrder ord)
        {
            if (ord.Price <= 0) return Ok("Invalid");

            SandboxEnvironment environment = new SandboxEnvironment(_config["payPalClientId"], _config["payPalClientSecret"]);

            PayPalHttpClient client = new PayPalHttpClient(environment);
            var orderRequest = new OrderRequest()
            {
                CheckoutPaymentIntent = "CAPTURE",
                PurchaseUnits = new List<PurchaseUnitRequest>()
                {
                    new PurchaseUnitRequest()
                    {
                        AmountWithBreakdown = new AmountWithBreakdown()
                        {
                            CurrencyCode = "USD",
                            Value = ord.Price.ToString()
                        }
                    }
                }
            };
            var request = new OrdersCreateRequest();
            request.RequestBody(orderRequest);
            try
            {
                var response = await client.Execute(request);
                var order = response.Result<Order>();
                string orderId = JsonFormatter.ConvertToJson(order.Id);
                return orderId;
            }
            catch (HttpException ex)
            {
                var error = ex.GetBaseException() as PayPalHttp.HttpException;
                throw new Exception($"PayPal API Error: {error.StatusCode}, {error.Message}");
            }
        }


        [HttpPost("Stripe")]

        public async Task<ActionResult<string>> CreateOrderStripe(CustomerOrder customerOrder)
        {
            if (customerOrder.Price <= 0) return Ok("Invalid");


            StripeConfiguration.ApiKey = _config["stripeClientSecret"];
            var domain = _config["FrontEndDomain:Domain"];
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
                {

                  new SessionLineItemOptions
                  {
                    Quantity = 1,
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        Currency = "usd",
                        UnitAmount = customerOrder.Price*100,
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = "hoops",
                            Description = "thheh"
                        },
                    },
                  },

                },
                Mode = "payment",
                SuccessUrl = domain + "Success",
                CancelUrl = domain + "Error",
                AutomaticTax = new SessionAutomaticTaxOptions { Enabled = true },
            };
            var service = new SessionService();
            Session session = service.Create(options);
            string sessionUrl = session.Url.ToString();
            return sessionUrl;
        }
    }
}
