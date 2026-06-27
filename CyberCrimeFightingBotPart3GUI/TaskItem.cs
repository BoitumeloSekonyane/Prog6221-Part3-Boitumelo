using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCrimeFightingBotPart2GUI
{
    /// <summary>
    /// This class represents a task item with properties for task ID, title, description, reminder date, and status.
    /// </summary>
    public class TaskItem
    {
        public int TaskID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime ReminderDate { get; set; }

        public string Status { get; set; }  

    }
}
