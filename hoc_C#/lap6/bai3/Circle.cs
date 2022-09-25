public class Circle : Shape {
    public double radius {set; get;}

    public Circle(string color, bool filled, double radius) : base(color, filled) {
        this.radius = radius;
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }

    public double getArea() {
        return Math.PI * this.radius * this.radius;
    }

    public double getPerimeter() {
        return this.radius * 2 * Math.PI;
    }

    public override string toString() {
        return ($"{this.radius} + {this.color} + {this.filled}");
    }
}