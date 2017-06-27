using MarieCurie.WebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarieCurie.WebMvc.Repositories
{
    interface IHelperServiceRepository
    {
        List<MyHelperService> getCenters();
    }
}
