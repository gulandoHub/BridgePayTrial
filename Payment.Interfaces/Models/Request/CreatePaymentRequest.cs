﻿namespace Payment.Interfaces.Models.Request
{
    public class CreatePaymentRequest
    {
        public string OrderId { get; set; }

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public string Country { get; set; }

        public string CardNumber { get; set; }

        public string CardHolder { get; set; }

        public string CardExpiryDate { get; set; }

        public int Cvv { get; set; }
    }
}
