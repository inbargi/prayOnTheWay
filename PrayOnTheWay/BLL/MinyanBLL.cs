﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class MinyanBLL
    {
        MinyanDAL minyanDAL = new MinyanDAL();
        public bool AddMinyan(Minyan minyan)
        {
            return minyanDAL.AddMinyan(minyan);

        }
    }
}