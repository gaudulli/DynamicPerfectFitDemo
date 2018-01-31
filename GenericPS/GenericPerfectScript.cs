using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPS
{
    public abstract class GenericPerfectScript
    {
        public dynamic wp { get; set; }  //WordPerfect.PerfectScript commands
        public dynamic pf { get; set; } //PerfectFit.Perfectscript commands
        public int version { get; set; }
    }
}
