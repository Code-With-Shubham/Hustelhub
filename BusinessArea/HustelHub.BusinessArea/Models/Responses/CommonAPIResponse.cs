using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustelHub.BusinessArea.Models.Responses
{
    public class CommonAPIResponse
    {
        public int code { get; set; }
        public string? status { get; set; }
        public string? message { get; set; }

    }
}
