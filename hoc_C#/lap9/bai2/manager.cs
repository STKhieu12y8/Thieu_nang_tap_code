using System.Collections;
public class Manager {
    ArrayList items = new ArrayList();
    public bool addList (Employee employee) {
        items.Add(employee);
        return true;
    }
    public bool removeList (Employee employee) {
        items.Remove(employee);
        return true;
    }
    public void Display () {
        foreach (Employee item in items) {
            Console.WriteLine(item.ToString());
        }
    }
}