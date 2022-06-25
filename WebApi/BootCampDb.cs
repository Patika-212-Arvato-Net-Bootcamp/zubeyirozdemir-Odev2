using System;
using System.Collections.Generic;

namespace WebApi
{
    public static class BootCampDb
    {
        // BootcampDb class içerisinde bootcamp list ve list içerisinde subscriberInfo list. Eğer yeni bootcamp oluşturulursa subscriberInfo list null olacak.
        public static List<BootCamp> BootCampsList = new List<BootCamp>()
        {
            new BootCamp
            {
                Id = 1,
                Title = "Backend developer Bootcamp",
                Subscribers = new List<SubscriberInfo>()
                {
                    new SubscriberInfo()
                    {
                        Name = "Ali",
                        SurName = "Ozdemir",
                        Gsm = "05434"
                    },
                    new SubscriberInfo()
                    {
                        Name = "Veli",
                        SurName = "Ozdemir",
                        Gsm = "0543"
                    }

                },
                StartTime = DateTime.Now,
                FinishTime = new DateTime(2022,7,20)
            },
            new BootCamp
            {
                Id = 2,
                Title = ".Net Core Bootcamp",
                Subscribers = new List<SubscriberInfo>()
                {
                    new SubscriberInfo()
                    {
                        Name = "Ahmet",
                        SurName = "Ozdemir",
                        Gsm = "0532"
                    },
                    new SubscriberInfo()
                    {
                        Name = "Hasan",
                        SurName = "Ozdemir",
                        Gsm = "0542"
                    }

                },
                StartTime = new DateTime(2021,5,10),
                FinishTime = new DateTime(2022,7,20)
            },
            new BootCamp
            {
                Id = 3,
                Title = "Frontend Bootcamp",
                Subscribers = new List<SubscriberInfo>()
                {
                    new SubscriberInfo()
                    {
                        Name = "Zubeyir",
                        SurName = "Ozdemir",
                        Gsm = "0534"
                    },
                    new SubscriberInfo()
                    {
                        Name = "Murat",
                        SurName = "Ozdemir",
                        Gsm = "0552"
                    }

                },
                StartTime = new DateTime(2019,5,5),
                FinishTime = new DateTime(2022,7,20)
            },
            new BootCamp
            {
                Id = 4,
                Title = "Full-Stack Developer Bootcamp",
                Subscribers = new List<SubscriberInfo>()
                {
                    new SubscriberInfo()
                    {
                        Name = "Mehmet",
                        SurName = "Ozdemir",
                        Gsm = "0555"
                    },
                    new SubscriberInfo()
                    {
                        Name = "Kubra",
                        SurName = "Ozdemir",
                        Gsm = "0541"
                    }

                },
                StartTime = DateTime.Now,
                FinishTime = new DateTime(2022,8,20)
            }
        };

        // Yeni katılımcı eklendiği durumda listeye gelir.
        public static List<BootCampParticipantRequestDTO> WaitingBootCampsList = new List<BootCampParticipantRequestDTO>(){};

    }
}
