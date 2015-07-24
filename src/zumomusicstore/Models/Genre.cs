using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zumomusicstore.Models
{
    public class Genre
    {
        private string name;

        public string Id { get; set; }

        public string Description { get; set; }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                this.name = value;
            }
        }
    }
}
