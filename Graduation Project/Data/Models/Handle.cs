﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Graduation_Project.Data.Models
{
    public class Handle
    {
        public int handleId { get; set; }
        
        public string codeforcesHandle { get; set; }
        
        public string atCoderHandle { get; set; }
        
    }
}