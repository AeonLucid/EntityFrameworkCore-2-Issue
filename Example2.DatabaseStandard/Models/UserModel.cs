using System.ComponentModel.DataAnnotations.Schema;

namespace Example2.DatabaseStandard.Models
{
    [Table("users")]
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }
    }
}
