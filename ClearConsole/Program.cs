using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;


namespace ClearConsole
{
    class Program
    {
       
            
       
            public static void Main()
            {
                try
                {
                    using (Process myProcess = Process.Start("Notepad.exe"))
                    {
                        // Display physical memory usage 5 times at intervals of 2 seconds.
                        for (int i = 0; i < 5; i++)
                        {
                            if (!myProcess.HasExited)
                            {
                                // Discard cached information about the process.
                                myProcess.Refresh();
                                // Print working set to console.
                                Console.WriteLine($"Physical Memory Usage: {myProcess.WorkingSet}");
                                // Wait 2 seconds.
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                break;
                            }
                        }

                        // Close process by sending a close message to its main window.
                        myProcess.CloseMainWindow();
                        // Free resources associated with process.
                        myProcess.Close();
                    }
                }
                catch (Exception e) when (e is Win32Exception || e is FileNotFoundException)
                {
                    Console.WriteLine("The following exception was raised: ");
                    Console.WriteLine(e.Message);
                }
            }
        }
    
}
   

