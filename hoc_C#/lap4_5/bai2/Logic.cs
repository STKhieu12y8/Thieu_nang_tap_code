public class Rectangle {
    public int Width;

    public int Height;

    public Rectangle(int width, int height) {
        this.Width = width;
        this.Height = height;
    }

    public void Show () {
        for (int i = 0; i < Height; i++) {
            for (int j = 0; j < Width; j++) {
                Console.Write("# ");
            }
            Console.Write("\n\n");
        }
    }

    public double Area() {

        return Width*Height;
    }

    public double Perimeter() {

        return (Width+Height) * 2;
    }
    public void getHeight (int height) {
        this.Height = height;
        Console.WriteLine("set height complete\n");
    }

    public void getWidth (int width) {
        this.Width = width;
        Console.WriteLine("set witdh complete\n");
    }

    
}