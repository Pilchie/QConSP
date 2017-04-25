using System;
using System.Threading;
using System.Threading.Tasks;

class Others
{
    async Task<int> ProcessAsync(object obj,
        CancellationToken cancellationToken = default(CancellationToken))
    {
        await Task.Delay(TimeSpan.FromSeconds(1));

        if (obj is string s)
        {
            int i;
            return int.TryParse(s, out i) ? i : -1;
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