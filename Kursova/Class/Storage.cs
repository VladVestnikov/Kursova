using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursova.Class;
using Kursova.Resources;

namespace Kursova.Class
{
    public class Storage
    {
        private static Storage? instance = null;
        private Storage()
        {

        }
        public static Storage? Instance
        {
            get
            {
                if (instance == null)
                    instance = new Storage();
                return instance;
            }
        }
        public Document? document { get; set; } = null;
        public DocumentTiacher? documentTiacher { get; set; } = null;
        public AdminForm? adminForm { get; set; } = null;
        public Form1? form1 { get; set; } = null;
        public HomeForm? homeForm { get; set; } = null;
        public HomeFormTiacher? homeFormTiacher { get; set; } = null;
        public Log? log { get; set; } = null;
        public LogForm? logForm { get; set; } = null;
    }
}
