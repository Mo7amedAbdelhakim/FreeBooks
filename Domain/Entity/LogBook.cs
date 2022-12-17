using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class LogBook
    {
        public Guid Id { get; set; }
        public string Action { get; set; }
        public DateTime date { get; set; }
        public Guid UserID { get; set; }
        public Guid BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }

    }
}
