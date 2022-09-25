public class Square : Rectangle {


    public Square(string color, bool filled, double side) : base(color, filled, side, side) {
        this.color = color;
        this.filled = filled;
        this.length = side;
        this.width = side;
    }

    public double getSize() {
        return width;
    }

    public override void setLength (double value) {
        this.length = value;

    }

    public override void setWidth (double value) {
        this.width = value;
    }

    public override string toString()
    {
        return this.width + " - " +  this.length + " - " + this.color + " - " + this.filled;
    }
}