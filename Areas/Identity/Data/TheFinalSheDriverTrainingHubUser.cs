using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TheFinalSheDriverTrainingHub.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the TheFinalSheDriverTrainingHubUser class
    public class TheFinalSheDriverTrainingHubUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        [PersonalData]
        public string Suburb { get; set; }
        [PersonalData]
        public string City { get; set; }
        [PersonalData]
        public string PhoneNumber { get; set; }
        [PersonalData]
        public string LicenseNumber { get; set; }
        [PersonalData]
        public int LicenseVersion { get; set; }
        [PersonalData]
        public bool IsEndorsed { get; set; }
        [PersonalData]
        public bool Monday { get; set; }
        [PersonalData]
        public bool Tuesday { get; set; }
        [PersonalData]
        public bool Wednesday { get; set; }
        [PersonalData]
        public bool Thursday { get; set; }
        [PersonalData]
        public bool Friday { get; set; }
        [PersonalData]
        public bool Saturday { get; set; }
        [PersonalData]
        public bool Sunday { get; set; }
        [PersonalData]
        public string AvailableTimes { get; set; }
        [PersonalData]
        public double PricePerHour { get; set; }
        [PersonalData]
        public string AboutInstructor { get; set; }
        [PersonalData]
        public string ImageFileName { get; set; }
        [PersonalData]
        public bool isAuthorised { get; set; }
        [PersonalData]
        public bool isAdmin { get; set; }
    }
}
