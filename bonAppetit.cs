  static void bonAppetit(List<int> bill, int k, int b)
    {
        var amount = 0;
        for (int i = 0; i < bill.Count; i++)
        {
            if (i != k)
            {
                amount += bill[i];
            }
        }

        if ((amount / 2) == b)
            Console.WriteLine("Bon Appetit");
        else
            Console.WriteLine(Math.Abs(b - (amount / 2)));
    }
