using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace XF_ListView.Models
{
    public class TimeGrupo : List<Time>
    {
        public string Nome { get; set; }
        public string CriterioGrupo { get; set; }

        public TimeGrupo(string nome, string criteriogrupo)
        {
            Nome = nome;
            CriterioGrupo = criteriogrupo;
        }
    }
}
