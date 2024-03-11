namespace ClassesHW.Classes
{
    public class Car
    {
        public string Model { get; set; }
        public double Speed { get; set; }
        public Driver Driver { get; set; }

        public Car() { }
        public Car(string model, double speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }
        public double CalculateSpeed()
        {
            double speed = Speed * Driver.Skill;
            return speed;
        }

       
    }




}
