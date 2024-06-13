namespace DeliveryFood
{
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;

    public class DeliveryModel : DbContext
    {
        public DeliveryModel()
            : base("name=DeliveryModel")
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }

    public class User
    {
        public int Id { get; set; }

        [MaxLength(26)]
        [MinLength(4)]
        public string Login { get; set; }

        [MaxLength(32)]
        [MinLength(5)]
        public string Password { get; set; }

        [MaxLength(64)]
        public string Email { get; set; }
        public bool CheckAuth { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Price { get; set; }
        public string LinkPhoto { get; set; }
    }

}