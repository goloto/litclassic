﻿using System;
using System.Collections.Generic;

namespace litclassic.LitClassicBooksModels
{
    public partial class Particles43
    {
        public int Id { get; set; }
        public int Idparticles { get; set; }
        public DateTime? UpdateDateTime { get; set; }

        public virtual Particles IdparticlesNavigation { get; set; }
    }
}
