using EstoqueWeb.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueWeb.Infra.Data.Interfaces
{
    /// <summary>
    /// Interface de repositorio para a entidade Produto
    /// </summary>
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        /// <summary>
        /// Método pra retornar todos os produtos
        /// dentro de um período de datas
        /// </summary>
        /// <param name="DataMin">Data de inicio</param>
        /// <param name="DataMax">Data de termino</param>
        /// <returns></returns>
        List<Produto> GetByDatas(DateTime? dataMin, DateTime? dataMax, int? ativo);
    }
}
