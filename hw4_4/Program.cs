
River Riv = new River("River", 43, 123, 5, 1234);
Riv.ShowInfo();
Console.WriteLine("Interface");
Mountain M = new Mountain("Mountain", 122, 33, 4123);
M.ShowInfo();
interface GeoObject
{
    abstract void ShowInfo();
}
class River : GeoObject
{
    private int x;
    private int y;
    private string Name;
    private int speed;
    private int lengh;
    public River(string Name, int x, int y, int _speed, int _lengh)
    {
        this.Name = Name;
        this.x = x;
        this.y = y;
        this.speed = _speed;
        this.lengh = _lengh;
    }
    public void ShowInfo()
    {
        Console.WriteLine("X: " + x);
        Console.WriteLine("Y: " + y);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine($"Speed : {this.speed} km/h");
        Console.WriteLine($"Lengh : {this.lengh} km");
    }
}
class Mountain : GeoObject
{
    private int x;
    private int y;
    private string Name;
    private int highPoint;
    public Mountain(string Name, int x, int y, int _highPoint)
    {
        this.Name = Name;
        this.x = x;
        this.y = y;
        this.highPoint = _highPoint;
    }
    public void ShowInfo()
    {
        Console.WriteLine("X: " + x);
        Console.WriteLine("Y: " + y);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine($"High point : {this.highPoint} m");
    }
}

