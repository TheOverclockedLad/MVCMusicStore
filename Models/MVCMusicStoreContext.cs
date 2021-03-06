﻿namespace MVCMusicStore.Models
{
    public class MVCMusicStoreContext : System.Data.Entity.DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVCMusicStoreContext() : base("name=MVCMusicStoreContext")
        {
        }

        public System.Data.Entity.DbSet<Album> Albums { get; set; }

        public System.Data.Entity.DbSet<MVCMusicStore.Models.Review> Reviews { get; set; }
    }
}