PTB2 pt = new PTB2(1, 9, 1);


double[]? rt = pt.GiaiPT();

if (rt == null) {
    Console.Write("pt vo nghiem");
}
else if (rt.Length == 1) {
    Console.Write("pt co 1 nghiem: {0}", rt[0]);
}
else {
    Console.Write("pt co 2 nghiem x1 = {0}  x2 = {1}", rt[0], rt[1]);
}

