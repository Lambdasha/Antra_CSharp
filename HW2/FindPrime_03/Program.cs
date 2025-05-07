// See https://aka.ms/new-console-template for more information

static int[] FindPrimesInRange(int startNum, int endNum)
{
    var prime = new List<int>();

    for (int i = Math.Max(startNum, 2); i <= endNum; i++)
    {
        bool flag = true;
        int limit = (int)Math.Sqrt(i);
        for (int j = 2; j <= limit; j++)
        {
            if (i % j == 0)
            {
                flag = false;
                break;
            }
        }
        if (flag) prime.Add(i);
    }
    return prime.ToArray();
}
