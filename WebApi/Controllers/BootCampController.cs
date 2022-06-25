using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BootCampController : ControllerBase
    {
        // Tüm bootcamp listesi ve katılımcıların gosterildiği HttpGet method.
        [HttpGet]
        public List<BootCamp> GetBootCamps()  
        {
            var bootCampList = BootCampDb.BootCampsList.OrderBy(x=> x.Id).ToList<BootCamp>();
            return bootCampList;
        }

        // Bootcamp Id ye göre HttpGet method.
        [HttpGet("/getBootCampById")]
        public BootCamp GetBootCampById([FromBody] int id)
        {
            for (int i = 0; i < BootCampDb.BootCampsList.Count; i++)
            {
                if (BootCampDb.BootCampsList[i].Id == id)
                {
                    return BootCampDb.BootCampsList[i];
                }
            }
            return new BootCamp();  
        }

        // saveParticipantWaitingList edildikten sonra bootcampliste eklenir
        [HttpGet("/getParticipant")]
        public List<BootCampParticipantRequestDTO> GetBootCampParticipantWaitingList()
        {
            var bootCampList = BootCampDb.WaitingBootCampsList.ToList<BootCampParticipantRequestDTO>();
            return bootCampList;
        }

        // Yeni katılımcı kayıt
        [HttpPost("/saveParticipantWaitingList")]
        public bool saveParticipant(BootCampParticipantRequestDTO bootCampParticipantRequestDTO)
        {
            for (int i = 0; i < BootCampDb.BootCampsList.Count; i++)
            {
                if (BootCampDb.BootCampsList[i].Title == bootCampParticipantRequestDTO.BootCampName)
                {
                    BootCampDb.WaitingBootCampsList.Add(bootCampParticipantRequestDTO);
                    return true;
                }
               
            }

            return false;

        }
    }
}
