using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BinaryConverterAPI.Models;

namespace BinaryConverterAPI.Controllers
{
    public class BinaryController : ApiController
    {
        public string GetData(int id, [FromUri] string value)
        {
            string s = "";

            var b = new ConvertToBinary();

            if (value != null)
            {
                if (id == 1)
                {
                    s = b.ToBinary(value);
                }
                else
                {
                    s = b.ToText(value);
                }
            }
            else
            {
                Console.WriteLine("This is a friendly message...Your object is null");
                //s = "This is a friendly message...Your object is null";
            }
            return s;
        }
    }
}
