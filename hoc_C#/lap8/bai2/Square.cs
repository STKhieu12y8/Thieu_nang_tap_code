public class Square : Shape {

    public double area {set; get;}
    public override double getArea()
    {
        return size*size;
    }

    public double getSize () {
        return Math.Sqrt(area);
    }
}