﻿using MobilVize.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilVize.Core.Dtos
{
    public class UpdatePropertyDto
    {

        public Guid Id { get; set; }
        public string Value { get; set; }

    }
}