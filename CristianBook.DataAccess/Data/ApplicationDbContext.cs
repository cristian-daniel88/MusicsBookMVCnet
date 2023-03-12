﻿using Microsoft.EntityFrameworkCore;
using MusicsBook.Models;


namespace MusicsBookWeb.DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Category> Categories { get; set; }
       
    }
}
