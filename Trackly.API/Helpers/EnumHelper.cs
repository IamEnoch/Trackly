namespace TracklyApi.Helpers
{
    public class EnumHelper
    {
        public enum AssetCondition
        {
            New,
            Good,
            Fair,
            Poor,
            Broken
        }
        public enum Priority
        {
            Low,
            Medium,
            High
        }

        public enum AssetCategory
        {
            Laptop,
            Desktop,
            Monitor,
            Printer,
            Scanner,
            Projector,
            Other
        }

        public enum Role
        {
            Admin,
            User
        }

        public enum TicketStatus
        {
            Open,
            InProgress,
            Completed,
            Closed
        }

        //Work item status
        public enum WorkItemStatus
        {
            Pending,
            Approved,
            Rejected,
        }

        public enum TicketCategory
        {
            Hardware,
            Software,
            Network,
            Other
        }

        public enum LocationEnum
        {
            Office,
            Home,
            Other
        }

        public enum DepartmentEnum
        {
            IT,
            HR,
            Finance,
            Marketing,
            Other
        }


    }
}
