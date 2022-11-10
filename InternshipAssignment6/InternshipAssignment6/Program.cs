
using InternshipAssignment6;

GenericList<string> genericList = new GenericList<string>(4);
genericList.Add("string1");
genericList.Add("string2");
genericList.Add("string3"); ;
genericList.Add("string4");

genericList.WriteList();

Console.WriteLine("Element at index 0 is " + genericList.GetAtIndex(0));
Console.WriteLine("Element at index 3 is " + genericList.GetAtIndex(3));

genericList.SetAtIndex(0, "1");
genericList.SetAtIndex(3, "4");

genericList.WriteList();

genericList.SwapByIndexes(0, 3);

genericList.WriteList();

genericList.SwapByItems("string2", "string3");

genericList.WriteList();
