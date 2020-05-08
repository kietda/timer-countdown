using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace PhanMemAutoShutdown2
{
    class FirstThread
    {
        public int mParameter = 0;
        // Non-Static method 
        public void thread()
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Exclamation.wav");
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Ringin.wav");
            //for (int i = 1; i <= (int)nudNumberOfRings.Value; i++)
            for (int i = 1; i <= mParameter; i++)
            {
                simpleSound.Play();
                Thread.Sleep(1000);
            }
            mParameter = 0;
        }
    }
}
