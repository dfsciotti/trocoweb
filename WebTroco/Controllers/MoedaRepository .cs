namespace WebTroco.Controllers
{
    public class MoedaRepository
    {
        public MoedaRepository()
        {

        }

        public int[] RetornaOpcoesMoeda()
        {
            return Moedas.Opcoes;
        }
    }
}
