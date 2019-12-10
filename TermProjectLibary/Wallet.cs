﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectLibary
{
    public class Wallet
    {
        string name;
        string address;
        string email;
        string bankName;
        string cardType;
        int cardNumber;
        int merchantAccountID;
        public Wallet()
        {
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }
        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }
        public int CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        public int MerchantAccountID
        {
            get { return merchantAccountID; }
            set { merchantAccountID = value; }
        }
    }
}
