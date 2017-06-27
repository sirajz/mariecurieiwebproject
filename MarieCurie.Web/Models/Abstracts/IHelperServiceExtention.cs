using MarieCurie.Interview.Assets.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarieCurie.Web.Models.Abstracts
{
    public interface IHelperServiceExtention
    {
        bool checkOpenningHours(string dayOfWeek, int Hour);

        string nextOpenningHours(string dayOfWeek, int Hour);

    }
}
