using Dapper;
using EstoqueWeb.Infra.Data.Entities;
using EstoqueWeb.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueWeb.Infra.Data.Repositories
{
    /// <summary>
    /// Classe para implementar as operações de banco de dados para Produtos
    /// </summary>
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly string _connectionstring;

        public ProdutoRepository(string connectionstring)
        {
            _connectionstring = connectionstring;

        }

        public void Create(Produto obj)
        {
            var query = @"
                INSERT INTO EVENTO(ID, NOME, PRECO, QUANTIDADE, DATA, DESCRICAO, DATAINCLUSAO, DATAALTERACAO)
                VALUES(@Id, @Nome, @Preco, @Quantidade, @Data, @Descricao, @DataInclusao, @DataAlteracao)
        ";

            //conectando no banco de dados
            using var connection = new SqlConnection(_connectionstring);

            //executando a gravação do evento na base de dados
            connection.Execute(query, obj);

        }

        public void Update(Produto obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Produto obj)
        {
            throw new NotImplementedException();
        }

        public List<Produto> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Produto> GetByDatas(DateTime? dataMin, DateTime? dataMax, int? ativo)
        {
            throw new NotImplementedException();
        }

        public Produto GetById(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}
