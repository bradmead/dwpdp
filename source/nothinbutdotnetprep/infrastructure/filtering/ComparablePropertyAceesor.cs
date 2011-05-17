using System;

namespace nothinbutdotnetprep.infrastructure.filtering
{
  public delegate PropertyType ComparablePropertyAccessor<in ItemToTarget, out PropertyType>(ItemToTarget item) where ItemToTarget : IComparable;
}
