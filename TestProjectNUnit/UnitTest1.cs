using ElevatorApp;

namespace TestProjectNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WetherFloorIsCorrect()
        {
            int initialFloor = 1;
            Elevator e = new Elevator(initialFloor);
            int current = e.Floor;
            //Assert.AreSame(initialFloor,current);
            Assert.That(current, Is.EqualTo(initialFloor));
        }

        [Test]
        public void WetherMoveIsCorrect()
        {
            Elevator e = new Elevator(1);
            for (int i = 1; i <= 5; i++)
            {
                int requestFloor = i;
                e.Move(requestFloor);
                Assert.That(e.Floor, Is.EqualTo(requestFloor));

            }
        }

        [Test]
        public void WetherHandleInvalidFloor()
        {
            Elevator e = new Elevator(1);
            for (int i = -2; i <= 0; i++)
            {
                int requestFloor = i;
                Assert.Throws<Exception>(() => e.Move(requestFloor));
            }
        }
    }
}