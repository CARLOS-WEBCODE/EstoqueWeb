using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueWeb.Infra.Data.Entities
{
    /// <summary>
    /// Classe de entidade para Produto
    /// </summary>
    public class Produto
    {
        #region Propriedades

        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public string? Quantidade { get; set; }
        public DateTime? Data { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int? Ativo { get; set; }


        #endregion
    }
}
