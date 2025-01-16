using ElevatorApp;


try
{
    Elevator mainElevator = new Elevator(1);
    mainElevator.getStatus();
    mainElevator.Move(2);
    mainElevator.Move(5);
    mainElevator.Move(0);
}
catch (Exception ex) { 
    Console.WriteLine("Error -> " + ex.Message);
}
