using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GenericPS;

namespace WP18
{
    public class WP18PS: GenericPerfectScript
    {
        public WP18PS()
        {

            wp = new WordPerfect.PerfectScript();
            pf = new PerfectFit.PerfectScript();
            version = 18;
        }

    }
}
