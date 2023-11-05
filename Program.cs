Sorting test = new Sorting();
int[] arr = {2,1,2,2,3,1 };
var result = test.Distinct(arr);
Console.WriteLine(result);

//TODO: add tests for triangle and MaxProductOfThree
class Sorting
{
    public int Distinct(int[] A)
    {
        HashSet<int> findDupes = new HashSet<int>();
        IEnumerable<int> dupes = new List<int>();
        foreach (var item in A)
        {
            if (!findDupes.Add(item))
            {
                dupes = dupes.Concat(new[] { item });
            }
        }

        return findDupes.Count();
    }

    public int MaxProductOfThree(int[] A)
    {
            if (A.Length < 3)
            {
                throw new ArgumentException("Array must have at least three elements");
            }

            Array.Sort(A);

            //Calculate the product of the last three elements
            int product1 = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];

            //Calculate the product of the first two elements and the last element
            int product2 = A[0] * A[1] * A[A.Length - 1];

            return Math.Max(product1, product2);
        

    }

    //P Q R is triangular if 0 <= P < Q < R < N
    //Array A consisting of N integers
    public int Triangle(int[] A)
    {
        if (A.Length < 3)
        {
            return 0;
        }

        Array.Sort(A);

        for (int i = 0; i < A.Length - 2; i++)
        {
            if (A[i] + A[i + 1] > A[i + 2])
            {
                return 1;
            }
        }

        return 0;
    }
}