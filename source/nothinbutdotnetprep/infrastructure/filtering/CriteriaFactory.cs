using System;
using nothinbutdotnetprep.infrastructure.ranges;

namespace nothinbutdotnetprep.infrastructure.filtering
{
  public class CriteriaFactory<ItemToFilter, PropertyType> : ICreateSpecifications<ItemToFilter, PropertyType>
  {
    PropertyAccessor<ItemToFilter, PropertyType> accessor;

    public CriteriaFactory(PropertyAccessor<ItemToFilter, PropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<ItemToFilter> equal_to(PropertyType value)
    {
      return equal_to_any(value);
    }

    public IMatchAn<ItemToFilter> equal_to_any(params PropertyType[] values)
    {
      return create_using(new EqualToAny<PropertyType>(values));
    }

    public IMatchAn<ItemToFilter> create_using(IMatchAn<PropertyType> criteria)
    {
      return new PropertyCriteria<ItemToFilter, PropertyType>(accessor, criteria);
    }

    public IMatchAn<ItemToFilter> greater_than(PropertyType value)
    {
      return create_using(new FallsInRange<PropertyType>(new ExclusiveRangeWithNoUpperBound<PropertyType>(value)));
    }

    public IMatchAn<ItemToFilter> between(PropertyType start, PropertyType end)
    {
      return create_using(new FallsInRange<PropertyType>(new InclusiveRange<PropertyType>(start, end)));
    }

    public ICreateSpecifications<ItemToFilter, PropertyType> not
    {
      get{ return new NegatedCriteriaFactory<ItemToFilter, PropertyType>(this);}
    }
  }
}