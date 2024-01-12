
using Data.Banco;
using Data.Domain;
using Data.Interface;

namespace Data.Repository
{
    public class PixOutRepository : Repository<Fornecedor>, IPixOutRepository

    {
        public PixOutRepository(AppDbContext context) : base(context)
        {
        }


        public async Task<Fornecedor> ObterId(Guid Id)
        {
            var Fornecedor = await ObterId(Id);

            return Fornecedor;
        }
    }
}
