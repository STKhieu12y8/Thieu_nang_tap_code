public class Cube : Shape {
    public double area {set; get;}
    public double volume {set; get;}

    public override double getArea() {
        return Math.Pow(size, 2) * 6;
    }
    public double getSizeInArea() {
        return Math.Sqrt(Convert.ToDouble((area/6)));
    }
    public double getSizeInVolume() {
        return Math.Pow(volume, Convert.ToDouble(1/3));
    }
    public double getVolume () {
        return Math.Pow(size, 3);
    }
}