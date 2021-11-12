using System;

namespace date_test
{
    class Program
    {
        private static object label6;

        static void Main(string[] args)
        {
            System.Windows.Forms.Timer monTimer = new System.Windows.Forms.Timer();
            monTimer.Tick += (sender, eventArgs) => { label6.Text = DateTime.Now.ToString(); };
            monTimer.Interval = 100;
            monTimer.Start();
        }
            
         
        
    }
}
