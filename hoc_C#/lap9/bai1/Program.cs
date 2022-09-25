using System.Collections;

ArrayList _list = new ArrayList();

for (int i = 10; i > 0; i--)
{
    _list.Add(i);
}
_list.Sort();

foreach (var item in _list)
{
    Console.WriteLine(item);
}