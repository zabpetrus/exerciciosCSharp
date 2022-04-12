namespace CalculaFreteApplication.Models
{
    public class Frete
    {
        public int cep { get; set; }
        public int cep_origem { get; set; }
        public int cep_destino { get; set; }
        private ICorreioService correioService;
        public double peso { get; set; }
        public double dimensoes { get; set; }

     
        public Frete(ICorreioService _correioService)
        {
            correioService = _correioService;
        }

        public double CalculaFrete() {
            //return correioService.CalculaFrete();
            return 5.6;
        
        }
    }
}
