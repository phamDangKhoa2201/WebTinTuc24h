using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DOAN_TINTUC24H.Models;


namespace DOAN_TINTUC24H.ApiControllers
{
    public class TheLoaiController : ApiController
    {
        public List<TheLoai> Get()
        {
            NewsDBContext db = new NewsDBContext();
            List<TheLoai> tintucs = db.theLoais.ToList();
            return tintucs;
        }
    }
}
