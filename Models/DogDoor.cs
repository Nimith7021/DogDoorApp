using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace DogDoorApp.Models
{
    internal class DogDoor
    {
        private bool open;
        private System.Timers.Timer timer;

        public DogDoor()
        {
            open = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens");
            open = true;

            timer = new System.Timers.Timer(5000);
            timer.Elapsed += ClosingOperation;
            timer.AutoReset = false;
            timer.Enabled = true;
        }

        public void Close() {

            Console.WriteLine("The dog door Closes");
            open = false;
        }

        public bool IsOpen() {
        
            return open;
        }


        public void ClosingOperation(object? sender, ElapsedEventArgs e)
        {
            Close();
        }

    }
}
