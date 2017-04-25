using System;
using System.Threading;
using System.Threading.Tasks;

class Others
{
    async Task<int> ProcessAsync(object obj,
        CancellationToken cancellationToken = default(CancellationToken))
    {
        await Task.Delay(TimeSpan.FromSeconds(1));

        var s = obj as string;
        if (s != null)
        {
            int i;
            return int.TryParse(s, out i) ? i : -1;
        }
        else if (obj is int)
        {
            return (int)obj;
        }
        else
        {
            return -1;
        }
    }
}