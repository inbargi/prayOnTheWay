using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AsksToMinyanController : ApiController
    {
       AsksToMinyanBLL asksToMinyanBll = new AsksToMinyanBLL();

        public bool AddAsksToMinyan(AsksToMinyanDTO asksToMinyan)
        {
            return asksToMinyanBll.AddAsksToMinyan(asksToMinyan);

        }
        public List<AsksToMinyanDTO> GetAsksToMinyans()
        {
            return asksToMinyanBll.GetAsksToMinyans();
        }
    }
}
