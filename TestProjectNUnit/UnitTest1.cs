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
        public void WetherMoveIsCorrect()
        {
            Elevator e = new Elevator();
            for (int i = 1; i <= 5; i++)
            {
                int requestFloor = Helper.getRandom(5);
                e.DetermineDirection(requestFloor);
                Assert.That(e.Floor, Is.EqualTo(requestFloor));

            }
        }

        [Test]
        public void WetherHandleInvalidFloor()
        {
            Elevator e = new Elevator();
            for (int i = -2; i <= 0; i++)
            {
                int requestFloor = i;
                Assert.Throws<Exception>(() => e.DetermineDirection(requestFloor));
            }
        }

        [TestCase(1, 1)]
        [TestCase(1, 4)]
        [TestCase(1, 5)]
        public void WetherSequenceIsCorrect(int firstFloor, int secondFloor)
        {
            Elevator e = new Elevator();
            Outside outRequest = new Outside();
            Inside insideRequest = new Inside();
            outRequest.PickMeUp(firstFloor, e);
            Assert.That(e.Floor, Is.EqualTo(firstFloor));

            insideRequest.GoToFloor(secondFloor,e);
            Assert.That(e.Floor, Is.EqualTo(secondFloor));

        }

        
    }
}