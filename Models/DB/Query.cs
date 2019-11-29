using System;
using System.Collections.Generic;

namespace TheFinalSheDriverTrainingHub.Models.DB
{
    public partial class Query
    {
        public int QueryId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
