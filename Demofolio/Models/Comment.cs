using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demofolio.Models
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Copy { get; set; }
        public virtual int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
