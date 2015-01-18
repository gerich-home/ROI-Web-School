using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crm.Data.Entities;
using System.Data.Entity;

namespace Data
{
    class OperationRepository
    {
        private readonly OperationAssistantContex _contex;

        public OperationRepository(OperationAssistantContex contex)
        {
            _contex = contex;
        }

        public IEnumerable<Operation> GetAll()
        {
            return _contex.Operations;
        }

        public Operation Get(int operationId)
        {
            return _contex.Operations.Find(operationId);
        }

        public void Add(Operation operation)
        {
            _contex.Operations.Add(operation);
            _contex.SaveChanges();
        }

        public void Edit(Operation operation)
        {
            _contex.Entry(operation).State = EntityState.Modified;
            _contex.SaveChanges();
        }

        public void Delete(int operationId)
        {
            var operation = _contex.Operations.Find(operationId);
            if (operation != null)
            {
                _contex.Operations.Remove(operation);
                _contex.SaveChanges();
            }
        }
    }
}
