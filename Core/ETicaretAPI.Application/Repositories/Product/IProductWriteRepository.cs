﻿using EticaretAPI.Domain.Entities;
using ETicaretAPI.Application.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IProductWriteRepository : IWriteRepository<Product>
    {
    }
}
