using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace Core_WebApp.Models
{
    public partial class CoreAppDBContext: DbContext
    {

        public CoreAppDBContext()
        {
        }

        public CoreAppDBContext(DbContextOptions<CoreAppDBContext> options)
            : base(options)
        {
        }
    }

    
    }
