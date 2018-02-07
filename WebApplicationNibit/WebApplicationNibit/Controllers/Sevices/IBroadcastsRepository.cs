using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationNibit.Models;

namespace WebApplicationNibit.Controllers.Sevices
{
    public interface IBroadcastsRepository
    {
        BroadcastsList getAllBroadcasts();
    }
}
