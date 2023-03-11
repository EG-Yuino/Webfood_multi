using wefood.Models.BaseModel;

namespace wefood.Models
{
	[Table("category")]
	public class CategoryFood : GetInfoModel
	{

		public int categoryID { get; set; }
		public string? categoryName { get; set; }

		public void printInfo() => Console.WriteLine($"ID: {categoryID} -	Name: {categoryName}");
	}
}