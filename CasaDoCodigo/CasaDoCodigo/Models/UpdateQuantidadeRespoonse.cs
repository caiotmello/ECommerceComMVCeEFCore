using CasaDoCodigo.Models.ViewModels;

namespace CasaDoCodigo.Models
{
    public class UpdateQuantidadeRespoonse
    {
        public ItemPedido ItemPedido { get; }
        public CarrinhoViewModel CarrinhoViewModel { get; }

        public UpdateQuantidadeRespoonse(ItemPedido itemPedido, CarrinhoViewModel carrinhoViewModel)
        {
            ItemPedido = itemPedido;
            CarrinhoViewModel = carrinhoViewModel;
        }

    }
}
