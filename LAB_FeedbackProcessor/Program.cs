using FeedBackProcess_Logic;
using FeedbackProcessor.Model;

namespace LAB_FeedbackProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            IFeedbackProcessor feedbackProcessor = new FeedBackProcess_Logic.FeedbackProcessor();

            feedbackProcessor.CreateFeedBack("Very cool", Category.Opinion);
            feedbackProcessor.CreateFeedBack("Need some extra stuff", Category.FeatureRequest);
            feedbackProcessor.CreateFeedBack("Somethong wrong happened", Category.Bugreport);
        }
    }
}
