using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace Shortnr.Web.Data
{
    public class MyDbConfiguration : DbConfiguration
    {
        public MyDbConfiguration()
        {
            //https://www.entityframeworktutorial.net/entityframework6/code-based-configuration.aspx
            this.SetDefaultConnectionFactory(new System.Data.Entity.Infrastructure.SqlConnectionFactory());
        }
    }
}
