//using wefood.Models;

//namespace webfood.Startup.DBContext;

//public class WebFoodDbContext : AppDbContext
//{
//    public WebFoodDbContext() : base() { }




//    public virtual DbSet<CategoryFood> categories { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        if (!optionsBuilder.IsConfigured)
//        {
//            optionsBuilder = new DbContextOptionsBuilder();
//            IConfiguration config = new ConfigurationBuilder()
//                  .SetBasePath(Directory.GetCurrentDirectory())
//                  .AddJsonFile("appsettings.json")
//                  .Build();
//            string sqlcon = config.GetConnectionString("ConnectDb");
//            optionsBuilder.UseSqlServer(sqlcon);
//        }

//    }
//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        base.OnModelCreating(modelBuilder);
//    }

//}

