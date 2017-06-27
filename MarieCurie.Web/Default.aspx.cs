using MarieCurie.HelperServices.Utilities;
using MarieCurie.Interview.Assets.Model;
using MarieCurie.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarieCurie.Web
{
    public partial class _Default : Page
    {
        public List<HelperService> getHelperServices()
        {
            HelperServicesMockRepo1 repo = new HelperServicesMockRepo1();
            return repo.getCenters();

        }

        public string getStyle(HelperService center)
        {
            string DayOfWeek = DateTime.Now.DayOfWeek.ToString();
            int Hour = DateTime.Now.Hour;

            if (HelperServicesUtility.checkOpenningHours(DayOfWeek, Hour, center))
                return $"panel panel-warning col-md-3";
            else
                return $"panel panel-default col-md-3";
        }
        public string getNextOpenning(HelperService center)
        {
            string DayOfWeek = DateTime.Now.DayOfWeek.ToString();
            int Hour = DateTime.Now.Hour;

            return HelperServicesUtility.nextOpenningHours(DayOfWeek, Hour, center);




        }
    }
}