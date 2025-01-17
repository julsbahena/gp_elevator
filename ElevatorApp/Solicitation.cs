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
        int SetFloor(int floor);

    }

    public class InsideSolicitation : ISolicitation
    {

        //this.validFloors = new List<int>(new int[1]);
        //public validF
        public List<int> validFloors { get; set; }
        public int SetFloor(int floor)
        {
            return floor;
        }

        public InsideSolicitation()
        {
            this.validFloors = new List<int>() { 1, 2, 3, 4, 5 };
        }
    }

    public class OutsideSolicitation : ISolicitation
    {

        //this.validFloors = new List<int>(new int[1]);
        //public validF
        public List<int> validFloors { get; set; }
        public int SetFloor(int floor)
        {
            return floor;
        }

        public OutsideSolicitation()
        {
            this.validFloors = new List<int>() { 1, 2, 3, 4, 5 };
        }

        public void PickMeAtFloor(int desiredFloor, Elevator e)
        {
            if (this.validFloors.Contains(desiredFloor))
            {
                e.Move(desiredFloor);
            }
            else
            {
                throw new Exception("OutsideSolicitation floor requested not valid");
            }
        }
    }
}
