using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.DTOs
{
    public class EditMSCUserDTO : UserWithRole
    {
        public bool IsDisabled { get; set; }
        public string? NewPassword { get; set; }
        public string? ConfirmNewPassword { get; set; }
        public HashSet<string> RoleIds { get; set; } = new ();
    }
}
