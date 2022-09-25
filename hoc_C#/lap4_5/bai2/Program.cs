Rectangle shape = new Rectangle(12, 4);
shape.Show();
double dt =  shape.Area();
double cv =  shape.Perimeter();
Console.WriteLine("Dien tich: {0}\n", dt);
Console.WriteLine("Chu vi: {0}\n", cv);

shape.getHeight(2);
shape.getWidth(10);
shape.Show();
double dt2 =  shape.Area();
double cv2 =  shape.Perimeter();
Console.WriteLine("Dien tich: {0}\n", dt2);
Console.WriteLine("Chu vi: {0}\n", cv2);

