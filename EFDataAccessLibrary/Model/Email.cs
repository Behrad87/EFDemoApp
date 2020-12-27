using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataAccessLibrary.Model
{
    public class Email
    {
        public int Id { get; set; }

        
        [Required]
        [MaxLength(150)]
        //[Column(TypeName ="varchar(10) ")]
        public string EmailAddress { get; set; }


    }
}
