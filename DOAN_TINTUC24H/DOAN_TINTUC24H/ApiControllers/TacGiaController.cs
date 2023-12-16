using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DOAN_TINTUC24H.Models;

namespace DOAN_TINTUC24H.ApiControllers
{
    public class TacGiaController : ApiController
    {
        public List<TacGia> Get()
        {
            NewsDBContext db = new NewsDBContext();
            List<TacGia> tintucs = db.tacGias.ToList();
            return tintucs;
        }
    }
}
