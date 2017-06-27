using MarieCurie.Interview.Assets.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarieCurie.Web.Repositories
{
    interface IHelperServiceRepository
    {
        List<HelperService> getCenters();
    }
}
