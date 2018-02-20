using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace 免监考C语言晋级考试系统
{
    class countdown
    {



        private static Timer aTimer = new Timer();
        public countdown()
        {
            aTimer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            aTimer.Interval = 1000;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            aTimer.Start();
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            CameraHelper.CaptureImage(@"E:\1");


        }






       
    }
}