using System;
using System.Collections.Generic;

namespace TheFinalSheDriverTrainingHub.Models.DB
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public string InstructorFirstName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int InstructionRating { get; set; }
        public string Comments { get; set; }
        public int BehaviourRating { get; set; }
        public int PriceRating { get; set; }
        public string InstructorLastName { get; set; }
    }
}
