﻿using ozo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ozo.ViewModels
{
    public class PosaoViewModel
    {

        public IEnumerable<ViewPosao> Poslovi { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}
