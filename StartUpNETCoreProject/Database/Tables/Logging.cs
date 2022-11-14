using System.ComponentModel.DataAnnotations;

namespace StartUpNETCoreProject.Database.Tables
{
    public class Logging : ITableModel
    {
        [Required]
        public int Id { get; set; }


        [Required]
        [Display(Name = "Логин пользователя")]
        public string? Login { get; set; }


        [Required]
        [Display(Name = "Пароль пользователя")]
        public string? Password { get; set; }
    }
}
