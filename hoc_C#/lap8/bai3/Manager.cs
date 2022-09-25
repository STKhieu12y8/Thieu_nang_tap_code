public class Build {
    public Build (string name, string address, double choice) {
        Customer.Customer kh = new Customer.Customer();
        kh.name = name; kh.address = address;
        if (choice == 1) 
        {
        Order.Order sp = new Order.Order();
        sp.bakery(1);
        }
        else if (choice == 2) {
        Order.Order sp = new Order.Order();
        sp.batket(2);
        }
        else {
        Order.Order sp = new Order.Order();
        sp.bakery(1);
        sp.batket(1);
        }
        
    }
}