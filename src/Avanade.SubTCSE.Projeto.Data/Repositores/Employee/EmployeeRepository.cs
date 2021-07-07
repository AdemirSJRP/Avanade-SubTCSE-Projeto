using Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Repositories;
using Avanade.SubTCSE.Projeto.Infra.Data.Repositores.Base;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Infra.Data.Repositores.Employee
{
    public class EmployeeRepository
        : BaseRepository<Domain.Aggregates.Employee.Entities.Employee, string>
        , IEmployeeRepository
    {

        public async Task<Domain.Aggregates.Employee.Entities.Employee> AddEmployee(Domain.Aggregates.Employee.Entities.Employee employee)
        {
            throw new System.NotImplementedException();
        }

    }
}
