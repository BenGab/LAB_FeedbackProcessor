using FeedbackProcessor.Model;
using System;
using System.Collections.Generic;

namespace FeedBackProcess_Logic
{
    public class FeedbackProcessor : IFeedbackProcessor
    {
        private ICollection<Feedback> feedBacks;

        private IDictionary<Category, Action<Feedback>> feedBackProcessingfunctions;

        public FeedbackProcessor()
        {
            feedBacks = new List<Feedback>();
            feedBackProcessingfunctions = new Dictionary<Category, Action<Feedback>>()
            {
                { Category.Bugreport, feedback => Console.WriteLine($"[BUGREPORT] - {feedback.FeedbackId} - {feedback.Message}")},
                { Category.Opinion, feedback => Console.WriteLine($"[OPINION] - {feedback.FeedbackId} - {feedback.Message}")},
                { Category.FeatureRequest, feedback => Console.WriteLine($"[FEATURE] - {feedback.FeedbackId} - {feedback.Message}")},
            };
        }

        public void CreateFeedBack(string message, Category feedbackCategory)
        {

            Feedback feedback = new Feedback(message, feedbackCategory);
            feedBacks.Add(feedback);
            Console.WriteLine($"FeedBack created with {feedback.FeedbackId} ID");
            ProcessFeedBacks();
        }

        private void ProcessFeedBacks()
        {
            if (feedBacks.Count < 3)
            {
                return;
            }

            foreach(var feedback in feedBacks)
            {
                feedBackProcessingfunctions[feedback.Category](feedback);
            }

            feedBacks.Clear();
        }
    }
}
