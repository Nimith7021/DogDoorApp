﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace DogDoorApp.Models
{
    internal class Remote
    {
        private DogDoor door;
       

        public Remote(DogDoor door)
        {

            this.door = door;    
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the Remote control button ....");
            if (door.IsOpen())
                door.Close();
            else
            {
                door.Open();
                
            }
        }

        






    }
}
