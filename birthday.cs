static int birthday(List<int> s, int d, int m)
{
    if (s.Count == 1 && m == 1 && d == s[0])
        return 1;

    var counter = 0;
    for (int i = 0; i < s.Count; i++)
    {
        var temp = 0;
        if (i + m <= s.Count)
        {
            for (int j = 0; j < m; j++)
            {
                temp += s[i + j];
            }

            if (temp == d)
            {
                counter++;
            }
        }
    }


    return counter;
}
