namespace TyphoonTaskingTool.DTOs
{
    public class AddMSCUserDTO
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string ConfirmPassword { get; set; }
        public HashSet<string> RoleIds { get; set; } = new();
    }
}