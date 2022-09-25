public class Tritangle : Shape
{
    public double base_ { set; get; }
    public double height { set; get; }

    public override double getArea()
    {
        return (height * base_ / 2);
    }

    public override string toString() {
        return ($"hinh tam giac day: {this.base_} cao: {this.height} mau: {this.color}");
    }
}