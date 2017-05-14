using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementSystem.DbGateway
{
  public class ConnectionString
    {
      //public string DBConn = @"Data Source=KYOTO-PC13;Initial Catalog=AssetDB;Persist Security Info=True;User ID=sa;Password=SystemAdministrator;";

      //public string DBConn = @"Data Source=KYOTO-PC4;database=AssetDB;User=sa;Password=System@kyoto;Integrated Security=True;";
        public string DBConn = @"Data Source=tcp:KyotoServer,49172;Initial Catalog=AssetDBDemo;User=sa;Password=SystemAdministrator;Persist Security Info=True;";
      //public string DBConn = @"Data Source=JOHN-PC;Initial Catalog=AssetDB;Integrated Security=True;";
    }
}
