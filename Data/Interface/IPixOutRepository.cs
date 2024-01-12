

using Data.Domain;

namespace Data.Interface
{
    public interface IPixOutRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterId(Guid Id);
    }
}
