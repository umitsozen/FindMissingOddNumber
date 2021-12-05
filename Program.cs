// See https://aka.ms/new-console-template for more information
/// <summary>
/// Input  17, 3, 5, 7, 9, 13, 15, 1
/// Output 11
/// 
/// Input 9,5,3
/// Output 7
/// Developed by Ümit Sözen
/// </summary>

//Test 1
int[] arr = { 17, 3, 5, 7, 9, 13, 15, 1 };
FindMissingOddNumber(arr);

//Test 2
int[] arr2 = { 9, 5, 3 };
FindMissingOddNumber(arr2);

//Function finds missing odd number at array
void FindMissingOddNumber(int[] arr)
{

	int[] sArr = arr.OrderBy(i => i).ToArray();  // order ascending 
	for (int i = 0; i < sArr.Length; i++)
		if (sArr[i + 1] - sArr[i] == 2)
			continue;
		else
		{
			Console.WriteLine(sArr[i] + 2);
			break;
		}
}

