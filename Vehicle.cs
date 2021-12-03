struct VehicleType
{
    public Electric? _Electric = null;
    public Gas? _Gas = null;
    public int Type;

    public VehicleType (Electric Vehicle)
    {
        _Electric = Vehicle;
        Type = 0;
    }
    public VehicleType (Gas Vehicle)
    {
        _Gas = Vehicle;
        Type = 1;
    }
}
class Vehicle
{
    List<VehicleType> VehicleArray = new List<VehicleType>();
    string[] PosEngineSize = {"Four Cylinders", "Six Cylinders", "Eight Cylinders"};
    string[] PosMotorType = {"Single", "Dual"};
    string[] PosManufacturer = {"Tesla", "Volkswagen", "Tyota", "Dodge", "Chevrolet", "Ford"};
    string[] PosColor = {"Red", "Green", "Blue", "White", "Black"};
    string[] PosModel = {"Sport", "Sedan", "Truck", "Van", "Compact"};

    public void addCar(bool IsElectric, string ColorIn, string ManufacturerIn, string ModelIn, int YearBuiltIn, string Special)
    {
        if (IsElectric)
        {
            VehicleArray.Add(new VehicleType(new Electric(ColorIn, ManufacturerIn, ModelIn, YearBuiltIn, Special)));
        }
        else
        {
            VehicleArray.Add(new VehicleType(new Gas(ColorIn, ManufacturerIn, ModelIn, YearBuiltIn, Special)));
        }
    }

    void sortList()
    {
        VehicleArray.Sort((x, y) => x.Type.CompareTo(y.Type));
    }

    public void print()
    {
        sortList();

        Console.WriteLine("{0,12}{1,10}{2,15}{3,10}{4,20}", "Manufacturer", "Model", "Year Built", "Age", "Motor Type");
        var subList = VehicleArray.Where(x => x.Type == 0);
        foreach (var x in subList)
        {
            x._Electric!.print();
        }

        Console.WriteLine();
        
        Console.WriteLine("{0,12}{1,10}{2,15}{3,10}{4,20}", "Manufacturer", "Model", "Year Built", "Age", "Engine Size");
        subList = VehicleArray.Where(x => x.Type == 1);
        foreach (var x in subList)
        {
            x._Gas!.print();
        }
    }

    public void addRandom()
    {
        var random = new Random();
        if (random.Next(0,100)%2 == 0)
        {
            addCar(true, PosColor[random.Next(PosColor.Count())], PosManufacturer[random.Next(PosManufacturer.Count())],
            PosModel[random.Next(PosModel.Count())], random.Next(1995, 2021),
            PosMotorType[random.Next(PosMotorType.Count())]);
        }
        else
        {
            addCar(false, PosColor[random.Next(PosColor.Count())], PosManufacturer[random.Next(PosManufacturer.Count())],
            PosModel[random.Next(PosModel.Count())], random.Next(1995, 2021),
            PosEngineSize[random.Next(PosEngineSize.Count())]);
        }
    }
}