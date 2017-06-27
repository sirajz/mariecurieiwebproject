using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarieCurie.Interview.Assets.Model;
using MarieCurie.Web.Models.Abstracts;
using MarieCurie.HelperServices.Utilities;

namespace MarieCurie.Web.Models
{
    public class MyHelperService : HelperService, IHelperServiceExtention
    {

        public bool checkOpenningHours(string dayOfWeek, int Hour)
        {
            return HelperServicesUtility.checkOpenningHours(dayOfWeek, Hour, this);

        }

        public string nextOpenningHours(string dayOfWeek, int Hour)
        {
            return HelperServicesUtility.nextOpenningHours(dayOfWeek, Hour, this);
        }
    }
}