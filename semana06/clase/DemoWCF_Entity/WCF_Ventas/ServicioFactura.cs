using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Ventas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServicioFactura : IServicioFacturas
    {
        public List<FacturaBE> GetAllFacturasClienteFechas(string strCod, DateTime fecini, DateTime fecfin)
        {
            VentasLeonEntities1 MisVentas = new VentasLeonEntities1();
            List<FacturaBE> objListaFacturaBE = new List<FacturaBE>();

            try
            {
                var query = MisVentas.ListarFacturasClienteFechas(strCod, fecini, fecfin);

                foreach (var resultado in query)
                {
                    FacturaBE obj = new FacturaBE();
                    obj.Num_fac = resultado.num_fac;
                    obj.Fec_fac = Convert.ToDateTime(resultado.fec_fac);
                    obj.Fec_can = Convert.ToDateTime(resultado.fec_can);
                    obj.Total = Convert.ToSingle(resultado.total);
                    obj.Estado = resultado.estado;

                    objListaFacturaBE.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return objListaFacturaBE;
        }

        public List<FacturaBE> GetAllFacturasClienteFechasLINQ(string strCod, DateTime fecini, DateTime fecfin)
        {
            VentasLeonEntities1 MisVentas = new VentasLeonEntities1();
            List<FacturaBE> objListaFacturaBE = new List<FacturaBE>();

            try {
                var query = (from Fact in MisVentas.vw_VistaFacturas
                             where Fact.Cod_cli == strCod &&
                             Fact.Fec_fac >= fecini &&
                             Fact.Fec_fac <= fecfin
                             select new {
                                 Numero = Fact.Num_fac, FechaFact = Fact.Fec_fac, FechaCan = Fact.Fec_can,
                                 Estado = Fact.Estado, Total = Fact.Total
                             });

                foreach (var resultado in query) {
                    FacturaBE obj = new FacturaBE();
                    obj.Num_fac = resultado.Numero;
                    obj.Fec_fac = Convert.ToDateTime(resultado.FechaFact);
                    obj.Fec_can = Convert.ToDateTime(resultado.FechaCan);
                    obj.Total = Convert.ToSingle(resultado.Total);
                    obj.Estado = resultado.Estado;

                    objListaFacturaBE.Add(obj);
                }

            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }

            return objListaFacturaBE;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<FacturaBE> GetFacturasVendedorFechas(string strCod, DateTime fecini, DateTime fecfin)
        {
            VentasLeonEntities1 MisVentas = new VentasLeonEntities1();
            List<FacturaBE> objListaFacturaBE = new List<FacturaBE>();

            try
            {
                var query = MisVentas.ListarFacturasVendedorFechas(strCod, fecini, fecfin);

                foreach (var resultado in query)
                {
                    FacturaBE obj = new FacturaBE();
                    obj.Num_fac = resultado.num_fac;
                    obj.Fec_fac = Convert.ToDateTime(resultado.fec_fac);
                    obj.Fec_can = Convert.ToDateTime(resultado.fec_can);
                    obj.Total = Convert.ToSingle(resultado.total);
                    obj.Estado = resultado.estado;

                    objListaFacturaBE.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return objListaFacturaBE;
        }

        public List<FacturaBE> GetFacturasVendedorFechasLINQ(string strCod, DateTime fecini, DateTime fecfin)
        {
            VentasLeonEntities1 MisVentas = new VentasLeonEntities1();
            List<FacturaBE> objListaFacturaBE = new List<FacturaBE>();

            try
            {
                var query = (from Fact in MisVentas.vw_VistaFacturas
                             where Fact.Cod_ven == strCod &&
                             Fact.Fec_fac >= fecini &&
                             Fact.Fec_fac <= fecfin
                             select new
                             {
                                 Numero = Fact.Num_fac,
                                 FechaFact = Fact.Fec_fac,
                                 FechaCan = Fact.Fec_can,
                                 Estado = Fact.Estado,
                                 Total = Fact.Total
                             });

                foreach (var resultado in query)
                {
                    FacturaBE obj = new FacturaBE();
                    obj.Num_fac = resultado.Numero;
                    obj.Fec_fac = Convert.ToDateTime(resultado.FechaFact);
                    obj.Fec_can = Convert.ToDateTime(resultado.FechaCan);
                    obj.Total = Convert.ToSingle(resultado.Total);
                    obj.Estado = resultado.Estado;

                    objListaFacturaBE.Add(obj);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return objListaFacturaBE;
        }
    }
}
