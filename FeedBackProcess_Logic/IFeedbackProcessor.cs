using FeedbackProcessor.Model;

namespace FeedBackProcess_Logic
{
    public interface IFeedbackProcessor
    {
        void CreateFeedBack(string message, Category feedbackCategory);
    }
}
