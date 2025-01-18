using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp
{
    interface ISolicitation
    {

        List<int> validFloors { get; set; }
        public void RequestElevatorMoveToFloor(int desiredFloor, Elevator e);

    }

   
    public class Solicitation : ISolicitation
    {
        public List<int> validFloors { get; set; }
        //public void GoToFloor(int desiredFloor, Elevator e)
        //{
        //    RequestElevatorMoveToFloor(desiredFloor, e);
        //}

        public void RequestElevatorMoveToFloor(int desiredFloor, Elevator e)
        {
            Console.WriteLine("--> Request to go to floor {0}", desiredFloor.ToString());

            if (this.validFloors.Contains(desiredFloor))
            {
                e.DetermineDirection(desiredFloor);
            }
            else
            {
                throw new Exception("Floor requested not valid");
            }
        }

        //public void PickMeUp(int desiredFloor, Elevator e)
        //{
        //    RequestElevatorMoveToFloor(desiredFloor, e);
        //}
    }

    public class Outside : Solicitation
    {
        public Outside()
        {
            this.validFloors = new List<int>() { 1, 2, 3, 4, 5 };
        }

        public void PickMeUp(int desiredFloor, Elevator e)
        {
            RequestElevatorMoveToFloor(desiredFloor, e);
        }


    }

    public class Inside : Solicitation
    {
        public Inside()
        {
            this.validFloors = new List<int>() { 1, 2, 3, 4, 5 };
        }

        public void GoToFloor(int desiredFloor, Elevator e)
        {
            RequestElevatorMoveToFloor(desiredFloor, e);
        }

    }





}
