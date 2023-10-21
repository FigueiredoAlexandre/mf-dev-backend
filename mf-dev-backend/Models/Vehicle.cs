using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend.Models
{
    [Table("vehicles")]
    public class Vehicle {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A placa é obrigatória!")]
        public string Code { get; set; }

        [Required(ErrorMessage ="Placa é obrigatória")]
        public int FabricationYear { set; get; }

        [Required(ErrorMessage = "Ano de modelo é obrigatório")]
        public int ModelYear { set; get; }
    }
}
