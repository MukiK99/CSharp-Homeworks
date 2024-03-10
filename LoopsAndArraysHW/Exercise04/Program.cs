string[] stringArray = { "Greg", "Bob", "John", "Jane", "Bronn" };
Console.WriteLine(stringArray[0]);
double[] doubleArray = { 2.4, 5.2, 4.4, 9.2, 10 };
Console.WriteLine(doubleArray[0]);
char[] charArray = { 'a', 'b', 'c', 'd', 'e' };
Console.WriteLine(charArray[0]);
bool[] booleanArray = {true,false, true,false,false };
Console.WriteLine(booleanArray[2]);
int[][] twoDimensionalArray = new int[][]
{
    new int[]{1,2,3,4,5},
    new int[]{2,4,6,8,10},
    new int[]{1,3,5,7},
    new int[]{-2,-1,0},
    new int[]{10,20,20,40}
};
Console.WriteLine(twoDimensionalArray[0][0]);
Console.WriteLine(twoDimensionalArray[4][1]);
Console.ReadLine(); 
