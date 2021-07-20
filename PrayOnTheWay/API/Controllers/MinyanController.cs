using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BLL;

namespace API.Controllers
{
    public class MinyanController : ApiController
    {
        MinyanBLL minyanBll = new MinyanBLL();

        public bool Addminyan(MinyanDTO minyan)
        {
            return minyanBll.AddMinyan(minyan);

        }
        public List<MinyanDTO> Getminyans()
        {
            return minyanBll.GetMinyans();
        }
    }
}
