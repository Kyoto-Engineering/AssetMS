using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementSystem.UI
{
    class Vendor
    {
        private string name;
        private string phone;
        private string email;
        private string weburl;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Weburl
        {
            get { return weburl; }
            set { weburl = value; }
        }

    }
}
