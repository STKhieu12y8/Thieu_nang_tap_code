Customer c1 = new Customer("Huy", true, "Premium");
Customer c2 = new Customer("WHOS", true, "Silver");
Console.WriteLine(c1.toString());
Console.WriteLine(c2.toString());

Visit v1 = new Visit(c1, "10/10/2012");
Console.WriteLine(v1.toString());

v1.setProductExpense(4.5);
v1.setServiceExpense(8.5);
v1.setProductExpense(1.5);
Console.WriteLine(v1.toString());
Console.WriteLine("Total expense made by " + v1.getCustomerName() + " = " + v1.getTotalExpense());