using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SecondVoyage
{
    class Logger
    {
        
        private static Logger instance;
        private Logger() { }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void Log(string msg) 
        {
            
        }

    }
}
