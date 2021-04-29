using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Turkcell.ECommerce.Core.Entities;

namespace Turkcell.ECommerce.Entities.Concrete
{
    public class ContactUs: IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public bool Read { get; set; }
        public DateTime SendDate { get; set; }
    }
}
