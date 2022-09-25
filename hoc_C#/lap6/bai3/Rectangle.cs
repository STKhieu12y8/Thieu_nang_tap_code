public class Rectangle : Shape{

    public double width{set; get;}
    public double length{set; get;}

    public Rectangle(string color, bool filled, double width, double length) :base(color, filled){
        this.width = width;
        this.length = length;
    }

    public double getWidth() {
        return width;
    }

    public virtual void setWidth(double width) {
        this.width = width;
    }

    public double getLength() {
        return length;
    }

    public virtual void setLength(double length) {
        this.length = length;
    }

    public virtual double getArea() {
        return this.width * this.length;
    }

    public virtual double getPerimeter() {
        return this.width + this.length;
    }

    public override string toString() {
        return ($"{this.width}  +  {this.length} + {this.color} + {this.filled}");
    }
}