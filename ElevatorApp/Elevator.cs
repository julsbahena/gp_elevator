using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public Elevator(int _floor)
        {
            this.MaxFloor = 5;
            this.MinFloor = 1;
            this.Floor = MinFloor;
            this.Direction = enumDirection.STOP;
            SetFloor(_floor);
        }

        private void SetFloor(int desiredFloor)
        {
            //get previous
            if (this.Floor != desiredFloor)
            {

                int validFloor = this.MinFloor;
                if (desiredFloor >= this.MinFloor && desiredFloor <= this.MaxFloor)
                {
                    this.Floor = desiredFloor;
                }
                else
                {
                    throw new Exception("Floor out of range");
                }
            }
        }

        public void Move(int desiredFloor)
        {
            Console.WriteLine("-- Move to floor {0}", desiredFloor.ToString());

            this.Direction = this.Floor == desiredFloor ? enumDirection.STOP : (this.Floor < desiredFloor ? enumDirection.UP : enumDirection.DOWN);
            if (this.Direction == enumDirection.UP)
            {
                while (this.Floor < desiredFloor)
                {
                    SetFloor(this.Floor + 1);
                    getStatus();
                }
                this.Direction = enumDirection.STOP;
                getStatus();

            }
            else if (this.Direction == enumDirection.DOWN)
            {
                while (this.Floor > desiredFloor)
                {
                    SetFloor(this.Floor - 1);
                    getStatus();
                }
                this.Direction = enumDirection.STOP;
                getStatus();
            }
        }

        public void getStatus()
        {
            Console.WriteLine("The elevator is on direction {0}, on the floor {1}", this.Direction, this.Floor);
        }
        //public int floor {get; set;}
    }

    public struct enumDirection
    {
        public const string UP = "up";
        public const string DOWN = "down";
        public const string STOP = "stop";
    }

    
}
