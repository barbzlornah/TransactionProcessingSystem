using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionProcessing.Models
{
    public class TransactionContext : DbContext
    {
        // Created a TransactionContext to encompass all of the models into one Context which can be linked to the Db.
        public TransactionContext(DbContextOptions<TransactionContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
