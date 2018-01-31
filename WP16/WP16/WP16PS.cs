using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GenericPS;
using WordPerfect;

namespace WP16
{
    public class WP16PS: GenericPerfectScript
    {
        public WP16PS()
        {
            wp = new WordPerfect.PerfectScript();
            pf = new PerfectFit.PerfectScript();
            version = 16;
        }
    }

}

