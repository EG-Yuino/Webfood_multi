namespace webfood.Services.Impl
{
    public interface ICategoryService
    {
        public Task<List<CategoryFood>> GetCategory();
    }
}
