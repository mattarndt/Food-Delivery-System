using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectLibary
{
    public class RestaurantObj
    {
        private String restaurantId;
        private String password;
        private String email;
        private String address;
        private String logo;
        private String phone;
        private String restaurantName;

        public RestaurantObj()
        {

        }

        public RestaurantObj(String restaurantId, String password, String email, String address, String logo, String phone, String restaurantName)
        {
            this.restaurantId = restaurantId;
            this.password = password;
            this.email = email;
            this.address = address;
            this.logo = logo;
            this.phone = phone;
            this.restaurantName = restaurantName;
        }

        public String RestaurantId {
            get { return restaurantId; }
            set { restaurantId = value; }
        }
        public String getRestaurantId()
        {
            return this.restaurantId;
        }


        public String Password { get; set; }
        
        public String getPassword()
        {
            return this.password;
        }
        public String Email { get; set; }
        public String getEmail()
        {
            return this.email;
        }
        public String Address { get; set; }
        public String getAddress()
        {
            return this.address;
        }
        public String Logo { get; set; }
        public String getLogo()
        {
            return this.logo;
        }
        public String Phone { get; set; }
        public String getPhone()
        {
            return this.phone;
        }
        public String RestaurantName { get; set; }

        public String getRestaurantName()
        {
            return this.restaurantName;
        }
    }
}
