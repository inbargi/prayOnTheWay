using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Converts
{
    public class MinyanConvert
    {
        public static MinyanDTO ConvertDALToDTO(Minyan minyan)
        {
            MinyanDTO minyanDTO = new MinyanDTO();
            minyanDTO.IDMinyan = minyan.IdMinyan;
            minyanDTO.IDPrayer = minyan.IdPrayer;
            minyanDTO.DateMinyan = minyan.DateMinyan;
            minyanDTO.BeginningTimeMinyan = minyan.BeginningTimeMinyan;
            minyanDTO.IDLocationMinyan = minyan.IdlocationMinyan;
            minyanDTO.NumOfPeopleInMinyan = minyan.NumOfPeopleInMinyan;

            return minyanDTO;

        }
        public static Minyan ConvertDTOToDAL(MinyanDTO minyanDTO)
        {
            Minyan minyan = new Minyan();
            minyan.IdMinyan = minyanDTO.IDMinyan;
            minyan.IdPrayer = minyanDTO.IDPrayer;
            minyan.DateMinyan = minyanDTO.DateMinyan;
            minyan.BeginningTimeMinyan = minyanDTO.BeginningTimeMinyan;
            minyan.IdlocationMinyan = minyanDTO.IDLocationMinyan;
            minyan.NumOfPeopleInMinyan = minyanDTO.NumOfPeopleInMinyan;
            return minyan;

        }
        public static List<MinyanDTO> ConvertDALToDTOList(ICollection<Minyan> minyans)
        {
            return minyans.Select(m => ConvertDALToDTO(m)).ToList();
        }
        public static ICollection<Minyan> ConvertDTOToDALList(List<MinyanDTO> minyans)
        {
            return minyans.Select(m => ConvertDTOToDAL(m)).ToList();
        }
    }
}
