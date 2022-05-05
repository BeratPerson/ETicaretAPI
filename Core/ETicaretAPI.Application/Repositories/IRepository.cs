using EticaretAPI.Domain.Entities;
using EticaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositorys
{
    public interface IRepository<T> where T : BaseEntitiy
    {
        DbSet<T> Table { get; }
    }
}
