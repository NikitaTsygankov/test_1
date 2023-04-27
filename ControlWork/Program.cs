// program to convert array
Console.WriteLine("Hello, what`s your name?");
string username = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Hello,");
Console.Write(username);
Console.WriteLine();
Console.WriteLine();


Console.Write("Enter number of arrays elements: ");
int m = int.Parse(Console.ReadLine());
string [] stringArray = new string [m];
void array(string [] stringArray)
{
  for (int i = 0;i<stringArray.Length;i++)
  {
     Console.WriteLine($"Enter {i+1} arrays element");
     stringArray[i] = Console.ReadLine();
  }
}
string [] symbol(string [] stringArray)
{
  int n = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    n++;
  }
  string [] count = new string [n];
  int j = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    {
        count[j] = stringArray[i];
        j++;
    }
  }
  return count;
}
void printArrayNew(string [] stringArray)
{
    Console.Write("[");
    for (int i = 0;i<stringArray.Length;i++)
    {
    Console.Write($"‘{stringArray[i]}’, ");
    }
    Console.Write("]");
}
array(stringArray);
printArrayNew(symbol(stringArray));