interface IVehicle
{
    string Color { get; set; }
    string Manufacturer { get; set; }
    string Model { get; set; }
    int YearBuilt { get; set; }
    int Calculate ();
    void print();
}