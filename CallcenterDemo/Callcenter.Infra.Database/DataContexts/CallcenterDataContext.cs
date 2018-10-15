using Callcenter.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callcenter.Infra.Database.DataContexts
{
    public class CallcenterDataContext : IDisposable
    {
        public SqlConnection Connection { get; set; }

        public CallcenterDataContext()
        {
            Connection = new SqlConnection(Settings.ConnectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}
