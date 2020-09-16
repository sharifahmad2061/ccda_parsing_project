using MessageHandler;

namespace Services
{
    public interface ICreateMessage
    {
        void QueueTask(TaskModel model);
    }
}