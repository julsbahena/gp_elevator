using ElevatorApp;


try
{
    //maybe random position
    Elevator mainElevator = new Elevator();
    mainElevator.getStatus();
    Outside outRequest = new Outside();
    Inside insideRequest = new Inside();
    outRequest.PickMeUp(2,mainElevator);
    insideRequest.GoToFloor(1, mainElevator);
    insideRequest.GoToFloor(4, mainElevator);
    outRequest.PickMeUp(5,mainElevator);
    insideRequest.GoToFloor(1, mainElevator);
    insideRequest.GoToFloor(100, mainElevator);
    insideRequest.GoToFloor(1, mainElevator);

}
catch (Exception ex)
{
    Console.WriteLine("Error -> " + ex.Message);
}
