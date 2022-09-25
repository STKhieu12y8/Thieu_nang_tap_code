// test authour
Author huy = new Author("huy", "doanhuyxh@gmail.com", "Nam");
Console.WriteLine($"tac gia: {huy.getName(), -10} email: {huy.getEmail(), -30} gioi tinh: {huy.getGender(),-3}");
huy.setEmail("xmcs.mi@gmail.com");
Console.WriteLine($"Mail sau khi sua: {huy.getEmail(), -30}");
Console.WriteLine("\n");
//test book

Book conan = new Book("truyen tranh", huy, 10000, 20);
Console.WriteLine($"ten sach: {conan.getName(),-10}   tac gia: {conan.getAuthor().getName(),-15} gia :{conan.getPrice(),-12} qyt: {conan.getQty()}");
conan.setPrice(8908);
Console.WriteLine($"gia sau update: "+ conan.getPrice());
conan.setQty(13);
Console.WriteLine($"qty sau khi doi: "+ conan.getQty());

