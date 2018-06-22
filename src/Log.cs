using System;
using System.IO;
using System.Diagnostics;

namespace CalcNet
{
    public static class Log
    {
        public static void LogToFile (string file_name)
        {
            output_stream = new StreamWriter(file_name);
            Debug("Startup on {0}", DateTime.Now);
        }

        public static void Debug(string format, params object[] arguments)
        {
            emit("DEBUG", format, arguments);
        }

        private static StreamWriter output_stream = null;

        private static Stopwatch stopwatch = Stopwatch.StartNew();
        private static void emit(string channel, string format, params object[] arguments)
        {
            try
            {
                string formatted = String.Format(format, arguments);
                output_stream.WriteLine ("{0,7:F3} {1,6} {2}", stopwatch.ElapsedMilliseconds / 1000.0, channel, formatted);
                output_stream.Flush();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}", e);
                Console.WriteLine("Format    : {0}", format);
            }
        }
    }
}



