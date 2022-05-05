using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ETicaretAPI.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get {
                return "Server=DESKTOP-L41CNHP;Database=ETicaretAPI;Trusted_Connection=True;MultipleActiveResultSets=true;";
            }
        }
    }
}
