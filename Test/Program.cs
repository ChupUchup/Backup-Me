using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = null;
            //do
            //{
            //    input = null;
            //    Console.WriteLine("=============================================");
            //    Console.Write("input : "); input = Console.ReadLine();
            //    ExecuteCommandSync(input);
            //} while (input.ToLower() != "exit");
            ExecuteCommandSync("cd /D C:/Users/Study/Documents/Java/ && javac Asal.java && java Asal");
            //ExecuteCommandSync("javac Asal.java");
            //ExecuteCommandSync("java Asal");
            Console.ReadKey();
        }

        private static void ExecuteCommandSync(object command)
        {
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);
                System.Diagnostics.ProcessStartInfo procStartInfo2 = new System.Diagnostics.ProcessStartInfo();

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.RedirectStandardError = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                result += proc.StandardError.ReadToEnd();
                
                // Display the command output.
                Console.WriteLine(result);
            }
            catch (Exception objException)
            {
                // Log the exception
                Console.WriteLine(objException.Message);
            }
        }
    }
}
