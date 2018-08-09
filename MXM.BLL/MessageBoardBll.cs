using MXM.Entity;
using MXM.Entity.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXM.BLL
{
    public class MessageBoardBll
    {
        public void Add(MessageBoard model)
        {
            using (var db=new MXMDBContext())
            {
                db.MessageBoards.Add(model);
                db.SaveChanges();
            }
        }
    }
}
