using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GenericPS;
using PerfectScriptFactory;

using System.Runtime.InteropServices;

namespace DynamicPerfectFitDemo
{
    class WP_Handle
    {


        public WordPerfect.PerfectScript wp;
        public PerfectFit.PerfectScript pf;

        //public dynamic wp { get; set; }
        //public dynamic pf { get; set; }
        //GenericPerfectScript GPS;

        public WP_Handle()
        {
            initPerfectScript();
        }

        public void initPerfectScript()
        {
            if (wp == null)
            {
                wp = new WordPerfect.PerfectScript();
                pf = new PerfectFit.PerfectScript();
            }
        }


        //public void initPerfectScript()
        //{
        //    if (wp == null)
        //    {
        //        GPS = MakePerfectScriptObject.getPS();
        //        wp = GPS.wp;
        //        pf = GPS.pf;
        //    }
        //}

        public void releaseScript()
        {
            if (wp == null)
            {
                initPerfectScript();    // it seems silly to create PS just to destroy it, but this is just in 
                                        // case PS is already null, but for some reason has not been released as a COM object                             
            }
            //wp.WPActivate();
            Marshal.ReleaseComObject(pf);
            Marshal.ReleaseComObject(wp);

            wp = null;
            pf = null;

        }

    

}
}
