using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebContratos.Models
{
    public class Listacontrato
    {
        private int contratoID;
        private string nomeMutuario;
        private string dataAssinatura;
        private string strContratoId;

        public Listacontrato(int contratoID, string nomeMutuario, string dataAssinatura, string strContratoId)
        {
            this.contratoID = contratoID;
            this.nomeMutuario = nomeMutuario;
            this.dataAssinatura = dataAssinatura;
            this.strContratoId = strContratoId;
        }

        public int ContratoID {
            get { return contratoID; }
            set { contratoID = value; }
        }


        public string NomeMutuario {
            get { return nomeMutuario; }
            set { nomeMutuario = value; }
        }

        public string DataAssinatura {
            get { return dataAssinatura; }
            set { dataAssinatura = value; }
        }

        public string StrContratoId {
            get { return strContratoId; }
            set { strContratoId = value; }
        }
    }
}
