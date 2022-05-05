using EticaretAPI.Domain.Entities;
using ETicaretAPI.API.Repositories;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ETicaretDBContext context) : base(context)
        {
        }
    }
}
