﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basy.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
