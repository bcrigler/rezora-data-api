﻿using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class EmsOpen
    {
        public int EventId { get; set; }
        public DateTimeOffset EventTimestamp { get; set; }
        public string Email { get; set; }
        public string Category { get; set; }
        public string EmailId { get; set; }
        public int UserId { get; set; }
        public int NewsletterId { get; set; }
        public int ContactId { get; set; }
        public int? EmsSourceId { get; set; }
    }
}
