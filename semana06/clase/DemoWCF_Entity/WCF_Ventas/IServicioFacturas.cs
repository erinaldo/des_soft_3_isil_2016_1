using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioFacturas
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        List<FacturaBE> GetAllFacturasClienteFechasLINQ(String strCod, DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<FacturaBE> GetAllFacturasClienteFechas(String strCod, DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<FacturaBE> GetFacturasVendedorFechasLINQ(String strCod, DateTime fecini, DateTime fecfin);

        [OperationContract]
        List<FacturaBE> GetFacturasVendedorFechas(String strCod, DateTime fecini, DateTime fecfin);

        // TODO: agregue aquí sus operaciones de servicio
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    [Serializable]

    public class FacturaBE
    {
        private String mvarnum_fac;
        private DateTime mcarfec_fac;
        private String mcarcod_cli;
        private DateTime mcarfec_can;
        private Single mcartotal;
        private String mcarest_fac;
        private String mcarestado;
        private String mcarcod_ven;
        private String mcarpor_igv;

        [DataMember]
        public String Num_fac
        {
            get { return mvarnum_fac; }
            set { mvarnum_fac = value; }
        }

        [DataMember]
        public DateTime Fec_fac
        {
            get { return mcarfec_fac; }
            set { mcarfec_fac = value; }
        }

        [DataMember]
        public String Cod_cli
        {
            get { return mcarcod_cli; }
            set { mcarcod_cli = value; }
        }

        [DataMember]
        public DateTime Fec_can
        {
            get { return mcarfec_can; }
            set { mcarfec_can = value; }
        }

        [DataMember]
        public Single Total
        {
            get { return mcartotal; }
            set { mcartotal = value; }
        }

        [DataMember]
        public String Est_fac
        {
            get { return mcarest_fac; }
            set { mcarest_fac = value; }
        }

        [DataMember]
        public String Estado
        {
            get { return mcarestado; }
            set { mcarestado = value; }
        }

        [DataMember]
        public String Cod_ven
        {
            get { return mcarcod_ven; }
            set { mcarcod_ven = value; }
        }

        [DataMember]
        public String Por_igv
        {
            get { return mcarpor_igv; }
            set { mcarpor_igv = value; }
        }

    }
}
