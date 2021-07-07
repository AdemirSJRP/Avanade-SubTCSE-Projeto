using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repositories;
using Avanade.SubTCSE.Projeto.Infra.Data.Repositores.Base;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Infra.Data.Repositores.EmployeeRole
{
    public class EmployeeRoleRepository
        : BaseRepository<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, string>
        , IEmployeeRoleRepository

    {
    }
}
