using System.ComponentModel.DataAnnotations;

namespace admin_panel.Models
{
    public class LoginViewModel
    {
        public string userName { get; set; } = null!;

        [DataType(DataType.Password)] 
        public string password { get; set; } = null!;

    }
    
}