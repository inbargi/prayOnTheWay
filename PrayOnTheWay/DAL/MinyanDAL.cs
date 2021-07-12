using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class MinyanDAL
    {

        public bool AddMinyan(Minyan minyan)
        {
            using (PrayOnTheWayEntities db=new PrayOnTheWayEntities())
            {
                db.Minyans.Add(minyan);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception )
                {
                    throw;
                }
            }
        }
    }
}
