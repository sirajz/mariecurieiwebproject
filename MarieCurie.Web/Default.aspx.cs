using MarieCurie.HelperServices.Utilities;
using MarieCurie.Web.Models;
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
        public List<MyHelperService> getHelperServices()
        {
            HelperServicesMockRepo1 repo = new HelperServicesMockRepo1();
            return repo.getCenters();

        }

        public string getStyle(MyHelperService center)
        {
            string DayOfWeek = DateTime.Now.DayOfWeek.ToString();
            int Hour = DateTime.Now.Hour;

            if (center.checkOpenningHours(DayOfWeek, Hour))
                return $"panel panel-warning col-md-3";
            else
                return $"panel panel-default col-md-3";
        }
        public string getNextOpenning(MyHelperService center)
        {
            string DayOfWeek = DateTime.Now.DayOfWeek.ToString();
            int Hour = DateTime.Now.Hour;

            return center.nextOpenningHours(DayOfWeek, Hour);




        }
    }
}