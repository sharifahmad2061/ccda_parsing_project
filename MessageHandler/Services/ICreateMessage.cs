using MessageHandler;

namespace MessageHandler.Services
{
    public interface ICreateMessage
    {
        void QueueTask(TaskModel model);
    }
}