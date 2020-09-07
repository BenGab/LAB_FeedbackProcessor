using System;

namespace FeedbackProcessor.Model
{
    public class Feedback
    {
        public Feedback(string message, Category category)
        {
            Message = message;
            Category = category;
            FeedbackId = Guid.NewGuid();
        }

        public string Message { get; }

        public Category Category { get; }

        public Guid FeedbackId { get; }
    }
}
