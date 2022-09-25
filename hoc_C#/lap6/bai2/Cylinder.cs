public class Cylinder : Circle
{
    public double height { set; get; }
    public double getHeight()
    {
        return height;
    }
    public double getVolume()
    {
        return 3.14 * radius * radius * height;
    }
    public override double getArea()
    {
        return (2 * 3.14 * radius * height + 3.14 * radius * radius);
    }
    public override string toString()
    {
        return ($"hinh tru tron ban kinh: {radius}\t mau: {color}\t cao: {height}\n");
    }
}