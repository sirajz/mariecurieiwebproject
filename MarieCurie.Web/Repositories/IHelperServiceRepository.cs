using MarieCurie.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarieCurie.Web.Repositories
{
    interface IHelperServiceRepository
    {
        List<MyHelperService> getCenters();
    }
}
