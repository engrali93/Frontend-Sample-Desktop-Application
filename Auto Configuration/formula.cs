using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Auto_Configuration
{
    class formula
    {
        public void progressbar_result(IProgress<int> progress)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(1200);
                progress.Report(i);
            }
            
                
            
            
        }
    }
}
