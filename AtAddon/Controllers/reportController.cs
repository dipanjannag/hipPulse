﻿using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AtAddon.Controllers
{
    public enum ReportType
    {
        Entity
    }
    public class reportController : ApiController
    {

        // GET: api/report
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/report/5
        public dynamic Get(string roomid, int type)
        {
            switch (type)
            {
                case (int)ReportType.Entity:

                    AmazonDynamoDBClient client = new AmazonDynamoDBClient("AKIAINYB73XJJD5MCCNA", "YXE31LiskMC8+tFZw+CwFvPr0Rvk2NRp8HU1XZr2",
                                                                Amazon.RegionEndpoint.USWest2);
                    Table dataCache = Table.LoadTable(client, "resultCache");
                    Document Cache = dataCache.GetItem(roomid);
                    if(Cache!=null)
                    {
                        var rrr = Cache["entity"].ToString().Replace("\r", string.Empty)
                            .Replace("\n", string.Empty)
                            .Replace("\t", string.Empty);
                        return new
                        {
                            status = "OK",
                            time_stamp = Cache["time_stamp"],
                            data = rrr
                        };
                    }
                    break;
                default:
                    break;
            }
            return JsonConvert.SerializeObject(new { status = "UNKNOWN_ERROR" });
        }

        // POST: api/report
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/report/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/report/5
        public void Delete(int id)
        {
        }
    }
}