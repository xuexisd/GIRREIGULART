using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMMODEL
{
    public class BaseModel
    {
        public int UPDATE_VERSION { get; set; }
        public string CREATED_BY { get; set; }
        public string CREATED_TIME { get; set; }
        public string LAST_UPDATED_BY { get; set; }
        public string LAST_UPDATED_TIME { get; set; }
        public string ERROR_MSG { get; set; }
    }
}
