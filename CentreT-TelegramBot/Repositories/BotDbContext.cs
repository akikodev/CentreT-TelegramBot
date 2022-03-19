﻿using Microsoft.EntityFrameworkCore;

namespace CentreT_TelegramBot.Repositories;

public class BotDbContext : DbContext
{
    public DbSet<Entities.User> Users { get; set; }
    
    public BotDbContext(DbContextOptions<BotDbContext> options) : base(options)
    {

    }
}