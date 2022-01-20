// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static int LargestValsFromLabels(int[] values, int[] labels, int numWanted, int useLimit)
{
    
    int result = 0;
    Array.Sort(values, labels);
    Dictionary<int,int> vals = new Dictionary<int, int>();

    for(int i=values.Length-1; i>=0 && numWanted>0; i--)
    {
        if(!vals.ContainsKey(labels[i]))
        {
            vals.Add(labels[i], useLimit);
        }
        if (vals[labels[i]] > 0)
        {
            result += values[i];
            vals[labels[i]]--;
            numWanted--;
        }

    }

    return result;


}
int[] values = new int[] { 9, 8, 8, 7, 6 };
int[] labels = new int[] { 0, 0, 0, 1, 1 };
int numWanted = 3;
int useLimit = 1;
int res;
res = LargestValsFromLabels(values, labels, numWanted, useLimit);
Console.WriteLine(res);

/*
    for (int i = 0; i <numWanted; i++)
    {
        if (!vals.ContainsKey(labels[i]) && useLimit>=0)
        {
            vals[labels[i]] = new List<int>();
            vals[labels[i]].Add(values[i]);

        }

        else
            vals[labels[i]].Add(values[i]);
        numWanted--;
        useLimit--;

    }
    foreach (var item in vals.Keys)
    {
        int k = 0;
        while (k < numWanted)
        {
            if (l < useLimit)
                result += vals[item].ToAr;
            k++;
            l++;
        }
    }
    
    foreach (var item in vals.Keys)
    {
        Console.Write(item + "  ");
        foreach (var val in vals[item])
        {
            Console.Write(val + ",");
        }
        Console.WriteLine();

    }
    */