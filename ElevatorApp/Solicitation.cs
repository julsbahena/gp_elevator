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
        void GoToFloor(int desiredFloor, Elevator e);

    }

    //public class InsideSolicitation : ISolicitation
    //{

    //    //this.validFloors = new List<int>(new int[1]);
    //    //public validF
    //    public List<int> validFloors { get; set; }
    //    public void GoToFloor(int floor)
    //    {
    //        //return floor;
    //    }

    //    public void TakeMeToFloor(int desiredFloor, Elevator e)
    //    {
    //        if (this.validFloors.Contains(desiredFloor))
    //        {
    //            e.Move(desiredFloor);
    //        }
    //        else
    //        {
    //            throw new Exception("Floor requested not valid");
    //        }
    //    }

    //    public void PickMeAtFloor(int desiredFloor, Elevator e)
    //    {
    //        if (this.validFloors.Contains(desiredFloor))
    //        {
    //            e.Move(desiredFloor);
    //        }
    //        else
    //        {
    //            throw new Exception("Floor requested not valid");
    //        }
    //    }

    //    public InsideSolicitation()
    //    {
    //        this.validFloors = new List<int>() { 1, 2, 3, 4, 5 };
    //    }
    //}

    //public class OutsideSolicitation : ISolicitation
    //{
    //    public OutsideSolicitation()
    //    {
    //        this.validFloors = new List<int>() { 1, 2, 3, 4, 5 };
    //    }

    //    public List<int> validFloors { get; set; }
    //    public void GoToFloor(int floor)
    //    {
    //        //return floor;
    //    }


    //    public void PickMeAtFloor(int desiredFloor, Elevator e)
    //    {
    //        if (this.validFloors.Contains(desiredFloor))
    //        {
    //            e.Move(desiredFloor);
    //        }
    //        else
    //        {
    //            throw new Exception("Floor requested not valid");
    //        }
    //    }
    //}

    public class Solicitation : ISolicitation
    {
        public List<int> validFloors { get; set; }
        public void GoToFloor(int desiredFloor, Elevator e)
        {
            if (this.validFloors.Contains(desiredFloor))
            {
                e.Move(desiredFloor);
            }
            else
            {
                throw new Exception("Floor requested not valid");
            }
        }

        public void PickMeUp(int desiredFloor, Elevator e)
        {
            if (this.validFloors.Contains(desiredFloor))
            {
                e.Move(desiredFloor);
            }
            else
            {
                throw new Exception("Floor requested not valid");
            }
        }
    }

    public class Outside : Solicitation
    {
        public Outside()
        {
            this.validFloors = new List<int>() { 1, 2, 3, 4, 5 };
        }
        //public void GoToFloor(int floor)
        //{
        //    //return floor;
        //}


    }

    public class Inside : Solicitation
    {
        public Inside()
        {
            this.validFloors = new List<int>() { 1, 2, 3, 4, 5 };
        }
        //public void GoToFloor(int floor)
        //{
        //    //return floor;
        //}


    }





}
