using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Application.Responses
{
    public class LabelResponse
    {
        public Int64 LabelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
