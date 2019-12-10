﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectLibary
{
    public class Transaction
    {
        private int transID = 0;
        private double amount = 0.0;
        private string type = "";
        private int cardNumber = 0;
        private int merchantID = 0;
        private string email = "";

        public Transaction()
        {

        }

        public int TransactionID
        {
            get { return transID; }
            set { transID = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        public int MerchantID
        {
            get { return merchantID; }
            set { merchantID = value; }
        }

        public int getTransactionID()
        {
            return this.transID;
        }
        public string getType()
        {
            return this.type;
        }
        public int getCardNumber()
        {
            return this.cardNumber;
        }
        public int getMerchantID()
        {
            return this.merchantID;
        }
        public string getEmail()
        {
            return this.email;
        }
    }
}
