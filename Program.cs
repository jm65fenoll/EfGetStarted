// See https://aka.ms/new-console-template for more information


// using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

using var db = new BlogginContext();

db.Database.EnsureDeleted();
db.Database.EnsureCreated();

Console.WriteLine("Hello, World!");

// Identify
Console.WriteLine($"Database Connection String: {db.ConnectionString}" );

// Create 
Console.WriteLine("Inserting a new blog.");
db.Add(new Blog { Title = "Orders", BloggerName="Jose Miguel" });
db.SaveChanges();

//Read 
Console.WriteLine("Queryng for a blog.");
var blog = db.Blogs.OrderBy(b => b.Id).First();
Console.WriteLine(blog.Title);

//Update 
Console.WriteLine("Updating the blog and adding a Post.");
blog.Title = "Local Orders";
blog.Posts.Add(new Post { Title = "Hello,World", Content = "I Wrote an App using EFCore!" });
db.SaveChanges();
