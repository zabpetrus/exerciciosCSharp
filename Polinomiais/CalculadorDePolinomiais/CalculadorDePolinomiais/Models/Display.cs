using System.ComponentModel.DataAnnotations;

namespace CalculadorDePolinomiais.Models
{
    public partial class Display
    {
        [Display(Name = "mostrador")]
        [Required(ErrorMessage = "Informe a expressão", AllowEmptyStrings = false)]
        public string showDisplay { get; set; } 



    }
}
