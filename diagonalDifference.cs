/*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int sumLefttoRight = 0, sumRightoLeft = 0, counter = 0;
        while (counter < arr.Count)
        {
            sumLefttoRight += arr[counter][counter];
            sumRightoLeft += arr[counter][arr.Count - counter - 1];
            counter++;
        }

        return Math.Abs(sumLefttoRight - sumRightoLeft);
    }
