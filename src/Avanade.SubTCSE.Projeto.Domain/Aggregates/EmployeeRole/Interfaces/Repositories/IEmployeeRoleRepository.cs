using Avanade.SubTCSE.Projeto.Domain.Base.Repository;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repositories
{
    public interface IEmployeeRoleRepository : IBaseRepository<Entities.EmployeeRole, string>
    {
    }
}
