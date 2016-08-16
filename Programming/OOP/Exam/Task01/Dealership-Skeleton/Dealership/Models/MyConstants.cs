namespace Dealership.Models
{
    using Dealership.Common;

    public class MyConstants
    {
        public const string ValidateNullMessage = "{0} cannot be null!";

        public const string CommentDoesNotExist = "Cannot remove comment! The comment does not exist!";

        public const string NotAuthor = "You are not the author!";

        public const string NotVip = "You are not VIP and cannot add more than 5 vehicles!";

        public const string IsAdmin = "You are an admin and therefore cannot add vehicles!";
    }
}
