using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DOAN_TINTUC24H.Models;

namespace DOAN_TINTUC24H.ApiControllers
{
    public class TinTucController : ApiController
    {
        public List<TinTuc> Get()
        {
            NewsDBContext db = new NewsDBContext();
            List < TinTuc > tintucs = db.tinTucs.ToList();
            return tintucs;
        }
    }
}
