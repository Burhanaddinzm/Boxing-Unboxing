int num = 256;
//Boxing:
object numObject = num;
//Changing the num's value doesn't affect numObject's stored value:
num = 512;
Console.WriteLine(num);
Console.WriteLine(numObject);
//Unboxing:
int num2 = (int)numObject;
Console.WriteLine(num2);
//Can't use different types when unboxing:
//int num3 = (string)numObject;
