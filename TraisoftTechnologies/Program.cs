// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

static int DiagonalDifference(int[,] matrix, int n)
{
    int primarySum = 0;
    int secondarySum = 0;

    // Calculate the sum of the primary diagonal
    for (int i = 0; i < n; i++)
    {
        primarySum += matrix[i, i];
    }

    // Calculate the sum of the secondary diagonal
    for (int i = 0; i < n; i++)
    {
        secondarySum += matrix[i, n - i - 1];
    }

    // Calculate the absolute difference between the sums of the diagonals
    int difference = Math.Abs(primarySum - secondarySum);

    return difference;
}


Console.WriteLine("Enter the size of the square matrix (N):");
int n = int.Parse(Console.ReadLine());

// Create the matrix
int[,] matrix = new int[n, n];

Console.WriteLine("Enter the elements of the matrix:");

// Reading input for the matrix
for (int i = 0; i < n; i++)
{
    string[] rowValues = Console.ReadLine().Split(',');
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = int.Parse(rowValues[j]);
    }
}

// Calculate the diagonal difference
int result = DiagonalDifference(matrix, n);
// Print the result
Console.WriteLine($"The absolute difference between the sums of the diagonals is: {result}");

