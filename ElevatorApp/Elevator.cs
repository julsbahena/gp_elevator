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
        public bool DoorIsOpen { get; set; }
        public string Direction { get; set; }

        public Elevator()
        {
            this.MaxFloor = 5;
            this.MinFloor = 1;
            this.DoorIsOpen = false;
            this.Floor = MinFloor;
            this.Direction = enumDirection.STOP;
            SetFloor(Helper.getRandom(5));
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

        public void DetermineDirection(int desiredFloor)
        {

            this.Direction = this.Floor == desiredFloor ? enumDirection.STOP : (this.Floor < desiredFloor ? enumDirection.UP : enumDirection.DOWN);
            MoveElevator(desiredFloor);
        }

        private void MoveElevator(int desiredFloor)
        {

            switch (Direction)
            {
                case enumDirection.UP:
                    while (Floor < desiredFloor)
                    {
                        SetFloor(Floor + 1);
                        getStatus();
                    }
                    Direction = enumDirection.STOP;
                    DoorIsOpen = true;
                    getStatus();

                    break;
                case enumDirection.DOWN:
                    while (Floor > desiredFloor)
                    {
                        SetFloor(Floor - 1);
                        getStatus();
                    }
                    Direction = enumDirection.STOP;
                    DoorIsOpen = true;
                    getStatus();
                    break;
                case enumDirection.STOP:
                    Console.WriteLine("Elevator is already on desired floor");
                    break;
                default:
                    break;
            }
        }

        public void getStatus()
        {
            Console.WriteLine("The elevator is on direction {0}, on the floor {1} and the door is {2}", this.Direction, this.Floor, this.DoorIsOpen? "opened" : "closed" );
        }
        //public int floor {get; set;}
    }

    public struct enumDirection
    {
        public const string UP = "UP";
        public const string DOWN = "DOWN";
        public const string STOP = "STOP";
    }

   

    


}
