using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarieCurie.Interview.Assets.Model;
using MarieCurie.Web.Models;

namespace MarieCurie.HelperServices.Repositories
{
    public static class HelperServicesMockRepository
    {

        public static List<HelperService> getCenters()
        {
            List<int> Mon = new List<int> { 8, 17 };
            List<int> Tue = new List<int> { 8, 17 };
            List<int> Wed = new List<int> { 9, 18 };

            List<HelperService> HlpServices = new List<HelperService>()
                {
                    new HelperService()
                        {
                            Title = "1 East London",
                            Description = "East Description, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non blandit neque, rutrum dictum nisi. Proin volutpat vulputate posuere.",
                            TelephoneNumber = "80808080",
                            MondayOpeningHours = Mon,
                            TuesdayOpeningHours = Tue,
                            WednesdayOpeningHours = Wed
                                                       
                        },

                    new HelperService()
                        {
                            Title = "2 East London",
                            Description = "East Description, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non blandit neque, rutrum dictum nisi. Proin volutpat vulputate posuere.",
                            TelephoneNumber = "80808080",
                            MondayOpeningHours = Mon,
                            TuesdayOpeningHours = Tue,
                            WednesdayOpeningHours = Wed

                        },

                    new HelperService()
                        {
                            Title = "3 East London",
                            Description = "East Description, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non blandit neque, rutrum dictum nisi. Proin volutpat vulputate posuere.",
                            TelephoneNumber = "80808080",
                            MondayOpeningHours = Mon,
                            TuesdayOpeningHours = Tue,
                            WednesdayOpeningHours = Wed

                        },

                    new HelperService()
                        {
                            Title = "1 West London",
                            Description = "West Description, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non blandit neque, rutrum dictum nisi. Proin volutpat vulputate posuere.",
                            TelephoneNumber = "80808080",
                            MondayOpeningHours = Mon,
                            TuesdayOpeningHours = Tue,
                            WednesdayOpeningHours = Wed

                        },
            new HelperService()
                        {
                            Title = "2 West London",
                            Description = "West Description, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non blandit neque, rutrum dictum nisi. Proin volutpat vulputate posuere.",
                            TelephoneNumber = "80808080",
                            MondayOpeningHours = Mon,
                            TuesdayOpeningHours = Tue,
                            WednesdayOpeningHours = Wed

                        },
             new HelperService()
                        {
                            Title = "3 West London",
                            Description = "West Description, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non blandit neque, rutrum dictum nisi. Proin volutpat vulputate posuere.",
                            TelephoneNumber = "80808080",
                            MondayOpeningHours = Mon,
                            TuesdayOpeningHours = Tue,
                            WednesdayOpeningHours = Wed

                        }
                };

            //int[] Mo = { 1, 2, 3 };
            //HelperService HlpServ = new HelperService();
            //var t = HlpServ.MondayOpeningHours;

            //List<int> Mo = new List<int>() { 2, 8 };
            //HelperService HlpServ = new HelperService();
            //HlpServ.MondayOpeningHours = Mo;
            //HlpServ.Title = "<a ref >";

            //HlpServices.Add(HlpServ);

            return HlpServices;

        }
    }
}