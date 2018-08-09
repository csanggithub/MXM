using MXM.Entity.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXM.Entity
{
    public class MXMDBContext:DbContext
    {
        public MXMDBContext() : base("name=MXMDB")
        {
        }
        public DbSet<MessageBoard> MessageBoards { get; set; }
    }
}
