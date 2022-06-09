using System.Linq;
namespace CodeWars_PairOfGloves;

public class PairOfGloves
{
    public static int NumberOfPairs(string[] gloves)
    {
        var duplicates = gloves.GroupBy(x => x)
            .Where(g => g.Count() > 1)
            .Select(y => new { Item = y.Key, Count = y.Count()/2 })
            .ToList();
        var numberOfPairs=duplicates.Select(item=>item.Count).Sum();
        return numberOfPairs;
    }
}