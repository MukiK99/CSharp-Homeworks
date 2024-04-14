namespace Cars.Domain.Entities
{
    public class Car : BaseEntity
    {
        public string Model { get; set; }
        public double MilesPerGalon { get; set; }
        public int Cylinders { get; set; }
        public double HorsePower { get; set; }
        public double Weight { get; set; }
        public double AccelerationTime { get; set; }
        public string Origin { get; set; }

        public override string GetInfo()
        {
            string result = $"Model:{Model} {MilesPerGalon} miles per galon, {Cylinders} cylinders, {HorsePower} horsepower, Weight:{Weight}, Acceleration Time:{AccelerationTime}, Origin:{Origin}";
            return result;
        }
    }
}
