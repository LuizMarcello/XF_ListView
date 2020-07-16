using System;
using System.Collections.Generic;
using System.Text;

namespace XF_ListView.Models
{
    class ProdutoGrupo : List<Produto>
    {
        public string Nome { get; set; }
        public string CriterioGrupo { get; set; }

        public ProdutoGrupo(string nome, string criterio)
        {
            Nome = nome;
            CriterioGrupo = criterio;
        }
    }
}
