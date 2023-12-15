namespace TracklyApi.Helpers
{
    public class EnumHelper
    {
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
