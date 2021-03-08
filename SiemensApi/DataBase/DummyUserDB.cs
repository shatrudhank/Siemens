using SiemensApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiemensApi.DataBase
{
    public static  class DummyUserDB
    {
       public  static List<UserModel> dummUser = new List<UserModel>()
                  {
                        new UserModel(){UserId="SHATRUDHAN",Password="12345678",OrgCategory="NORMAL"},
                        new UserModel(){UserId="SIEMENS",Password="12345678",OrgCategory="PRIVILAGED"}
                  }
            ;

    }
}
