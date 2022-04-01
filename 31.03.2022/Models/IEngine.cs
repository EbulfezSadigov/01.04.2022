namespace _31._03._2022.Models
{
    internal interface IEngine
    {
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public string FuelType { get; set; }
        public int CurrentOil { get; set; }
        void LeftFuelAmount();
    }
}