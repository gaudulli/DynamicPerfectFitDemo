﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GenericPS;
using WordPerfect;
//using PerfectFit;

namespace WP14
{
    public class WP14PS : GenericPerfectScript
    {
        public WP14PS()
        {
            perfectScript = new WordPerfect.PerfectScript();
            //perfectFit = new PerfectFit.PerfectScript();
            version = 14;
        }

    }
}
