namespace DECO_Pets.Models.ViewModels
{
    public class ResultadosVM
    {
        public ResultadosVM() {
            Seguradoras = new List<Seguradora>();
            Premios = new List<Premios>();
        
        
        }
        public List<Seguradora> Seguradoras { get; set;}

        public List<Premios> Premios { get; set;}
    }
}
