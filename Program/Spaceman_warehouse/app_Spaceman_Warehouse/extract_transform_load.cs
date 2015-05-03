using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.SqlServer.Dts.Runtime;

namespace app_Spaceman_Warehouse
{
    class extract_transform_load
    {
        private Package pkg = new Package();
        Application app = new Application();
        DTSExecResult res = new DTSExecResult();
        string location = "";
        public string proses_etl()
        {
            location = Environment.CurrentDirectory.ToString() + "\\Resources\\Package.dtsx";
            
            pkg = app.LoadPackage(@location, null);
            res = pkg.Execute();
            return res.ToString().ToLower();
        }
    }
}
