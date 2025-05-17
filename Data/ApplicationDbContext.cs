using Microsoft.EntityFrameworkCore;
using ProductApi.Models;

namespace ProductApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // 초기 데이터 설정
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "노트북",
                Description = "최신 프로세서와 넓은 저장 공간을 갖춘 노트북",
                Price = 1200000,
                Stock = 10,
                CreatedAt = DateTime.UtcNow
            },
            new Product
            {
                Id = 2,
                Name = "스마트폰",
                Description = "고화질 카메라와 빠른 프로세서가 탑재된 스마트폰",
                Price = 800000,
                Stock = 20,
                CreatedAt = DateTime.UtcNow
            },
            new Product
            {
                Id = 3,
                Name = "태블릿",
                Description = "가벼운 무게와 뛰어난 화질의 태블릿",
                Price = 500000,
                Stock = 15,
                CreatedAt = DateTime.UtcNow
            }
        );
    }
}