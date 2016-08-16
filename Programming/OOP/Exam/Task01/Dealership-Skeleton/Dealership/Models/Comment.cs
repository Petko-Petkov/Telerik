namespace Dealership.Models
{
    using System;
    using Contracts;
    using Common;
    using System.Text;
    public class Comment : IComment
    {
        private string content;

        public Comment(string content)
        {
            this.Content = content;
        }

        public string Author { get; set; }

        public string Content
        {
            get { return this.content; }
            private set
            {
                Validator.ValidateNull(value, string.Format(MyConstants.ValidateNullMessage, "Content"));
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinCommentLength,
                    Constants.MaxCommentLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Content", Constants.MinCommentLength, Constants.MaxCommentLength));

                this.content = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            var indent = new string(' ', 6);
            output.AppendLine(this.Content);
            output.AppendLine(indent + string.Format("User: {0}", this.Author));
            return output.ToString().Trim();
        }
    }
}
