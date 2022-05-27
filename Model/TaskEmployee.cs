using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TaskEmployee
    {
        public string Username { get; set; }
        public virtual Employee Employee { get; set; }

        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public TaskStatus Status { get; set; }
    }
}
