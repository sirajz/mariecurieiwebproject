using MarieCurie.Interview.Assets.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarieCurie.Web.Repositories
{
    public class HelperServicesMockRepo1 : IHelperServiceRepository
    {
        public List<HelperService> getCenters()
        {
            //main services openning hours 
            List<int> Mon = new List<int> { 8, 17 };
            List<int> Tue = new List<int> { 9, 17 };
            List<int> Wed = new List<int> { 9, 18 };
            List<int> Thu = new List<int> { 9, 18 };
            List<int> Fri = new List<int> { 9, 18 };
            List<int> Sat = new List<int> { 9, 18 };

            //community services openning hours
            List<int> MonType2 = new List<int> { 17, 20 };
            List<int> TueType2 = new List<int> { 17, 20 };
            List<int> WedType2 = new List<int> { 17, 20 };
            List<int> ThuType2 = new List<int> { 17, 20 };
            List<int> FriType2 = new List<int> { 17, 20 };
            List<int> SatType2 = new List<int> { 17, 20 };


            List<HelperService> HlpServices = new List<HelperService>()
                {
                    new HelperService()
                        {
                            Title = "East London Helper Services",
                            Description = "East Description, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non blandit neque, rutrum dictum nisi. Proin volutpat vulputate posuere.",
                            TelephoneNumber = "0845 100 100",
                            MondayOpeningHours = Mon,
                            TuesdayOpeningHours = Tue,
                            WednesdayOpeningHours = Wed,
                            ThursdayOpeningHours = Thu,
                            FridayOpeningHours = Fri,
                            SaturdayOpeningHours = Sat

                        },

                    new HelperService()
                        {
                            Title = "North London Helper Services",
                            Description = "East Description, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non blandit neque, rutrum dictum nisi. Proin volutpat vulputate posuere.",
                            TelephoneNumber = "0845 100 101",
                            MondayOpeningHours = MonType2,
                            TuesdayOpeningHours = TueType2,
                            WednesdayOpeningHours = WedType2,
                            ThursdayOpeningHours = ThuType2,
                            FridayOpeningHours = FriType2,
                            SaturdayOpeningHours = SatType2

                        },

                    new HelperService()
                        {
                            Title = "West London Helper Services",

                            Description = "East Description, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non blandit neque, rutrum dictum nisi. Proin volutpat vulputate posuere.",
                            TelephoneNumber = "0845 100 102",
                            MondayOpeningHours = Mon,
                            TuesdayOpeningHours = TueType2,
                            WednesdayOpeningHours = Wed,

                        },

                    new HelperService()
                        {
                            Title = "Essex Helper Services",
                            Description = "West Description, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non blandit neque, rutrum dictum nisi. Proin volutpat vulputate posuere.",
                            TelephoneNumber = "0845 100 103",
                            MondayOpeningHours = Mon,
                            TuesdayOpeningHours = Tue,
                            WednesdayOpeningHours = Wed,
                            ThursdayOpeningHours = Thu,
                            FridayOpeningHours = Fri,
                            SaturdayOpeningHours = Sat


                        },
            new HelperService()
                        {
                            Title = "Surrey Helper Services",
                            Description = "West Description, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non blandit neque, rutrum dictum nisi. Proin volutpat vulputate posuere.",
                            TelephoneNumber = "80808080",
                            MondayOpeningHours = Mon,
                            TuesdayOpeningHours = Tue,
                            WednesdayOpeningHours = Wed,
                            ThursdayOpeningHours = Thu,
                            FridayOpeningHours = Fri,
                            SaturdayOpeningHours = Sat

                        },
             new HelperService()
                        {
                            Title = "Kent Helper Services",
                            Description = "West Description, Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed non blandit neque, rutrum dictum nisi. Proin volutpat vulputate posuere.",
                            TelephoneNumber = "0845 45455",
                            MondayOpeningHours = MonType2,
                            TuesdayOpeningHours = TueType2,
                            WednesdayOpeningHours = WedType2,
                            ThursdayOpeningHours = ThuType2,
                            FridayOpeningHours = FriType2,
                            SaturdayOpeningHours = SatType2
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