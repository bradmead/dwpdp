using nothinbutdotnetprep.collections;

namespace nothinbutdotnetprep.infrastructure
{
  public class Where<Item>
  {
    public static ProductionStudio has_a<PropertyType>(PropertyAccessor<Item, PropertyType> accessor)
    {
      return PropertyEvaluator<Item, PropertyType>.Evaluate(accessor);
    }
  }

  public class PropertyEvaluator<Item, PropertyType>
  {
    public static ProductionStudio Evaluate(PropertyAccessor<Item, PropertyType> accessor)
    {
      return ProductionStudio.Pixar;
    }
  }
}