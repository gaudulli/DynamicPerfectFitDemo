using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DynamicPerfectFitDemo
{
    class Program
    {

        static void Main(string[] args)
        {

            string dir = Directory.GetCurrentDirectory();
            FileInfo f = new FileInfo(dir);
            DirectoryInfo parent  = f.Directory.Parent;
            dir = parent.FullName;
            dir = string.Format(@"{0}\PF_Test.wcm", dir);

            WP_Handle hnd = new WP_Handle();

            hnd.wp.WPActivate();
            hnd.wp.KeyType("This is a test.\n");
            hnd.pf.ScriptName = dir;
            hnd.pf.VariableName = "vText";
            hnd.pf.SetPerfectScriptVariable("Corel needs to hire some more programmers!");
            hnd.pf.ScriptPlay();

            hnd.releaseScript();

        }
    }
}
