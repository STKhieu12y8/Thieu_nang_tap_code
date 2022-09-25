Employee nv1 = new Employee("huy", "HD");
Employee nv2 = new Employee("huy", "Hn");
Employee nv3 = new Employee("huy", "Hp");
Employee nv4 = new Employee("huy", "vp");

Manager list = new Manager();
list.addList(nv1);
list.addList(nv2);
list.addList(nv3);
list.addList(nv4);

list.Display();

Console.Write("xoa nv 1");
if (list.removeList(nv2)) {
    Console.Write("sus");
    list.Display();
};
