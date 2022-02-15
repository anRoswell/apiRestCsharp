using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ResponseAction
    {
        public bool estado { get; set; }
        public string mensaje { get; set; }
        public int? Id { get; set; }
        public string error { get; set; }
    }
}
