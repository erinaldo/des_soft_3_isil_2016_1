using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFTransacciones
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [TransactionFlow(TransactionFlowOption.Allowed)]
        [OperationContract]
        Single RestarSaldo(SaldoCliente saldo);

        // TODO: agregue aquí sus operaciones de servicio
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    // Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "WCFTransacciones.ContractType".
    [DataContract]
    public class SaldoCliente
    {
        private String _cliente;
        private Single _saldo;

        [DataMember]
        public String Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        [DataMember]
        public Single Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
    }
}
