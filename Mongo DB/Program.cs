using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackExchange.Redis;

namespace Mongo_DB
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public class RedisDB
        {
            private static Lazy<ConnectionMultiplexer> _lazyConnection;

            public static ConnectionMultiplexer Connection
            {
                get
                {
                    return _lazyConnection.Value;
                }
            }

            static RedisDB()
            {
                _lazyConnection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect("localhost"));
            }

        }


    }
}
