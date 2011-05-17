namespace nothinbutdotnetprep.infrastructure
{
  public class AnonymousCriteriaFactory<ItemToFilter>
  {
    public AnonymousCriteria<ItemToFilter> CreateCriteria(Matches<ItemToFilter> condition)
    {
      return new AnonymousCriteria<ItemToFilter>(condition);
    }
  }
}