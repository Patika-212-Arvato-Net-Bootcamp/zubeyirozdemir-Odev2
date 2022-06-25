using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApi.Controllers
{
    public class AdminController : Controller
    {
        //Delete Bootcamp
        [HttpDelete("/deleteBootCampById")]
        public bool DeleteBootCamp(int id)
        {

            for (int i = 0; i < BootCampDb.BootCampsList.Count; i++)
            {
                if (BootCampDb.BootCampsList[i].Id == id)
                {
                    BootCampDb.BootCampsList.Remove(BootCampDb.BootCampsList[i]);
                    return true;
                }

            }

            return false;
        }

        // Yeni bootcamp organizasyonu ekleme işlemi
        [HttpPost("/saveBootCamp")]
        public BootCamp SaveBootCamp([FromBody] BootCampDTO bootCamp) 
        {
            var newBootCamp = new BootCamp()
            {
                Id = BootCampDb.BootCampsList.Count + 1,
                Title = bootCamp.Title,
                Subscribers = new List<SubscriberInfo>(),
                StartTime = bootCamp.StartTime,
                FinishTime = bootCamp.FinishTime
            };

            BootCampDb.BootCampsList.Add(newBootCamp);

            return newBootCamp;

        }
        // Katılımcı onayla
        [HttpPost("/saveParticipant")]
        public bool SaveParticipant([FromBody] string gsm)
        {

            for (int i = 0; i < BootCampDb.WaitingBootCampsList.Count; i++)
            {
                if (BootCampDb.WaitingBootCampsList[i].SubsInfo.Gsm == gsm)
                {
                    for (int j = 0; j < BootCampDb.BootCampsList.Count; j++)
                    {
                        if (BootCampDb.BootCampsList[j].Title == BootCampDb.WaitingBootCampsList[i].BootCampName)
                        {
                            BootCampDb.BootCampsList[j].Subscribers.Add(new SubscriberInfo()
                            {
                                Gsm = BootCampDb.WaitingBootCampsList[i].SubsInfo.Gsm,
                                Name = BootCampDb.WaitingBootCampsList[i].SubsInfo.Name,
                                SurName = BootCampDb.WaitingBootCampsList[i].SubsInfo.SurName
                            });

                            return true;

                        }
                    }
                    
                }

            }
            return false;
        }

        //Katılımcı Sil
        [HttpDelete("/deleteParticipant")]
        public bool DeleteParticipant([FromBody] string gsm, [FromBody] string bootCampName)
        {

            for (int i = 0; i < BootCampDb.BootCampsList.Count; i++)
            {
                if (BootCampDb.BootCampsList[i].Title == bootCampName)
                {
                    for (int j = 0; j < BootCampDb.BootCampsList[i].Subscribers.Count; j++)
                    {
                        if (BootCampDb.BootCampsList[i].Subscribers[j].Gsm == gsm)
                        {
                            BootCampDb.BootCampsList[i].Subscribers.Remove(new SubscriberInfo() 
                            { 
                                Gsm = BootCampDb.BootCampsList[i].Subscribers[j].Gsm,
                                Name = BootCampDb.BootCampsList[i].Subscribers[j].Name,
                                SurName = BootCampDb.BootCampsList[i].Subscribers[j].SurName

                            });
                            
                            return true;
                        }
                    }

                }

            }

            return false;
        }

    }
}
