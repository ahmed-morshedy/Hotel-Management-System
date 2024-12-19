using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolip
{
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();

        private Logger() { }

        public static Logger GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
            }
            return _instance;
        }

        public void Log(string message)
        {
            // Log to console (can be replaced with file or database logging)
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }

}
