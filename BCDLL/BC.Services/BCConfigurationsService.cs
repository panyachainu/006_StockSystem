using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC.Models;
using BC.DataAccess;
namespace BC.Services
{
    public class BCConfigurationsService : IDisposable
    {
        IBCConfigurationsController Db;
        public BCConfigurationsService(IBCConfigurationsController Db)
        {
            this.Db = Db;
        }
        public BCConfigurationsService(string Connstring)
            : this(new BCConfigurationsController(Connstring))
        {
        }

        public BCConfigurations GetBCConfig()
        {
            return Db.GetBCConfig();
        }
        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
