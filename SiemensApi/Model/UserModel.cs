using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiemensApi.Model
{
    public class UserModel
    {
        private string userId;
        private string password;
        private string orgCategory;

        public string UserId
        {
            get { return userId; }
            set { this.userId = value; }
        }
        public string OrgCategory
        {
            get { return orgCategory; }
            set { this.orgCategory = value; }
        }

        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }
    }
}
