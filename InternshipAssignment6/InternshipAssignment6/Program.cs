
using InternshipAssignment6;

GenericList<string> genericList = new GenericList<string>(4);
genericList.SetAtIndex(0, "string1");
genericList.SetAtIndex(1, "string2");
genericList.SetAtIndex(2, "string3");

Console.WriteLine("Element at index 0 is " + genericList.GetAtIndex(0));
Console.WriteLine("Element at index 2 is " + genericList.GetAtIndex(2));

genericList.SetAtIndex(2, "3");
genericList.SetAtIndex(3, "string4");

genericList.WriteList();

genericList.SwapByIndexes(0, 3);

genericList.WriteList();

genericList.SwapByItems("string2", "string4");

genericList.WriteList();
