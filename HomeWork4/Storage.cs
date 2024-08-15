using System;

public class Storage<T>
{
    public T item;
    public void SetItem(T item)
    {
        this.item = item;
    }
    public T GetItem()
    {
        return item;
    }
}
/*public class Program1
{
    static void Main()
    {
        Storage<string> stringStorage = new Storage<string>();
        stringStorage.SetItem("cake");
        Console.WriteLine(stringStorage.GetItem());
        Storage<int> intStorage = new Storage<int>();
        intStorage.SetItem(28);
        Console.WriteLine(intStorage.GetItem());
    }

}*/

