using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AskMinyanBLL
    {
        AskMinyanDAL askMinyanDAL = new AskMinyanDAL();
        public bool AddAskMinyan(AskMinyanDTO AskMinyan)
        {

            return askMinyanDAL.AddAskMinyan(Converts.AskMinyanConvert.ConvertDTOToDAL(AskMinyan));
        }
        public List<AskMinyanDTO> GetAskMinyans()
        {
            return Converts.AskMinyanConvert.ConvertDALToDTOList(askMinyanDAL.GetAskMinyans());
        }
        public bool UpdateAskMinyan(AskMinyanDTO askMinyan)
        {
            return askMinyanDAL.UpdateAskMinyan(Converts.AskMinyanConvert.ConvertDTOToDAL(askMinyan));
        }
        public bool RemoveAskMinyan(AskMinyanDTO askMinyan)
        {
            return askMinyanDAL.RemoveAskMinyan(Converts.AskMinyanConvert.ConvertDTOToDAL(askMinyan));
        }
    }
}
