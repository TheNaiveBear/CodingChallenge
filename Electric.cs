class Electric : IVehicle
{
    public string Color { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int YearBuilt { get; set; }
    public string MotorType { get; set; }
    public Electric (string ColorIn, string ManufacturerIn, string ModelIn, int YearBuiltIn, string MotorTypeIn)
    {
        Color = ColorIn;
        Manufacturer = ManufacturerIn;
        Model = ModelIn;
        YearBuilt = YearBuiltIn;
        MotorType = MotorTypeIn;
    }
    public int Calculate()
    {
        return DateTime.Now.Year - YearBuilt;
    }
    public void print()
    {
        Console.WriteLine("{0,12}{1,10}{2,15}{3,10}{4,20}", Manufacturer, Model, YearBuilt, Calculate(), MotorType);
    }
}