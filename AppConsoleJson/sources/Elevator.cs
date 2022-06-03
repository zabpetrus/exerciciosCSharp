using System;

namespace AppConsoleJson.sources
{
    public class Elevator
    {       
        public int andar { get; set; }  //O elevador que utiliza com mais frequência (A, B, C, D ou E)

        public char elevador { get; set; } //O andar ao qual se dirige (0 a 15);

        public char turno {  get; set; }  //O período que utiliza o elevador – M: Matutino; V: Vespertino; N: Noturno.               
    

    }
}
