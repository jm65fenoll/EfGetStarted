using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Models;
// See https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
public class BlogginContext: DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public String ConnectionString { get; set; }
    public BlogginContext()
    {
        ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=EfGetStarted;Trusted_Connection=True";
    } 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConnectionString);
}
