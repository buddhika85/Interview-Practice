<Query Kind="Program" />

using static System.Console;

void Main()
{
	var twoDArray = new int[,] {
			{1,2},
			{3,4},
			{5,6}
			};

	twoDArray.Dump();
	//WriteLine(twoDArray.GetLength(0));      // rows
	//WriteLine(twoDArray.GetLength(1));      // columns
	//WriteLine(twoDArray[2, 1]);              // r = 2, c = 1
	
	var result = new int[twoDArray.GetLength(1), twoDArray.GetLength(0)];
	result.Dump();
	
	var rows = twoDArray.GetLength(0);
	var columns = twoDArray.GetLength(1);
	for (int row = 0; row < rows; row++)
	{
		for(int col = 0; col < columns; col++)
		{
			var newRow = row;
			var newCol = col;
			if (row != col)
			{
				newRow = col;
				newCol = row;
			}
			result[newRow, newCol] = twoDArray[row, col];
		}
	}
	
	result.Dump();
}

public void Print2DArray(int[,] twoDArray)
{
	string str = string.Empty;
	var rows = twoDArray.GetLength(0);
	var columns = twoDArray.GetLength(1);
	for (int row = 0; row < rows; row++)
	{
		for (int col = 0; col < columns; col++)
		{
			str += $"{twoDArray[row, col]} ";
		}
		str += Environment.NewLine;
	}
	Console.WriteLine(str);
}
	
