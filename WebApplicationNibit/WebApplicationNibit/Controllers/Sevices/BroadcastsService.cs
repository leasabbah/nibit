using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationNibit.Models;

namespace WebApplicationNibit.Controllers.Sevices
{
    public class BroadcastsService:IBroadcastsRepository
    {
        public BroadcastsList getAllBroadcasts()
        {
            List<Broadcast> broadcastsList;
            broadcastsList = new List<Broadcast>()
            { new Broadcast {
                BroadcastDate = new DateTime(2017,7,1),
                BroadcastId = 1,
                BroadcastType = "items",
                DataAmount = 500,
                fileName = "items.txt",
                sentBy = "xxx" },
            new Broadcast {
                BroadcastDate = new DateTime(2018,1,22),
                BroadcastId = 2,
                BroadcastType = "prices",
                DataAmount = 480,
                fileName = "prices.txt",
                sentBy = "yyy" },
            new Broadcast
            {
                BroadcastDate = new DateTime(2018,1,19),
                BroadcastId = 3,
                BroadcastType = "pricefull",
                DataAmount = 480,
                fileName = "pricefull.txt",
                sentBy = "yyy"
            },
           new Broadcast
            {
                BroadcastDate = new DateTime(1999,1,19),
                BroadcastId = 4,
                BroadcastType = "pricefull",
                DataAmount = 780,
                fileName = "pricefull.txt",
                sentBy = "sss"
            },
            new Broadcast
            {
                BroadcastDate = DateTime.Now,
                BroadcastId = 5,
                BroadcastType = "promofull",
                DataAmount = 350,
                fileName = "promofull.txt",
                sentBy = "zzz"
            }
            };
            BroadcastsList myBlist = new BroadcastsList
            {
                Broadcasts = broadcastsList
            };
            return myBlist;
        }
    }
}