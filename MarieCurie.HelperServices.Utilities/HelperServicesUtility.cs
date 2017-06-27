using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarieCurie.Interview.Assets.Model;

namespace MarieCurie.HelperServices.Utilities
{
    public static class HelperServicesUtility 
    {
        public static bool checkOpenningHours(string dayOfWeek, int Hour, HelperService center)
        {
            if (dayOfWeek == DayOfWeek.Monday.ToString())
            {

                if (center.MondayOpeningHours[0] <= Hour
                    && center.MondayOpeningHours[1] >= Hour)
                    return true;
                else
                    return false;

            }

            else if (dayOfWeek == DayOfWeek.Tuesday.ToString())
            {

                if (center.TuesdayOpeningHours[0] <= Hour
                    && center.TuesdayOpeningHours[1] >= Hour)
                    return true;
                else
                    return false;
            }

            else if (dayOfWeek == DayOfWeek.Wednesday.ToString())
            {

                if (center.WednesdayOpeningHours[0] <= Hour
                    && center.WednesdayOpeningHours[1] >= Hour)
                    return true;
                else
                    return false;
            }

            else if (dayOfWeek == DayOfWeek.Thursday.ToString())
            {

                if (center.ThursdayOpeningHours[0] <= Hour
                    && center.ThursdayOpeningHours[1] >= Hour)
                    return true;
                else
                    return false;
            }
            else if (dayOfWeek == DayOfWeek.Friday.ToString())
            {

                if (center.FridayOpeningHours[0] <= Hour
                    && center.FridayOpeningHours[1] >= Hour)
                    return true;
                else
                    return false;
            }
            else if (dayOfWeek == DayOfWeek.Saturday.ToString())
            {

                if (center.SaturdayOpeningHours[0] <= Hour
                    && center.SaturdayOpeningHours[1] >= Hour)
                    return true;
                else
                    return false;
            }

            else // (dayOfWeek == DayOfWeek.Sunday.ToString())
            {

                if (center.SundayOpeningHours[0] <= Hour
                    && center.SundayOpeningHours[1] >= Hour)
                    return true;
                else
                    return false;
            }
        }


        public static string nextOpenningHours(string dayOfWeek, int Hour, HelperService center)
        {
            if (dayOfWeek == DayOfWeek.Monday.ToString())
            {
                var openUntil = center.MondayOpeningHours[1] >= 12 ?
                         $"{center.MondayOpeningHours[1] - 12}.00 pm" : $"{center.MondayOpeningHours[1]}.00 am";

                var openNext = center.TuesdayOpeningHours[0] >= 12 ? 
                    $"{center.TuesdayOpeningHours[0] - 12}.00 pm" : $"{center.TuesdayOpeningHours[0]}.00 am";

                if (center.MondayOpeningHours[0] <= Hour
                    && center.MondayOpeningHours[1] >= Hour)
                    return $"Open today until {openUntil}";
                else
                    return $"Reopens tomorrow {openNext}";


            }
            else if (dayOfWeek == DayOfWeek.Tuesday.ToString())
            {
                var openUntil = center.TuesdayOpeningHours[1] >= 12 ?
                         $"{center.TuesdayOpeningHours[1] - 12}.00 pm" : $"{center.TuesdayOpeningHours[1]}.00 am";

                var openNext = center.WednesdayOpeningHours[0] >= 12 ?
                    $"{center.WednesdayOpeningHours[0] - 12}.00 pm" : $"{center.WednesdayOpeningHours[0]}.00 am";


                if (center.TuesdayOpeningHours[0] <= Hour
                    && center.TuesdayOpeningHours[1] >= Hour)
                    return $"Open today until {openUntil}";
                else
                    return $"Reopens tomorrow {openNext}";
            }
            else if (dayOfWeek == DayOfWeek.Wednesday.ToString())

            {
                var openUntil = center.WednesdayOpeningHours[1] >= 12 ?
                         $"{center.WednesdayOpeningHours[1] - 12}.00 pm" : $"{center.WednesdayOpeningHours[1]}.00 am";

                var openNext = center.ThursdayOpeningHours[0] >= 12 ?
                    $"{center.ThursdayOpeningHours[0] - 12}.00 pm" : $"{center.ThursdayOpeningHours[0]}.00 am";

                         if (center.WednesdayOpeningHours[0] <= Hour
                     && center.WednesdayOpeningHours[1] >= Hour)
                    return $"Open today until {openUntil}";
                else
                    return $"Reopens tomorrow {openNext}";
            }
            else if (dayOfWeek == DayOfWeek.Thursday.ToString())

            {
                var openUntil = center.ThursdayOpeningHours[1] >= 12 ?
                         $"{center.ThursdayOpeningHours[1] - 12}.00 pm" : $"{center.ThursdayOpeningHours[1]}.00 am";

                var openNext = center.FridayOpeningHours[0] >= 12 ?
                    $"{center.FridayOpeningHours[0] - 12}.00 pm" : $"{center.FridayOpeningHours[0]}.00 am";

                if (center.ThursdayOpeningHours[0] <= Hour
                    && center.ThursdayOpeningHours[1] >= Hour)
                    return $"Open today until {openUntil}";
                else
                    return $"Reopens tomorrow {openNext}";
            }
            else if (dayOfWeek == DayOfWeek.Friday.ToString())
            {
                var openUntil = center.FridayOpeningHours[1] >= 12 ?
                         $"{center.FridayOpeningHours[1] - 12}.00 pm" : $"{center.FridayOpeningHours[1]}.00 am";

                var openNext = center.SaturdayOpeningHours[0] >= 12 ?
                    $"{center.SaturdayOpeningHours[0] - 12}.00 pm" : $"{center.SaturdayOpeningHours[0]}.00 am";

                if (center.FridayOpeningHours[0] <= Hour
                      && center.FridayOpeningHours[1] >= Hour)
                    return $"Open today until {openUntil}";
                else
                    return $"Reopens tomorrow {openNext}";

            }
            else if (dayOfWeek == DayOfWeek.Saturday.ToString())
            {
                var openUntil = center.SaturdayOpeningHours[1] >= 12 ?
                         $"{center.SaturdayOpeningHours[1] - 12}.00 pm" : $"{center.SaturdayOpeningHours[1]}.00 am";

                var openNext = center.MondayOpeningHours[0] >= 12 ?
                    $"{center.MondayOpeningHours[0] - 12}.00 pm" : $"{center.MondayOpeningHours[0]}.00 am";

                if (center.SaturdayOpeningHours[0] <= Hour
                      && center.SaturdayOpeningHours[1] >= Hour)
                    return $"Open today until {openUntil}";
                else
                    //assumed closed on Sunday/Mock data supports that
                    return $"Reopens Monday {openNext}";
            }
            else
            {
                var openUntil = center.SundayOpeningHours[1] >= 12 ?
                         $"{center.SundayOpeningHours[1] - 12}.00 pm" : $"{center.SundayOpeningHours[1]}.00 am";

                var openNext = center.MondayOpeningHours[0] >= 12 ?
                    $"{center.MondayOpeningHours[0] - 12}.00 pm" : $"{center.MondayOpeningHours[0]}.00 am";

                if (center.SundayOpeningHours[0] <= Hour
                        && center.SundayOpeningHours[1] >= Hour)
                    return $"Open today until {openUntil}";
                else
                    //assumed closed on Sunday/Mock data supports that
                    return $"Reopens Monday {openNext}";
            }
        }
    }
}
