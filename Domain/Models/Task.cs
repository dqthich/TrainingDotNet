using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Task
    {
        public Guid TaskId { get; set; }
        public status Status { get; set; }
        public enum status
        {
            New, Inprogress, Finished
        }

        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public virtual User AssignbyUser { get; set; }
        public virtual Project InProject { get; set; }

    }
}
