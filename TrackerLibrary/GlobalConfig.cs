using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections( bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Create the Sql Connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                //TODO - Create the text Connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
