using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp
{
    public class Elevator
    {
        public int Floor { get; set; }
        private int MaxFloor { get; set; }
        private int MinFloor { get; set; }
        public string Direction { get; set; }

        public Elevator(int _floor, string _direction)
        {

            this.Floor = _floor;
            this.Direction = _direction;
            this.MaxFloor = 5;
            this.MinFloor = 1;
        }

        private void Move() { 
        
        }

        private void getStatus()
        {
            Console.WriteLine("The elevetor is on direction {0}, on the Floor {1}", this.Direction, this.Floor);
        }
        //public int floor {get; set;}
    }

    public struct enumDirection
    {
        public const string UP = "up";
        public const string DOWN = "up";
    }
}
