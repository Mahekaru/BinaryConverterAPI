using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BinaryConverterAPI.Models;

using System.Web.Http;
namespace BinaryConverterAPI.Controllers
{
    public class BinaryController1 : ApiController
    {
        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}


        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        public string GetData(int id, [FromBody] string value)
        {
            string s;

                var b = new ConvertToBinary();

                if (id == 1)
                {
                    s = b.ToBinary(value);
                }
                else
                {
                    s = b.ToText(value);
                }

            return s;
        }

        public string GETBinary(string value)
        {
            var b = new ConvertToBinary();
            string s = b.ToBinary(value);
            return s;

        }

        public string GetText(string value)
        {
            var b = new ConvertToBinary();
            string s = b.ToText(value);
            return s;
        }

    }
}