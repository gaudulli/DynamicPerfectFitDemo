using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GenericPS;
using WordPerfect;
using PerfectFit;

namespace WP17
{
    public class WP17PS : GenericPerfectScript
    {
        public WP17PS()
        {

            wp = new WordPerfect.PerfectScript();
            pf = new PerfectFit.PerfectScript();
            version = 17;
        }
    }
}
