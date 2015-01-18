using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Crm.Data.Entities;

namespace Data
{
    class OperationAssistantContex: DbContext
    {
        public OperationAssistantContex(string connectionStringName): base(connectionStringName)
        {
        }

        public DbSet<Operation> Operations { set; get; }
    }
}
