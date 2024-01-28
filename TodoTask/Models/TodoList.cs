using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoTask.Models
{
    [Table("TodoList")]
    public class TodoList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public DateTime TaskDate { get; set; }
       /* public DateTime dateonly
        {
            get { return TaskDate.Date; }
        }*/
       
    }
}
