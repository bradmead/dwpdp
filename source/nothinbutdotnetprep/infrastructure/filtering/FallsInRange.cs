using System;
using nothinbutdotnetprep.infrastructure.ranges;

namespace nothinbutdotnetprep.infrastructure.filtering
{
  public class FallsInRange<T> : IMatchAn<T> where T : IComparable<T>
  {
    Range<T> range;

    public FallsInRange(Range<T> range)
    {
      this.range = range;
    }

    public bool matches(IComparable<T> item)
    {
      return range.contains(item);
    }
  }
}