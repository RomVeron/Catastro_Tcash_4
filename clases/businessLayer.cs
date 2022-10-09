using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace f2
{
    /// <summary>
    /// Aqui va todo el codigo del developer
    /// que relaciona formulario con el mundo exterior.
    /// </summary>
    public class businessLayer
    {
        public readonly string[] ticketSb = new string[2];
        public string[] idInstanciaSb = new string[2];
        readonly sb.servicebus elSb = new sb.servicebus();
        private string[] noise = new string[2];
        private string[] ticketResult = new string[2];
        private string mensaje;
        private string _usuario;

        #region Interno

        public businessLayer() { mensaje = " "; }
        public businessLayer(string usuario) { this.usuario = usuario; }

        public void agregarConexion(int posicion, string i_ticketSb, string i_idInstanacia)
        {
            ticketSb[posicion] = i_ticketSb;
            idInstanciaSb[posicion] = i_idInstanacia;
        }
        public string getMensaje() { return this.mensaje; }
        public void setMensaje(string m) { this.mensaje = m; }

        private int _cod_err;
        public int cod_err { get { return _cod_err; } }

        private string _msj_err;

        public string msj_err { get { return _msj_err; } }

        /// <summary>
        /// Generar token de conexion sl SB.
        /// </summary>
        private void generar() { generar(0); }
        /// <summary>
        /// Generar token de conexion sl SB.
        /// </summary>
        /// <param name="posicion"></param>
        private void generar(int posicion)
        {
            noise[posicion] = DateTime.Now.Ticks.ToString();
            ticketResult[posicion] = utiles.GetMD5(ticketSb[posicion] + noise[posicion]);
        }
        /// <summary>
        /// Gevuelve ticket de conexion actual al SB.
        /// </summary>
        /// <returns></returns>
        private string elTicket() { return elTicket(0); }
        /// Devuelve ticket de conexion actual al SB.
        private string elTicket(int posicion)
        {
            return ticketResult[posicion];
        }
        /// <summary>
        /// La semilla para ocultar el ticket de sesion en la comunicacion.
        /// </summary>
        /// <returns></returns>
        private string elNoise() { return elNoise(0); }
        /// <summary>
        /// La semilla para ocultar el ticket de sesion en la comunicacion
        /// </summary>
        /// <param name="posicion"></param>
        /// <returns></returns>
        private string elNoise(int posicion)
        {
            return noise[posicion];
        }
        /// <summary>
        /// Devuelve la instancia de conexion a la BD.
        /// </summary>
        /// <returns></returns>
        private string laInstanacia() { return laInstanacia(0); }
        /// <summary>
        /// Devuelve la instancia de conexion a la BD.
        /// </summary>
        /// <param name="posicion"></param>
        /// <returns></returns>
        private string laInstanacia(int posicion)
        {
            return idInstanciaSb[posicion];
        }

        /// <summary>
        /// Datos usuario.
        /// </summary>        
        public int _codcamino;
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        #endregion

        #region CÓDIGO --> [DESARROLLADOR] 

        /// <summary>
        /// Método que obtiene el número de manual del programa.
        /// </summary>
        /// <returns></returns>
        public string sp_dt_param_menu()
        {
            /*wilson1.pkg_carta_referencia.sp_dt_param_menu(v_menu => :v_menu);*/
            try
            {
                var losParametros = new sb.elParametro[1];
                losParametros[0] = new sb.elParametro() { nombre = "v_menu", esOut = true, tipoDato = sb.tipoDeDatos.Varchar2 };
                generar();

                var elVuelto = elSb.intOracle("userweb.w_corporativo2.sp_dt_param_menu", losParametros, elTicket(), laInstanacia(), elNoise());
                return elVuelto.resultado.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
        /// <summary>
        /// Método que devuelve las hojas habilitadas para cada usuario -> [Contrato Único].
        /// </summary>
        /// <param name="v_user"></param>
        /// <param name="v_prog"></param>
        /// <returns></returns>
        public sb.SBdataset sp_permisos(string v_user, int v_prog)
        {
            /*wilson1.pkg_control_sistema.sp_permisos(pi_user     => :pi_user,
                                                      pi_prog_key => :pi_prog_key,
                                                      po_cursor   => :po_cursor);*/
            var losParametros = new sb.elParametro[3];
            losParametros[0] = new sb.elParametro() { nombre = "v_user", esOut = false, elObjeto = v_user };
            losParametros[1] = new sb.elParametro() { nombre = "v_prog", esOut = false, elObjeto = v_prog };
            losParametros[2] = new sb.elParametro() { nombre = "po_datos", esOut = true, tipoDato = sb.tipoDeDatos.RefCursor };

            // Generamos datos de seguridad.
            generar();

            // Llamamos a la BD.
            var elvuelto = elSb.datasetOracle("wilson1.pkg_control_sistema.sp_permisos",
                losParametros, elTicket(), laInstanacia(), elNoise());

            return elvuelto;
        }

        
        /// <summary>
        /// Método que obtiene la sucursal del usuario de Carga.
        /// </summary>
        /// <param name="pi_user"></param>
        /// <returns></returns>
        public string sp_sucursal_user(string pi_user)
        {           
            try
            {

                var losParametros = new sb.elParametro[2];
                losParametros[0] = new sb.elParametro() { nombre = "pi_user", elObjeto = pi_user };
                losParametros[1] = new sb.elParametro() { nombre = "v_sucursal", esOut = true, tipoDato = sb.tipoDeDatos.Varchar2 };

                // Generamos datos de seguridad.
                generar();

                // Llamamos a la BD.
                elSb.Timeout = 15 * 60 * 1000;
                var elVuelto = elSb.stringOracle("userweb.w_corporativo2.sp_sucursal_user",
                    losParametros, elTicket(), laInstanacia(), elNoise());

                return elVuelto.resultado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        /// <summary>
        /// Método que obtiene el nombre del cliente.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public string sp_nombre_cliente(string cliente)
        {
            try
            {
                var losParametros = new sb.elParametro[2];
                losParametros[0] = new sb.elParametro() { nombre = "pi_cliekey", elObjeto = cliente };
                losParametros[1] = new sb.elParametro() { nombre = "po_retorno", esOut = true, tipoDato = sb.tipoDeDatos.Varchar2 };

                // Generamos datos de seguridad.
                generar();

                // Llamamos a la BD.
                elSb.Timeout = 15 * 60 * 1000;
                var elVuelto = elSb.stringOracle("userweb.w_corporativo2.sp_nombre_cliente",
                    losParametros, elTicket(), laInstanacia(), elNoise());

                return elVuelto.resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que obtiene el listado de productos que tiene un cliente.
        /// </summary>
        /// <param name="pi_cliekey"></param>
        /// <returns></returns>
        public sb.SBdataset sp_cuentas_client(string pi_cliekey)
        {            
            var losParametros = new sb.elParametro[2];
            losParametros[0] = new sb.elParametro() { nombre = "pi_cliekey", elObjeto = pi_cliekey };
            losParametros[1] = new sb.elParametro() { nombre = "po_result", esOut = true, tipoDato = sb.tipoDeDatos.RefCursor };

            // Generamos datos de seguridad.
            generar();

            // Llamamos a la BD.
            try
            {
                var elvuelto = elSb.datasetOracle("userweb.w_corporativo2.sp_cuentas_client", losParametros, elTicket(), laInstanacia(), elNoise());

                return elvuelto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que obtiene el monto de la línea de crédito del cliente.
        /// </summary>
        /// <param name="pi_cliekey"></param>
        /// <returns></returns>
        public sb.SBdataset sp_monto_linea_credito(string pi_cliekey)
        {            
            var losParametros = new sb.elParametro[2];
            losParametros[0] = new sb.elParametro() { nombre = "pi_cliekey", elObjeto = pi_cliekey };
            losParametros[1] = new sb.elParametro() { nombre = "po_result", esOut = true, tipoDato = sb.tipoDeDatos.RefCursor };

            // Generamos datos de seguridad.
            generar();

            // Llamamos a la BD.
            try
            {
                var elvuelto = elSb.datasetOracle("userweb.w_corporativo2.sp_monto_linea_credito", losParametros, elTicket(), laInstanacia(), elNoise());

                return elvuelto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que obtiene las tarjetas vigentes del cliente.
        /// </summary>
        /// <param name="pi_cliekey"></param>
        /// <returns></returns>
        public sb.SBdataset sp_tar_vigentes_cliente(string pi_cliekey)
        {
            var losParametros = new sb.elParametro[2];
            losParametros[0] = new sb.elParametro() { nombre = "pi_cliekey", elObjeto = pi_cliekey };
            losParametros[1] = new sb.elParametro() { nombre = "po_result", esOut = true, tipoDato = sb.tipoDeDatos.RefCursor };

            // Generamos datos de seguridad.
            generar();

            // Llamamos a la BD.
            try
            {
                var elvuelto = elSb.datasetOracle("userweb.w_corporativo2.sp_tar_vigentes_cliente", losParametros, elTicket(), laInstanacia(), elNoise());

                return elvuelto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que las retorna las cuentas corrientes del cliente.
        /// </summary>
        /// <param name="pi_cliekey"></param>
        /// <returns></returns>
        public sb.SBdataset sp_cta_cte_cliente(string pi_cliekey)
        {
            var losParametros = new sb.elParametro[2];
            losParametros[0] = new sb.elParametro() { nombre = "pi_cliekey", elObjeto = pi_cliekey };
            losParametros[1] = new sb.elParametro() { nombre = "po_result", esOut = true, tipoDato = sb.tipoDeDatos.RefCursor };

            // Generamos datos de seguridad.
            generar();

            // Llamamos a la BD.
            try
            {
                var elvuelto = elSb.datasetOracle("userweb.w_corporativo2.sp_cta_cte_cliente", losParametros, elTicket(), laInstanacia(), elNoise());

                return elvuelto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Método que retorna las cajas de ahorro del cliente.
        /// </summary>
        /// <param name="pi_cliekey"></param>
        /// <returns></returns>
        public sb.SBdataset sp_caja_ahorro_cliente(string pi_cliekey)
        {
            /*wilson1.pkg_carta_referencia.sp_caja_ahorro_cliente(pi_cliekey => :pi_cliekey,
                                                                  po_result  => :po_result);*/

            var losParametros = new sb.elParametro[2];
            losParametros[0] = new sb.elParametro() { nombre = "pi_cliekey", elObjeto = pi_cliekey };
            losParametros[1] = new sb.elParametro() { nombre = "po_result", esOut = true, tipoDato = sb.tipoDeDatos.RefCursor };

            // Generamos datos de seguridad.
            generar();

            // Llamamos a la BD.
            try
            {
                var elvuelto = elSb.datasetOracle("userweb.w_corporativo2.sp_caja_ahorro_cliente", losParametros, elTicket(), laInstanacia(), elNoise());

                return elvuelto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Método que retorna las cuentas por Cod. Cliente.
        /// </summary>
        /// <param name="pi_cliekey"></param>
        /// <returns></returns>
        public sb.SBdataset sp_buscar_ctas_cocliente(string pi_cliekey)
        {
            /*wilson1.pkg_carta_referencia.sp_buscar_ctas_cocliente(pi_cliekey => :pi_cliekey,
                                                                    po_cursor  => :po_cursor);*/

            var losParametros = new sb.elParametro[2];
            losParametros[0] = new sb.elParametro() { nombre = "pi_cliekey", elObjeto = pi_cliekey };
            losParametros[1] = new sb.elParametro() { nombre = "po_cursor", esOut = true, tipoDato = sb.tipoDeDatos.RefCursor };

            // Generamos datos de seguridad.
            generar();

            // Llamamos a la BD.
            try
            {
                var elvuelto = elSb.datasetOracle("userweb.w_corporativo2.sp_buscar_ctas_cocliente", losParametros, elTicket(), laInstanacia(), elNoise());

                return elvuelto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public sb.SBdataset sp_lista_info_tcash_catastro(string pi_usu)
        {
            /*wilson1.pkg_carta_referencia.sp_lista_empresa_entidad(po_result => :po_result);*/

            var losParametros = new sb.elParametro[2];
            losParametros[0] = new sb.elParametro() { nombre = "pi_usu", elObjeto = pi_usu };
            losParametros[1] = new sb.elParametro() { nombre = "po_result", esOut = true, tipoDato = sb.tipoDeDatos.RefCursor };

            // Generamos datos de seguridad.
            generar();

            // Llamamos a la BD.
            try
            {
                var elvuelto = elSb.datasetOracle("userweb.w_corporativo2.sp_lista_info_tcash_catastro", losParametros, elTicket(), laInstanacia(), elNoise());

                return elvuelto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public sb.SBdataset sp_catastrar_tigomoney(string pi_clie_key,
                                                   string pi_telefono,
                                                   string pi_cuenta,                                                   
                                                   string pi_estado,
                                                   string pi_usu_add,
                                                   string pi_operacion)
        {
            try
            {
                var losParametros = new sb.elParametro[7];
                losParametros[0] = new sb.elParametro() { nombre = "pi_clie_key", elObjeto = pi_clie_key };
                losParametros[1] = new sb.elParametro() { nombre = "pi_telefono", elObjeto = pi_telefono };
                losParametros[2] = new sb.elParametro() { nombre = "pi_cuenta", elObjeto = pi_cuenta };
                losParametros[3] = new sb.elParametro() { nombre = "pi_estado", elObjeto = pi_estado };
                losParametros[4] = new sb.elParametro() { nombre = "pi_usu_add", elObjeto = pi_usu_add };
                losParametros[5] = new sb.elParametro() { nombre = "pi_operacion", elObjeto = pi_operacion };
                losParametros[6] = new sb.elParametro() { nombre = "po_retorno", esOut = true, tipoDato = sb.tipoDeDatos.RefCursor };


                // Generamos datos de seguridad.
                generar();

                // Llamamos a la BD.
                elSb.Timeout = 15 * 60 * 1000;
                var elVuelto = elSb.datasetOracle("userweb.w_corporativo2.sp_catastrar_tigomoney",
                    losParametros, elTicket(), laInstanacia(), elNoise());

                return elVuelto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void sp_catastrar_tigomoney_path(string pi_clie_key,
                                                string pi_file_path)
        {
            try
            {
                var losParametros = new sb.elParametro[2];
                losParametros[0] = new sb.elParametro() { nombre = "pi_clie_key", elObjeto = pi_clie_key };
                losParametros[1] = new sb.elParametro() { nombre = "pi_file_path", elObjeto = pi_file_path };

                // Generamos datos de seguridad.
                generar();

                // Llamamos a la BD.
                elSb.Timeout = 15 * 60 * 1000;
                var elVuelto = elSb.datasetOracle("userweb.w_corporativo2.sp_catastrar_tigomoney_path",
                    losParametros, elTicket(), laInstanacia(), elNoise());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void sp_catastrar_tigomoney_autorizar(string pi_id,
                                                     string pi_usu_mod,
                                                     string pi_estado)
        {
            try
            {
                var losParametros = new sb.elParametro[3];
                losParametros[0] = new sb.elParametro() { nombre = "pi_id", elObjeto = pi_id };
                losParametros[1] = new sb.elParametro() { nombre = "pi_usu_mod", elObjeto = pi_usu_mod };
                losParametros[2] = new sb.elParametro() { nombre = "pi_estado", elObjeto = pi_estado };

                // Generamos datos de seguridad.
                generar();

                // Llamamos a la BD.
                elSb.Timeout = 15 * 60 * 1000;
                var elVuelto = elSb.datasetOracle("userweb.w_corporativo2.sp_catastrar_tigomoney_autorizar",
                    losParametros, elTicket(), laInstanacia(), elNoise());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public sb.SBdataset sp_lis_tcash_cata_rep(string pi_clie_key,
                                                                 string pi_cuenta,
                                                                 string pi_nrotigo,
                                                                 string pi_fecha_ini,
                                                                 string pi_fecha_fin)
        {

            var losParametros = new sb.elParametro[6];
            losParametros[0] = new sb.elParametro() { nombre = "pi_clie_key", elObjeto = pi_clie_key };
            losParametros[1] = new sb.elParametro() { nombre = "pi_cuenta", elObjeto = pi_cuenta };
            losParametros[2] = new sb.elParametro() { nombre = "pi_nrotigo", elObjeto = pi_nrotigo };
            losParametros[3] = new sb.elParametro() { nombre = "pi_fecha_ini", elObjeto = pi_fecha_ini };
            losParametros[4] = new sb.elParametro() { nombre = "pi_fecha_fin", elObjeto = pi_fecha_fin };
            losParametros[5] = new sb.elParametro() { nombre = "po_result", esOut = true, tipoDato = sb.tipoDeDatos.RefCursor };

            // Generamos datos de seguridad.
            generar();

            // Llamamos a la BD.
            try
            {
                var elvuelto = elSb.datasetOracle("userweb.w_corporativo2.sp_lis_tcash_cata_rep", losParametros, elTicket(), laInstanacia(), elNoise());

                return elvuelto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public sb.SBdataset sp_report_catastro_tmoney(string pi_id_catastro)
        {

            var losParametros = new sb.elParametro[2];
            losParametros[0] = new sb.elParametro() { nombre = "pi_id_catastro", elObjeto = pi_id_catastro };
            losParametros[1] = new sb.elParametro() { nombre = "po_result", esOut = true, tipoDato = sb.tipoDeDatos.RefCursor };

            // Generamos datos de seguridad.
            generar();

            // Llamamos a la BD.
            try
            {
                var elvuelto = elSb.datasetOracle("userweb.w_corporativo2.sp_report_catastro_tmoney", losParametros, elTicket(), laInstanacia(), elNoise());

                return elvuelto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        #endregion

    }
}
