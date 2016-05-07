using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Cliente" en el código y en el archivo de configuración a la vez.
    public class Cliente : ICliente
    {
        public Single CalcularDeudaCliente(string strCod)
        {
            return 0;
        }

        public Single CalcularDeudaClienteLINQ(string strCod)
        {
            VentasLeonEntities1 MisVentas = new VentasLeonEntities1();
            Single sngDeuda = 0;

            try {
                sngDeuda = Convert.ToSingle(
                        (from Fact in MisVentas.vw_VistaFacturas
                        where Fact.Cod_cli == strCod && Fact.Est_fac == "1"
                        select Fact.Total).Sum()
                    );
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }

            return sngDeuda;
        }


        public List<ClienteBE> ListarRazonSocialCliente()
        {
            VentasLeonEntities1 MisVentas = new VentasLeonEntities1();
            List<ClienteBE> objListaCliente = new List<ClienteBE>();

            try {
                var query = from objcliente in MisVentas.Tb_Cliente
                            orderby objcliente.Raz_soc_cli
                            select new { Codigo = objcliente.Cod_cli, RSocial = objcliente.Raz_soc_cli };

                foreach (var resultado in query) {
                    ClienteBE obj = new ClienteBE();

                    obj.codCli = resultado.Codigo;
                    obj.RazSocCli = resultado.RSocial;

                    objListaCliente.Add(obj);
                }

            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }

            return objListaCliente;
        }
    }
}
