using App.Domain;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace App.DAL;

public class UserRepository
{
    AppDbContext dbContext;
    DbSet<User> _dbSet;
    public UserRepository(AppDbContext dbContext)
    {
         this.dbContext = dbContext;
        _dbSet = dbContext.Set<User>();
    }
    public void Add(User product)
    {
        _dbSet.Add(product);
        this.dbContext.SaveChanges();
    }

    public User GetById(int id)
    {
        return _dbSet.FirstOrDefault(p => p.Id == id);
    }
}
