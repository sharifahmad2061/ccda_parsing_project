using System;

namespace MessageHandler
{
    public class TaskModel
    {
        public string PracticeCode { get; set; }
        public string DataStorePath { get; set; }
        public bool EmailOnCompletion { get; set; }
        public string RecepientEmail { get; set; }
    }
}
