using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarieCurie.Interview.Assets.Model;

//namespace MarieCurie.Web.Models
//{
//    public class MyHelperService
//    {
//        //public bool Closed { get; set; }

//        public string checkOpenningHours(string dayOfWeek, int Hour, HelperService center)
//        {
//            if (dayOfWeek == DayOfWeek.Monday.ToString())
//            {

//                if (center.MondayOpeningHours[0] <= Hour
//                    && center.MondayOpeningHours[1] >= Hour)
//                    return $"panel panel-warning col-md-4";
//                else
//                    return $"panel panel-default col-md-4";

//            }

//            else if (dayOfWeek == DayOfWeek.Tuesday.ToString())
//            {

//                if (center.TuesdayOpeningHours[0] <= Hour
//                    && center.TuesdayOpeningHours[1] >= Hour)
//                    return $"panel panel-warning col-md-4";
//                else
//                    return $"panel panel-default col-md-4";
//            }

//            else if (dayOfWeek == DayOfWeek.Wednesday.ToString())
//            {

//                if (center.WednesdayOpeningHours[0] <= Hour
//                    && center.WednesdayOpeningHours[1] >= Hour)
//                    return $"panel panel-warning col-md-4";
//                else
//                    return $"panel panel-default col-md-4";
//            }

//            else //(dayOfWeek == DayOfWeek.Thursday.ToString()))
//            {

//                if (center.ThursdayOpeningHours[0] <= Hour
//                    && center.ThursdayOpeningHours[1] >= Hour)
//                    return $"panel panel-warning col-md-4";
//                else
//                    return $"panel panel-default col-md-4";
//            }
//        }


//        public string nextOpenningHours(string dayOfWeek, int Hour, HelperService center)
//        {
//            if (dayOfWeek == DayOfWeek.Monday.ToString())
//            {
//                if (center.MondayOpeningHours[0] <= Hour
//                    && center.MondayOpeningHours[1] >= Hour)
//                    return $"Open today until {center.MondayOpeningHours[1]}.00";
//                else
//                    return $"Reopens tomorrow {center.TuesdayOpeningHours[0]}.00";


//            }
//            else if (dayOfWeek == DayOfWeek.Tuesday.ToString())
//            {
//                if (center.TuesdayOpeningHours[0] <= Hour
//                    && center.TuesdayOpeningHours[1] >= Hour)
//                    return $"Open today until {center.TuesdayOpeningHours[1]}.00";
//                else
//                    return $"Reopens tomorrow {center.WednesdayOpeningHours[0]}.00";
//            }
//            else if (dayOfWeek == DayOfWeek.Wednesday.ToString())

//            {
//                if (center.WednesdayOpeningHours[0] <= Hour
//                     && center.WednesdayOpeningHours[1] >= Hour)
//                    return $"Open today until {center.WednesdayOpeningHours[1]}.00";
//                else
//                   return $"Reopens tomorrow {center.ThursdayOpeningHours[0]} .00";
//            }
//            else if (dayOfWeek == DayOfWeek.Thursday.ToString())

//            {
//                if (center.ThursdayOpeningHours[0] <= Hour
//                    && center.ThursdayOpeningHours[1] >= Hour)
//                    return $"Open today until {center.ThursdayOpeningHours[1]}.00";
//                else
//                    return $"Reopens tomorrow {center.FridayOpeningHours[0]} .00";
//            }
//            else if (dayOfWeek == DayOfWeek.Friday.ToString())
//            {
//                if (center.FridayOpeningHours[0] <= Hour
//                      && center.FridayOpeningHours[1] >= Hour)
//                    return $"Open today until {center.FridayOpeningHours[1]}.00";
//                else
//                    return $"Reopens tomorrow {center.SaturdayOpeningHours[0]} .00";

//            }
//            else if (dayOfWeek == DayOfWeek.Saturday.ToString())
//            {
//                if (center.SaturdayOpeningHours[0] <= Hour
//                      && center.SaturdayOpeningHours[1] >= Hour)
//                    return $"Open today until {center.SaturdayOpeningHours[1]}.00";
//                else
//                    //assumed closed on Saturdays/Mock data supports that
//                    return $"Reopens Monday {center.SundayOpeningHours[0]} .00";
//            }
//            else 
//            {
//                if (center.SundayOpeningHours[0] <= Hour
//                        && center.SundayOpeningHours[1] >= Hour)
//                    return $"Open today until {center.SundayOpeningHours[1]}.00";
//                else
//                    return $"Reopens Monday {center.MondayOpeningHours[0]} .00";

//            }
//        }
//    }
//}