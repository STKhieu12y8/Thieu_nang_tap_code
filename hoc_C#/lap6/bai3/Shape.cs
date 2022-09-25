public class Shape {
    protected string color;
    protected bool filled;

    Shape() {
        color = "unset";
        filled = false;
    }

    public Shape(string color, bool filled) {
        this.color = color;
        this.filled = filled;
    }

    public string getColor() {
        return color;
    }

    public void setColor(string color) {
        this.color = color;
    }

    public bool isFilled() {
        return filled;
    }

    public void setFilled(bool filled) {
        this.filled = filled;
    }

    public virtual string toString() {
        return ($"{this.color} {this.filled}");
    }

}