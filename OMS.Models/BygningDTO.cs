using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models;

public class BygningDTO
{
    public int Id { get; set; }
    [Required(ErrorMessage ="Skriv navnet på bygningen")]
    public string Navn { get; set; } = string.Empty;

}
