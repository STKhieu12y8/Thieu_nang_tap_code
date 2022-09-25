public class Retangle : Shape {
    public double length {set; get;}
    public double width {set; get;}

    public override double getArea () {
        return this.width * this.length;
    }
    public override string toString () {
        return ($"hinh tu giac dai: {this.length} rong: {this.width} mau: {this.color}");
    }
    
}