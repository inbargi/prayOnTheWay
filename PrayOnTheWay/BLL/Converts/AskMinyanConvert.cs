using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL.Converts
{
    public class AskMinyanConvert
    {
        public static AskMinyanDTO ConvertDALToDTO(AskMinyan askMinyan)
        {
            return new AskMinyanDTO
            {
                IdAskMinyan = askMinyan.IdAskMinyan,
                IdPrayer = askMinyan.IdPrayer,
                Lat = askMinyan.Lat,
                Lng = askMinyan.Lng,
                AskTime = askMinyan.AskTime,
                Prayer = PrayerConvert.ConvertDALToDTO(askMinyan.Prayer),
                AsksToMinyans = AsksToMinyanConvert.ConvertDALToDTOList(askMinyan.AsksToMinyans)

            };
        }
        public static AskMinyan ConvertDTOToDAL(AskMinyanDTO askMinyanDTO)
        {
            return new AskMinyan
            {
                IdAskMinyan = askMinyanDTO.IdAskMinyan,
                IdPrayer = askMinyanDTO.IdPrayer,
                Lat = askMinyanDTO.Lat,
                Lng = askMinyanDTO.Lng,
                AskTime = askMinyanDTO.AskTime,
                Prayer = PrayerConvert.ConvertDTOToDAL(askMinyanDTO.Prayer),
                AsksToMinyans = AsksToMinyanConvert.ConvertDTOToDALList(askMinyanDTO.AsksToMinyans)
            };
        }
        public static List<AskMinyanDTO> ConvertDALToDTOList(ICollection<AskMinyan> askMinyans)
        {
            return askMinyans.Select(a => ConvertDALToDTO(a)).ToList();
        }
        public static ICollection<AskMinyan> ConvertDTOToDALList(List<AskMinyanDTO> askMinyans)
        {
            return askMinyans.Select(a => ConvertDTOToDAL(a)).ToList();
        }
    }
}
