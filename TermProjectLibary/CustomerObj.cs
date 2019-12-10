using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectLibary
{
    public class CustomerObj
    {
        private String customerId;
        private String password;
        private String deliveryAddress;
        private String billingAddress;
        private String emailAddress;
        private String name;

        public CustomerObj(String customerId, String password, String deliveryAddress, String billingAddress, String emailAddress, String name)
        {
            this.customerId = customerId;
            this.password = password;
            this.deliveryAddress = deliveryAddress;
            this.billingAddress = billingAddress;
            this.emailAddress = emailAddress;
            this.name = name;
        }

        public CustomerObj()
        {

        }

        public String CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public String getCustomerId()
        {
            return this.customerId;
        }
        public String Password { get; set; }
        public String getPassword()
        {
            return this.password;
        }
        public String DeliveryAddress { get; set; }
        public String getDeliveryAddress()
        {
            return this.DeliveryAddress;
        }
        public String BillingAddress { get; set; }
        public String getBillingAddress()
        {
            return this.BillingAddress;
        }

        public String EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public String getEmailAddress()
        {
            return this.EmailAddress;
        }
        public String Name { get; set; }
        public String getName()
        {
            return this.Name;
        }
    }
}
