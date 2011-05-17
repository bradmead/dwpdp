using System;

namespace nothinbutdotnetprep.infrastructure.filtering
{
  public class Where<ItemToMatch>
  {
    public static CriteriaFactory<ItemToMatch, PropertyType> has_a<PropertyType>(PropertyAccessor<ItemToMatch, PropertyType> accessor)
    {
      return new CriteriaFactory<ItemToMatch, PropertyType>(accessor);
    } 
  }
}