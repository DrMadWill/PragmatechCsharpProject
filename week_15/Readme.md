### ASP.Net Views
- `_ViewStart` bütün `view`lar başlanğıc olaraq buradan teyin edilmiş başlanğıcla başlayır.
- `ViewBag` dataları **View**ya daşımaq üçün istfadə edilir.


## Entity Framwork Code First 
> C# codları ilə databases qurma məsələsidir.


### Creating
> İlk olarq daxilində propertylər olan `public class` təyin edirik. Bu propertlərin hər biri bizim bir column olacaq.
```cs

    public class Parfum
    {
        [Key] //data annotations
        public int Id { get; set; }

        [MaxLength(100)]//data annotations
        [Required]//data annotations
        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public Brend Brend { get; set; } // Convention
        public int BrendId { get; set; }


        public Gender Gender { get; set; } // Convention
        public int GenderId { get; set; }


        public Density Density { get; set; }
        public int DensityId { get; set; }


        public List<SalePrice> SalePrices { get; set; }//Convention

        public List<CategoryToParfum> CategoryToParfums { get; set; }
    }

```


> `DbContext` sinifindən törədilən mərkəz classı yardaraq tableləri yaradılmasını istədiyimiz classları bura əlavə edirik və `OnConfiguring` modelini override edirik.

```cs
     public class ParfumCnotex : DbContext
    {
        public DbSet<Brend> Brends { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Density> Densities { get; set; }

        public DbSet<SizeML> SizeMLs { get; set; }

        public DbSet<SalePrice> SalePrices { get; set; }

        public DbSet<CategoryToParfum> CategoryToParfums { get; set; }

        public DbSet<Parfum> Parfums { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Brend>()
                .HasIndex(u => u.Name)
                .IsUnique();// Unique Key Added

            builder.Entity<Gender>()
               .HasIndex(u => u.Name)
               .IsUnique();// Unique Key Added

            builder.Entity<Category>()
               .HasIndex(u => u.Name)
               .IsUnique();// Unique Key Added

            builder.Entity<Density>()
               .HasIndex(u => u.Name)
               .IsUnique();// Unique Key Added

            builder.Entity<User>()
               .HasIndex(u => u.Email)
               .IsUnique();// Unique Key Added

            builder.Entity<SizeML>()
                .HasIndex(u => u.Size)
                .IsUnique();// Unique Key Added

            builder.Entity<Parfum>()
                .HasIndex(t => t.Name)
                .IsUnique(); // Unique Key Added

            builder.Entity<CategoryToParfum>()
                .HasKey(t => new { t.CategoryId, t.ParfumId });

            builder.Entity<CategoryToParfum>()
                .HasOne(cp => cp.Category)
                .WithMany(c => c.CategoryToParfums)
                .HasForeignKey(c => c.CategoryId); // Many To Meny Fluent Api

            builder.Entity<CategoryToParfum>()
                .HasOne(cp => cp.Parfum)
                .WithMany(p => p.CategoryToParfums)
                .HasForeignKey(p => p.ParfumId);// Many To Meny Fluent Api
        }

        public static readonly ILoggerFactory factory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLoggerFactory(factory)
                .UseSqlServer(@"Data Source=LAPTOP-071EH2HU\SQLEXPRESS;Initial Catalog=ParfumDbCodeFirst;"
                + "Integrated Security=true;");

        }

    }

    public class SizeML
    {
        [Key]
        public int Id { get; set; }

        public double Size { get; set; }
        public List<SalePrice> SalePrices { get; set; }

    }
```

> Aşağı doğru ardıcıllıqla biri digərinin qaydalarını əzə bilir.
> - Convention 
> - Data annotations(Qadağalar)
> - Fluent Api(Table əlaqələri)



