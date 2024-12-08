using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Post
    {
        public int Id { get; set; }
        public String Author { get; set; }
        public String Content { get; set; }
        public DateTime Created { get; set; }
    }
}
