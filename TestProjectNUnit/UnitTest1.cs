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
                int requestFloor = getRandom(5);
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

        [TestCase(1, 1)]
        [TestCase(1, 4)]
        [TestCase(1, 5)]
        public void WetherLessEqualMax(int initialFloor, int requestFloor)
        {
            Elevator e = new Elevator(initialFloor);
            e.Move(requestFloor);
            Assert.LessOrEqual(e.Floor, 5);
        }

        private int getRandom(int max)
        {
            Random rnd = new Random();
            return rnd.Next(1, max + 1);
        }

        private int getRandom(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max + 1);
        }
    }
}