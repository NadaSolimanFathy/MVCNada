using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Entities
{
    public class BaseEntity
    {

        [Required(ErrorMessage = "Id is required ")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        //I don't need the id to be identity  as the admin will add it .
        public int Id { get; set; }

    }
}
