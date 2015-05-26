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
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.IntegrationServices;

namespace app_Spaceman_Warehouse
{
    class extract_transform_load
    {
        public Package pkg = new Package();
        private Application app = new Application();
        string location = "";
        
        public Package proses_etl()
        {
            location = Environment.CurrentDirectory.ToString() + "\\Resources\\Package.dtsx";
            pkg = app.LoadPackage(@location, null);
            

            return pkg;;
        }
    }
}
