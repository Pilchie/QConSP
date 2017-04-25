using System;
using System.Threading;
using System.Threading.Tasks;

class Others
{
    async ValueTask<int> ProcessAsync(object obj,
        CancellationToken cancellationToken = default(CancellationToken))
    {
        await Task.Delay(TimeSpan.FromSeconds(1));

        if (obj is string s)
        {
            return int.TryParse(s, out var i) ? i : -1;
        }
        else if (obj is int i)
        {
            return i;
        }
        else
        {
            return -1;
        }
    }
}