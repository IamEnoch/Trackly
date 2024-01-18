namespace TracklyApi.DTOs
{
    public class UserDto
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public UserDto(string email, string username, string userId, DateTime? createdAt, DateTime? updatedAt)
        {
            this.Email = email;
            this.Username = username;
            this.UserId = userId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }
    }
}
