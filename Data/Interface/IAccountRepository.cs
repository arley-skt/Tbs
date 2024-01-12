
using Data.Domain;

namespace Data.Interface
{
    public interface IAccountRepository:IRepository<Produto>
    {
        Task<Produto> ObterId(Guid Id);
        
    }
}
