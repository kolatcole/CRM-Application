﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRMSystem.Domains
{
    public class User:BaseEntity
    {
        public string Name { get; set; }
        public string Post { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }

    }
}
