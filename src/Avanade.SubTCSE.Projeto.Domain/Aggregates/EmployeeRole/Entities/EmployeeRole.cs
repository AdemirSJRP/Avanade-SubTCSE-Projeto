namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole
    {
        public string Id { get; init; }
        public string RoleName { get; init; }

        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

    }
}
