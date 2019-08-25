using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
namespace peep_point {
public class ContextDB : DbContext {

public ContextDB(DbContextOptions<ContextDB> options) : base(options)
 {
 }
 public DbSet<Book> BookItems { get; set; }
}
}