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
    public class SafePointOnTheWayController : ApiController
    {
        SafePointOnTheWayBLL safePointOnTheWayBll = new SafePointOnTheWayBLL();

        public bool AddSafePointOnTheWay(SafePointOnTheWayDTO safePointOnTheWay)
        {
            return safePointOnTheWayBll.AddSafePointOnTheWay(safePointOnTheWay);

        }
        public List<SafePointOnTheWayDTO> GetSafePointOnTheWays()
        {
            return safePointOnTheWayBll.GetSafePointOnTheWays();
        }
    }
}
