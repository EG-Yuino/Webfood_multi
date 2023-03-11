using System.Data.Common;
using webfood.Services.Impl;


namespace webfood.Services
{
    public class CategoryService : ICategoryService
    {
        //private WebFoodDbContext _connection;

        public CategoryService(DbContext dbcontext)
        {
            //dbcontext =  _connection;
        }
        

        public async Task<List<CategoryFood>> GetCategory()
        {
            //var con = new WebFoodDbContext(new DbContextOptions<WebFoodDbContext>());

            //var c = await _connection.categories.ToListAsync();
            //var result = await _connection.categories.ToListAsync();

            //if (result is not null) return result;


            //string connectstriing = "Data Source=localhost,1433;Initial Catalog=webfood;User ID=SA;Password=Bombim239@2000";
            //using var connect = new SqlConnection(connectstriing);
            //List<CategoryFood> result = new List<CategoryFood>();
            //connect.Open();
            //string sqlstring = "select * from category ";
            //if (connect is not null)
            //{
            //    SqlCommand cate = new SqlCommand(sqlstring, connect);
            //    using var reader = cate.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {
            //            var categoryFood = new CategoryFood()
            //            {
            //                categoryID = reader.GetInt32("IdFood"),
            //                categoryName = reader.GetString("NameFood"),
            //            };
            //            result.Add(categoryFood);
            //        }
            //    }
            //    connect.Close();
            //}
            //else return result;

            return null;
        }
    }
}
