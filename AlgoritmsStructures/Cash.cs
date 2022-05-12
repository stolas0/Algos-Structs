static public class Cash
{
    static Dictionary<int, int> cash = new Dictionary<int, int>();

    static Func<int, int> CashFunc(Func<int, int> func)
    {
        Func<int, int> cashedFunc = n =>
        {
            if (!cash.ContainsKey(n))
                cash[n] = func(n);

            return cash[n];
        };

        return cashedFunc;
    }
}

