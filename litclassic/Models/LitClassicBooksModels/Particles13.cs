﻿using System;
using System.Collections.Generic;

namespace litclassic.LitClassicBooksModels
{
    public partial class Particles13
    {
        public int Id { get; set; }
        public int Idparticles { get; set; }
        public DateTime? UpdateDateTime { get; set; }

        public virtual Particles IdparticlesNavigation { get; set; }
    }
}
