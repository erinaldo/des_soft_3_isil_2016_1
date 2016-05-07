using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICliente
    {
        [OperationContract]
        Single CalcularDeudaCliente(String strCod);

        List<ClienteBE> ListarRazonSocialCliente();

        Single CalcularDeudaClienteLINQ(String strCod);
    }

    [DataContract]
    [Serializable]
    public class ClienteBE  // definimos la clase ClienteBE como Data Contractual
    {
        //Miembros privados
        private string _codCli;
        private string _RazSocCli;
        private string _DirCli;
        private string _TelCli;
        private string _RucCli;
        private string _CodDis;
        private string _NomDis;
        private System.DateTime _FecReg;
        private string _TipCli;
        private string _Contacto;

        // Cada propiedad es un DataMember de la Data Contractual
        [DataMember]
        public string codCli
        {
            get { return this._codCli; }
            set { this._codCli = value; }
        }

        [DataMember]
        public string RazSocCli
        {
            get { return this._RazSocCli; }
            set { this._RazSocCli = value; }
        }
        [DataMember]
        public string DirCli
        {
            get { return this._DirCli; }
            set { this._DirCli = value; }
        }
        [DataMember]
        public string TelCli
        {
            get { return this._TelCli; }
            set { this._TelCli = value; }
        }
        [DataMember]
        public string RucCli
        {
            get { return this._RucCli; }
            set { this._RucCli = value; }
        }
        [DataMember]
        public string CodDis
        {
            get { return this._CodDis; }
            set { this._CodDis = value; }
        }
        [DataMember]
        public string NomDis
        {
            get { return this._NomDis; }
            set { this._NomDis = value; }
        }
        [DataMember]
        public System.DateTime FecReg
        {
            get { return this._FecReg; }
            set { this._FecReg = value; }
        }
        [DataMember]
        public string TipCLi
        {
            get { return this._TipCli; }
            set { this._TipCli = value; }
        }
        [DataMember]
        public string Contacto
        {
            get { return this._Contacto; }
            set { this._Contacto = value; }
        }

    }
}
