namespace SWapi2.Classes.Logging
{
    ///<summary>
    ///    Class to log errors to a file
    ///</summary>
    internal static class JsonErrorLogging
    {
        ///<summary>
        ///    Static method to log errors to a file
        ///</summary>
        public static void WriteToLog(string message)
        {
            string projectDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string LogDirectory = $@"{projectDir}\Logs";
            if (!Directory.Exists(@$"{LogDirectory}"))
            {
                Directory.CreateDirectory(@$"{LogDirectory}");
            }
            string logPath = $@"{LogDirectory}\JsonErrorLog.txt";
            if (!File.Exists(@$"{logPath}"))
            {
                File.Create(@$"{logPath}");
            }
            StreamWriter sw = new StreamWriter(@$"{logPath}");
            sw.WriteLine(message);
            sw.Close();
        }
    }
}

