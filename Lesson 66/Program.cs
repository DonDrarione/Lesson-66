Console.WriteLine("M = ");
int M = BelowZero (Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("N = ");
int N = BelowZero (Convert.ToInt32(Console.ReadLine()));

Console.WriteLine(Summary(Math.Min(M,N),Math.Max(N,M)));

int BelowZero(int n) => n < 0 ? 0 : n;
int Summary(int N,int M)
{
    var Summary1 = 0;
    if (N <= M)
    {
        Summary1 = N;
        Summary1 += Summary (N + 1, M);
    }

    return Summary1;
}
