﻿using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class SirotherFiles
    {
        public int Id { get; set; }
        public string Doctype { get; set; }
        public byte[] Document { get; set; }
        public byte? Processed { get; set; }
        public string Guid { get; set; }
    }
}
