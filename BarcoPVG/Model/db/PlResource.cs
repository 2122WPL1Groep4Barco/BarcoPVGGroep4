﻿using System;
using System.Collections.Generic;

namespace BarcoPVG.Model.db
{
    public partial class PlResource
    {
        public PlResource()
        {
            PlPlanningsKalenders = new HashSet<PlPlanningsKalender>();
            PlResourcesDivisions = new HashSet<PlResourcesDivision>();
        }

        public int Id { get; set; }
        public string? Naam { get; set; }
        public string? KleurRgb { get; set; }
        public string? KleurHex { get; set; }

        public virtual ICollection<PlPlanningsKalender> PlPlanningsKalenders { get; set; }
        public virtual ICollection<PlResourcesDivision> PlResourcesDivisions { get; set; }
    }
}
