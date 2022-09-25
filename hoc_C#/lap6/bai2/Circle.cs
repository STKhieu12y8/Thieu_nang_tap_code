public class Circle {
    public double radius{set; get;}
    public string? color{set; get;}

    
    public double getRadius () {
        return radius;
    }

    public string? getColor () {
        return color;
    }
    public virtual double getArea () {
        return 3.14 * radius * radius;
    }

    public virtual string toString () {
        return ($"hinh tron ban kinh: {radius}\t mau: {color}\n");
    }
}