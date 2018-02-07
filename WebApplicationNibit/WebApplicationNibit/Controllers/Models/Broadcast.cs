using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationNibit.Models
{
    public class Broadcast
    {
        public DateTime BroadcastDate { get; set; }
        public int BroadcastId { get; set; }
        public String BroadcastType { get; set; }
        public String fileName { get; set; }
        public int DataAmount { get; set; }
        public String sentBy { get; set; }
        public Broadcast()
        {

        }
        public Broadcast(Broadcast b)
        {
            this.BroadcastDate = b.BroadcastDate;
            this.BroadcastId = b.BroadcastId;
            this.BroadcastType = b.BroadcastType;
            this.DataAmount = b.DataAmount;
            this.fileName = b.fileName;
            this.sentBy = b.sentBy;


        }

    }

}