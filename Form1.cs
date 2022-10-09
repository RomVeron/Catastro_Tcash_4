 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using f2;
using DevExpress.XtraEditors;
using System.Net;
using f2.productos;
using System.Text.RegularExpressions;
using DevExpress.LookAndFeel;
using f2.gui;
using f2.reportes;
using System.IO;
using System.Security.Cryptography;
using f2.clases;
using System.Globalization;

namespace f2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// conexion principal
        /// </summary>
        private businessLayer capaNegocios = new businessLayer();

        #region SETEOS BÁSICOS

        /// <summary>
        /// Estable si el form esta en produccion.
        /// </summary>
        private bool esProduccion = false;

        /// <summary>
        /// El usuario de oracle que viene de finansys.
        /// </summary>
        private string usuarioOracle = "";

        /// <summary>
        /// El password de oracle.
        /// </summary>
        private string passOracle = "";

        /// <summary>
        /// Los parametro recibidos desde finansys.
        /// </summary>
        private string parametros = "";

        /// <summary>
        /// El tns base de datos DATOSITA.
        /// </summary>
        private string tnsOracle = "DATOSITA";

        /// <summary>
        /// Establecer la version del archivo.
        /// </summary>
        f2.objFinanasys2 laSesion = new objFinanasys2();

        /// <summary>
        /// Para controlar cuando vamos a cerrar el formulario.
        /// </summary>
        private bool sepuedeCerrar = false;

        /// <summary>
        /// Código del programa.
        /// </summary>
        private int prog_key = 500172;

        /// <summary>
        /// Nombre de nuestra aplicación.
        /// </summary>
        private string nombreAplicacion = "Catastro_Tcash_4";

        /// <summary>
        /// Url serviceBus.
        /// </summary>
        private string urlServiceBus = "";

        /// <summary>
        /// Inicios varios...
        /// </summary>
        private void iniciosVarios()
        {
            barStaticItem2.Caption = "Versión: " + laSesion.version;
        }

        #endregion

        #region SETEOS VARIABLES

        private double monto_orignial = 0;
        private DataTable dt = new DataTable();
        private DataTable dt_tarjetas = new DataTable(); // Datos de la tarjeta de crédito.
        private DataTable dt_cta_cte = new DataTable(); // Datos de la cuenta corriente.
        private DataTable dt_caja_ahorro = new DataTable(); // Datos de la caja de ahorro.
        private DataTable dt_debito_cta = new DataTable(); // Datos de las cuentas a la cuál se puede realizar el debito.
        private WindowWait wait;

        private string v_pathArch = "MANTENIMIENTO_TIGO_MONEY\\"; //tiene la ruta donde se guarda el archivo en el server. // #PI21347 - Agregamos una nueva ruta        
        private string id_adjunto_nota = "";
        private string v_filtroImagen = "PDF(.pdf)|*.pdf"; // Formato soportado. //PI21781
        private string v_nombreArch = ""; //Tiene el Nombre del Archivo.
                
        private OpenFileDialog fileDialog = new OpenFileDialog();

        //CATASTRO TIGO MONEY
        private string sucursal_user = "";
        private string v_clie_key = "";
        private string v_nombre = "";
        private string v_telefono_cli = "";
        private string v_cuenta_cli = "";
        private string v_estado = "";
        private string v_operacion = "";
        private string v_file_path = ""; //Tiene la Ruta del Archivo.
        private string v_id_catastro_autorizar = ""; //Id del catastro de la grilla autorizar
        private string v_fecha_mod_autorizar = ""; //Fecha modificacion catastro
        private string v_usu_mod_autorizar = ""; //Usuario modifico catastro
        //private string v_clie_key_autorizar = ""; //Codigo del cliente autorizar
        private string v_estado_autorizar = ""; //Estado autorizar
       
        #endregion

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //version
            laSesion.version = "2209202271557";
       
            //seteos standart de clase
            iniciosVarios();
            this.Tag = (Object)laSesion;
        }
     
        /// <summary>
        /// cuando leemos el formulario por primera ves...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            #region C O N E X I Ó N

            esProduccion = false;
            if (esProduccion)
            {
                // Recupero los parametros recibidos desde finansys.
                f2.objFinanasys2 laSesion = (f2.objFinanasys2)this.Tag;
                usuarioOracle = laSesion.usuario;
                passOracle = laSesion.userPassword;
                parametros = laSesion.parametros;
                urlServiceBus = "https://servicebus.bancontinental.com.py/servicebus.asmx";
                tnsOracle = "SRVORACLE|dbitacua";
            }
            else
            {
            // Aquí podemos colocar los datos para trabajar en un sandBox.
                usuarioOracle = "VAR"; // ಠ_ಠ
                passOracle = "12345678";
                parametros = "";
                urlServiceBus = "https://servicebus.bancontinental.com.py/servicebus.asmx";
                tnsOracle = "10.6.2.148|dbitades";
            }

            capaNegocios = new businessLayer(usuarioOracle);

            // Aquí se estable la capa de negocios.
            using (var elSb = new sb.servicebus())
            {
                elSb.Url = urlServiceBus;
                System.Net.ServicePointManager.CertificatePolicy = new MyPolicy();
                var respuesta = new sb.SBstringAutenticacion() { elError = "TimeOut" };
                try { respuesta = gestorSB.autenticacion(usuarioOracle, passOracle, tnsOracle); }
                catch (Exception error)
                {
                    if (respuesta.elError == "TimeOut")
                        MessageBox.Show(String.Format("Problemas de conexion con el serviceBus, Error: TimeOut, favor contactar con soporte informatico. \r\n{0}, {1}",
                            error.Message, error.InnerException));
                    else
                        MessageBox.Show(String.Format("{0}, {1}", error.Message, error.InnerException));
                    Close();
                }

                if (respuesta.error.ToString() == "OK")
                {
                    capaNegocios.agregarConexion(0, respuesta.resultado, respuesta.instanciaUnica);
                }
                else { MessageBox.Show(String.Format("{0}, {1}", respuesta.elError, respuesta.error)); Close(); }
            }

            #endregion

            // Al principio podemos cerrar.
            this.sepuedeCerrar = true;

        }

        /// <summary>
        /// Evento Shown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {          
            sucursal_user = capaNegocios.sp_sucursal_user(usuarioOracle);
            cargaListaAutorizaciones();
            Bloquear_Grilla();
            cargarFechasReporte();
            barStaticItem3.Caption = "Usuario: " + usuarioOracle;
            Arma_Menu();
        }

        /// <summary>
        /// Método que arma el menu del programa en base a los permisos de cada usuario.
        /// </summary>
        private void Arma_Menu()
        {
            permisos();
        }

        #region VALIDACION CERTIFICADO SSL
        /// <summary>
        /// Clase para confiar en cualquier certificado.
        /// </summary>
        public class MyPolicy : ICertificatePolicy
        {
            public bool CheckValidationResult(ServicePoint srvPoint,
                System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                WebRequest request, Int32 certificateProblem)
            {
                return true;
            }
        }
        #endregion

        /// <summary>
        /// Cuando cerramos el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sepuedeCerrar)
            {
                string mensaje = String.Format("Desea cerrar el programa?");
                DialogResult result = XtraMessageBox.Show(mensaje, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    e.Cancel = true;

            }
            else { e.Cancel = true; }
        }

        /// <summary>
        /// Nos permite cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Permisos sobre las pestañas del programa.
        /// </summary>
        public void permisos()
        {
            try
            {
                DataTable permisos = capaNegocios.sp_permisos(usuarioOracle, prog_key).resultado.Tables[0];

                if (capaNegocios.cod_err != 0)
                {
                    XtraMessageBox.Show(this, capaNegocios.msj_err, "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    #region PERMISOS SOBRE CONTROLES

                    if (permisos.Rows.Count > 0)
                    {
                        foreach (DataRow row in permisos.Rows)
                        {
                            if (row["PROG_NOMBRE"].ToString().Trim() == "tabAutorizador")
                            {
                                this.tabAutorizador.PageVisible = true;
                                cargaListaAutorizaciones();
                            }
                        }
                    }
                    else
                    {
                        this.tabAutorizador.PageVisible = false;
                    }
                }
            }
            #endregion
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocurrió el siguiente error: " + ex.ToString() + " - Favor contacte con informática.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #region MÓDULO - CARTA REFERENCIA

        /// <summary>
        /// Evento clic del botón -> Guardar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {           
            
            // Verificamos el tipo de formato de la carta.
            if (rgTipoCatastro.EditValue.ToString().Equals("I")) // Catastro Entrada
            {
                //Validamos si se ingresaron los campos solicitados.
                if (validar())
                {
                    v_operacion = "1";
                    bkGuardar.RunWorkerAsync();
                    wait = new WindowWait("Enviando solicitud, Aguarde un momento...");
                    wait.ShowDialog();
                    btLimpiarCarta();
                }
            }
            else if (rgTipoCatastro.EditValue.ToString().Equals("O")) // Catastro Salida
            {
                //Validamos si se ingresaron los campos solicitados.
                if (validar())
                {
                    v_operacion = "2";
                    bkGuardar.RunWorkerAsync();
                    wait = new WindowWait("Enviando solicitud, Aguarde un momento...");
                    wait.ShowDialog();
                    btLimpiarCarta();
                }
            }
            else if (rgTipoCatastro.EditValue.ToString().Equals("A")) // Catastro Ambos             
            {
                v_clie_key = txtCodCliente.EditValue.ToString();
                v_telefono_cli = txtTelefono.EditValue.ToString();
                v_cuenta_cli = combo_debito_cuenta.EditValue.ToString().Trim();
                v_estado = "0";
                v_file_path = txtFormulario.EditValue.ToString();
                //Validamos si se ingresaron los campos solicitados.
                if (validar())
                {
                    v_operacion = "1";
                    capaNegocios.sp_catastrar_tigomoney(v_clie_key, v_telefono_cli, v_cuenta_cli, v_estado, usuarioOracle, v_operacion);
                    capaNegocios.sp_catastrar_tigomoney_path(v_clie_key, v_file_path); //Registrar el path en la base de datos
                    v_operacion = "2";
                    bkGuardar.RunWorkerAsync();
                    wait = new WindowWait("Enviando solicitud, Aguarde un momento...");
                    wait.ShowDialog();
                    btLimpiarCarta();
                    //cargaListaOperaciones();
                }
            }
                        
            
        }

        /// <summary>
        /// Validaciones de carga.
        /// </summary>
        /// <returns></returns>
        private bool validar()
        {

            int band = 1;            
            // Código del cliente.
            if (txtCodCliente.Text.ToString().Trim().Equals(""))
            {
                err_cliente.SetError(txtNombreCliente, "Cod. Cliente -> Campo Obligatorio");
                band = 0;
            }
            else
            {
                err_cliente.Dispose();
            }
            
            // Verificamos si existen registros.
            if (dt_debito_cta.Rows.Count > 0)
            {
                if (combo_debito_cuenta.Text.ToString().Trim().Equals(""))
                {
                    err_debito_cuenta.SetError(combo_debito_cuenta, "Campo Obligatorio");
                    band = 0;
                }
                else
                {
                    err_debito_cuenta.Dispose();
                }
            }
            else
            {
                err_debito_cuenta.Dispose();
                rgTipoCatastro.SelectedIndex = 1;
            }
            
            if (band.Equals(0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Evento click del manual de usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btManual_Click(object sender, EventArgs e)
        {
            try
            {
                F2Lanza.Principal f = new F2Lanza.Principal("SRVORACLE|dbitacua", "Manuales_4", capaNegocios.sp_dt_param_menu(), usuarioOracle, passOracle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento clic del botón Limpiar Carta Referencia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLimpiarCarta_Click(object sender, EventArgs e)
        {
            btLimpiarCarta();
        }

        /// <summary>
        /// Método que limpia los campos.
        /// </summary>
        private void btLimpiarCarta()
        {   

            // Cliente.
            txtCodCliente.Text = null;
            
            // Nombre del Cliente.
            txtNombreCliente.Text = null;
            
            // Numero del Cliente
            txtTelefono.Text = null;

            // Ruta del archivo
            txtFormulario.Text = null;
                        
            // Tipo de Pago.
            rgTipoCatastro.SelectedIndex = 0;

            // Combo Debito en Cuenta.
            combo_debito_cuenta.EditValue = "";
            combo_debito_cuenta.Enabled = true;

            // Limpiar datos de los dataTable.
            dt_tarjetas.Clear(); // Datos de la tarjeta de crédito.
            dt_cta_cte.Clear(); // Datos de la cuenta corriente.
            dt_caja_ahorro.Clear(); // Datos de la caja de ahorro.
            dt_debito_cta.Clear(); // Datos de las cuentas a la cuál se puede realizar el debito.

            // Limpiamos el archivo adjuntado.
            fileDialog.FileName = "";
            err_Adjunto.Dispose();

        }

        /// <summary>
        /// Evento validated del código del cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCodCliente_Validated(object sender, EventArgs e)
        {
            try
            {
                if (!txtCodCliente.Text.ToString().Trim().Equals(""))
                {                    

                    string cod_cliente = txtCodCliente.Text.ToString().Trim().PadLeft(6,'0');                    
                    
                    v_nombre = capaNegocios.sp_nombre_cliente(cod_cliente).ToString().Trim();

                    if (v_nombre.Trim() == "null")
                    {
                        XtraMessageBox.Show("No se encuentra el cliente.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btLimpiarCarta();
                        return;
                    }
                    else
                    {
                        txtCodCliente.Text = cod_cliente; // Asignamos los ceros en caso de que el cliente no haya agregado toda la longitud de caracteres.

                        txtNombreCliente.EditValue = v_nombre.Trim();

                        DataTable dt = new DataTable();

                        dt = capaNegocios.sp_cuentas_client(cod_cliente).resultado.Tables[0];
                        
                        // Línea de Crédito.
                        monto_orignial = double.Parse(capaNegocios.sp_monto_linea_credito(cod_cliente).resultado.Tables[0].Rows[0]["MONTO"].ToString()); // Monto original                        

                        // Tarjeta.
                        dt_tarjetas = capaNegocios.sp_tar_vigentes_cliente(cod_cliente).resultado.Tables[0];

                        // Cuenta Corriente.
                        dt_cta_cte = capaNegocios.sp_cta_cte_cliente(cod_cliente).resultado.Tables[0];

                        // Caja de Ahorro.
                        dt_caja_ahorro = capaNegocios.sp_caja_ahorro_cliente(cod_cliente).resultado.Tables[0];

                        // Ctas de Debito.
                        dt_debito_cta = capaNegocios.sp_buscar_ctas_cocliente(cod_cliente).resultado.Tables[0];

                        combo_debito_cuenta.Properties.DataSource = dt_debito_cta;
                        combo_debito_cuenta.Properties.ValueMember = "Nro_Cuenta";
                        combo_debito_cuenta.Properties.DisplayMember = "Nro_Cuenta";                        

                        // Verificamos que existan registros en caso contrario agregamos por defecto el tipo de Pago en Caja.
                        if (dt_debito_cta.Rows.Count == 0)
                        {
                            if (!txtCodCliente.Text.ToString().Trim().Equals(""))
                            {
                                XtraMessageBox.Show("El cliente no cuenta con Cuentas Corrientes - Caja de Ahorros.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                rgTipoCatastro.SelectedIndex = 1;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocurrió el siguiente error: " + ex.ToString() + " - Favor contacte con informática.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Evento DoWork - bkGuardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bkGuardar_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {                
                v_clie_key = txtCodCliente.EditValue.ToString();
                v_telefono_cli = txtTelefono.EditValue.ToString();
                v_cuenta_cli = combo_debito_cuenta.EditValue.ToString().Trim();
                v_estado = "0";
                v_file_path = txtFormulario.EditValue.ToString();

                DataTable dtResult = new DataTable();
                dtResult = capaNegocios.sp_catastrar_tigomoney(v_clie_key, v_telefono_cli, v_cuenta_cli, v_estado, usuarioOracle, v_operacion).resultado.Tables[0]; //Registramos en la BD
                if (dtResult.Rows[0]["COD"].ToString() == "0")
                {
                    MessageBox.Show(dtResult.Rows[0]["MENSAJE"].ToString());
                }
                else
                {
                    MessageBox.Show(dtResult.Rows[0]["MENSAJE"].ToString());
                }

                capaNegocios.sp_catastrar_tigomoney_path(v_clie_key, v_file_path); //Registrar el path en la base de datos

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocurrió el siguiente Error: " + ex.ToString() + " Favor contacte con Informática.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// Evento Completed - bkGuardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bkGuardar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            wait.Close();
        }


        /// <summary>
        /// Para alzar archivo al disco mediante ws.
        /// </summary>
        /// <returns></returns>
        private string alzarArchivoDiscoTigoMoney()
        {
            string path = "";
            try
            {
                ElegirArchivo(ref path);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocurrió el sgte error " + ex.ToString() + " favor contacte con informática.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return path;
        }

        private void ElegirArchivo(ref string path)
        {
            fileDialog.Filter = v_filtroImagen; //Formatos soportados.

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileDialog.InitialDirectory = Environment.SpecialFolder.DesktopDirectory.ToString();

                System.IO.FileInfo info = new System.IO.FileInfo(fileDialog.FileName);
                CheckForIllegalCrossThreadCalls = false;
                string datoImagen = DateTime.Now.ToString("ddMMyyyy_HHmmss");
                byte[] uploadBuffer = null;

                try
                {
                    Stream fileStream = fileDialog.OpenFile();
                    uploadBuffer = new byte[fileStream.Length];
                    fileStream.Read(uploadBuffer, 0, (int)fileStream.Length);
                    fileStream.Close();

                    path = v_pathArch;
                    path = path + "\\" + "Tigo_Money";

                    //Guardar el nombre del archivo para poder enviar a en la tabla.
                    v_nombreArch = fileDialog.SafeFileName;
                    //path = path.Substring(0, path.Length - 4);
                    path = path + "_" + datoImagen;
                    string extension = fileDialog.FileName.Substring(fileDialog.FileName.Length - 3, 3);
                    path = path + "." + extension;                                       

                    if (MessageBox.Show("Estas seguro que desea Adjuntar este archivo?", "Confirme Operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        WSAlzaArchivos.extractos elServicio = new WSAlzaArchivos.extractos();

                        try
                        {
                            string ruta = path.Replace(@"\\", @"\");
                            txtFormulario.EditValue = ruta;
                            string archivo = ruta.Split('\\')[ruta.Split('\\').Length - 1];

                            string ruido = DateTime.Now.Ticks.ToString();

                            bool hizo = elServicio.alzarArchivoPAS("pas",
                                                                    ruido,
                                                                    GetMD5("lkjsfywdfgDRTEr89(((45%%#" + ruido),
                                                                    ruta, uploadBuffer);                            

                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show("Ocurrió el sgte error al intentar alzar el archivo al Webservice: " + Ex.Message, Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        fileDialog.FileName = "";
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(this, ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                if (string.IsNullOrEmpty(fileDialog.FileName))
                {
                    XtraMessageBox.Show(this, "Debe seleccionar un archivo para poder Adjuntar y Enviar al Autorizador!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ElegirArchivo(ref path);
                }
            }
        }

        /// <summary>
        /// Obtenemos el archivo.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        byte[] getArchivo(MemoryStream stream)
        {
            Stream fileStream = stream;
            Byte[] uploadBuffer = new byte[fileStream.Length];
            uploadBuffer = stream.ToArray();
            return uploadBuffer;
        }

        /// <summary>
        /// Método utilitario para poder generar MD5.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }


        /// <summary>
        /// Evento keyDown de la referencia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEditRef_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                //textEditRef.Text += (string)Clipboard.GetData("Text");
                e.Handled = true;
            }
        }

        #endregion

        #region MÓDULO - AUTORIZACIONES

        /// <summary>
        /// Evento clic del botón Grabar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGrabar_Click(object sender, EventArgs e)
        {
            try
            {                
                for (int i = 0; i < gridViewAutorizar.RowCount; i++)
                {
                    v_id_catastro_autorizar = gridViewAutorizar.GetRowCellValue(i, "Id del Catastro").ToString().Trim();                    

                    //Validamos si se ingresaron los campos solicitados.
                    if (validar_datos_autorizador(i))
                    {
                        // Actualizar estado del catastro seleccionado
                        capaNegocios.sp_catastrar_tigomoney_autorizar(v_id_catastro_autorizar, usuarioOracle, v_estado_autorizar);                        
                    }
                }

                XtraMessageBox.Show("Se actualizaron correctamente los datos.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargaListaAutorizaciones();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocurrió el siguiente error: " + ex.ToString() + " - Favor contacte con informática.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Validaciones de carga.
        /// </summary>
        /// <returns></returns>
        private bool validar_datos_autorizador(int pos)
        {
            string aprobar = gridViewAutorizar.GetRowCellValue(pos, "Aprobar").ToString();
            string rechazar = gridViewAutorizar.GetRowCellValue(pos, "Rechazar").ToString();
            if ( aprobar.Equals(btnAprobar.ValueChecked) && !rechazar.Equals(btnRechazar.ValueChecked) )
            {
                v_estado_autorizar = "1";
                return true;
            }
            else if ( !aprobar.Equals(btnAprobar.ValueChecked) && rechazar.Equals(btnRechazar.ValueChecked))
            {
                v_estado_autorizar = "6";
                return true;
            }
            else
            {
                v_id_catastro_autorizar = "";
                //v_clie_key_autorizar = "";                
                return false;
            }
        }


        /// <summary>
        /// Evento clic del botón -> Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        
        /// <summary>
        /// Método que limpia los campos de la empresa/entidad.
        /// </summary>
        private void limpiarCampos()
        {
            try
            {
                cargaListaAutorizaciones();
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Carga lista de Autorizador de catastro.
        /// </summary>
        private void cargaListaAutorizaciones()
        {
            try
            {
                dt = capaNegocios.sp_lista_info_tcash_catastro(usuarioOracle).resultado.Tables[0];
                DataTable dt_autorizar = new DataTable();
                dt_autorizar.Merge(dt);                

                // Eliminar columna Id de la grilla
                //dt_autorizar.Columns.RemoveAt(0);

                // Grilla con el listado de registros de la tabla USERWEB.INFO_TCASH_CATASTRO con el estado 0.
                dt_autorizar.Columns.Add("Formulario", typeof(System.String));
                dt_autorizar.Columns.Add("Aprobar", typeof(System.String));
                dt_autorizar.Columns.Add("Rechazar", typeof(System.String));
                gcAutorizar.DataSource = dt_autorizar;
                gridViewAutorizar.BestFitColumns();

                gridViewAutorizar.Columns["Formulario"].ColumnEdit = btnFormulario;
                gridViewAutorizar.Columns["Formulario"].VisibleIndex = 0;

                gridViewAutorizar.Columns["Aprobar"].ColumnEdit = btnAprobar;
                gridViewAutorizar.Columns["Aprobar"].VisibleIndex = 1;

                gridViewAutorizar.Columns["Rechazar"].ColumnEdit = btnRechazar;
                gridViewAutorizar.Columns["Rechazar"].VisibleIndex = 2;

                // Ocultar columna Id de la grilla
                gridViewAutorizar.Columns["Id del Catastro"].Visible = false;
            }
            catch
            {                
                return;
            }
        }

/*
        /// <summary>
        /// Evento Doble Clic de la grilla gcEmpresas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            limpiarCampos();
            if (gridView1.RowCount > 0)
            {
                int[] v_fila = gridView1.GetSelectedRows();
                cod_empresa = double.Parse(gridView1.GetRowCellValue(v_fila[0], "Nro.").ToString());
                v_realizo_modi = 1; // Cambio de estado.
            }
             
        }
*/

        /// <summary>
        /// Método que bloquea algunos elementos de la columna de la grilla
        /// </summary>
        private void Bloquear_Grilla()
        {
            try
            {
                for (int i = 0; i < gridViewAutorizar.Columns.Count; i++)
                {
                    gridViewAutorizar.Columns[i].OptionsColumn.AllowEdit = false;

                }

                gridViewAutorizar.Columns["Formulario"].OptionsColumn.AllowEdit = true;
                gridViewAutorizar.Columns["Aprobar"].OptionsColumn.AllowEdit = true;
                gridViewAutorizar.Columns["Rechazar"].OptionsColumn.AllowEdit = true;

            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Evento clic del botón -> Adjuntar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNotaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                id_adjunto_nota = alzarArchivoDiscoTigoMoney();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocurrió el sgte error " + ex.ToString() + " Favor contacte con informática.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #endregion

        #region MÓDULO - IMPRESIÓN     

        /// <summary>
        /// Método que recibe la ruta del archivo en el Ws y lo descarga.
        /// </summary>
        /// <param name="directorioWS"></param>
        /// <returns></returns>
        public static string bajarArchivoWS2(string directorioWS)
        {
            #region METODO PARA BAJAR LAS img DE LA BASE DE DATOS 👽
            WSAlzaArchivos.extractos request2 = new f2.WSAlzaArchivos.extractos();
            int pos2;
            SaveFileDialog save = new SaveFileDialog();
            pos2 = directorioWS.ToString().Trim().LastIndexOf('\\');
            string[] VALOR = directorioWS.Replace(@"\", "*").Split('*');
            save.FileName = directorioWS.ToString().Trim().Substring(pos2 + 1, (directorioWS.ToString().Trim().Length - (pos2 + 1)));
            string strFilename = save.FileName.ToString();

            string ruido = DateTime.Now.Ticks.ToString();
            byte[] byteData = request2.bajarArchivoPAS("pas",
            ruido,
            utiles.GetMD5("lkjsfywdfgDRTEr89(((45%%#" + ruido),
            directorioWS);

            File.Delete(strFilename.Trim());
            FileStream newFile = new FileStream(strFilename.Trim(), FileMode.Create);
            newFile.Write(byteData, 0, byteData.Length);
            newFile.Close();
            return strFilename.Trim();

            #endregion;
        }

        /// <summary>
        /// Método para Abrir el archivo.
        /// </summary>
        /// <param name="ruta"></param>
        void AbrirArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                System.Diagnostics.Process.Start(ruta);
            }
            else
            {
                XtraMessageBox.Show("Archivo No existe. Ruta: "+ ruta , "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Warning); //PIXXXXX
            }
        }


        /// <summary>
        /// Evento Selected IndexChanged del combo de Estados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbEstadoImp_SelectedIndexChanged(object sender, EventArgs e)
        {
            bkImpresion.RunWorkerAsync();
            wait = new WindowWait("Obteniendo Datos, Aguarde un momento...");
            wait.ShowDialog();
        }


        #endregion

        
        
        /// <summary>
        /// Evento clic del repositorio Eliminar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFormulario_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewAutorizar.RowCount > 0)
                {
                    int[] v_seleccionado = gridViewAutorizar.GetSelectedRows();
                    string v_path = gridViewAutorizar.GetRowCellValue(v_seleccionado[0], "Ruta del Archivo").ToString().Trim();
                    if (!v_path.Equals(""))
                    {

                        DialogResult dialogo = XtraMessageBox.Show("Esta seguro que desea realizar la descarga del archivo", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogo == DialogResult.Yes)
                        {

                            WSAlzaArchivos.extractos request2 = new WSAlzaArchivos.extractos();
                            int pos;
                            SaveFileDialog save = new SaveFileDialog();
                            pos = v_path.ToString().Trim().LastIndexOf('\\');
                            string[] VALOR = v_path.Replace(@"\", "*").Split('*');
                            save.FileName = VALOR[0].ToString() + "_" + v_path.ToString().Trim().Substring(pos + 1, (v_path.ToString().Trim().Length - (pos + 1)));
                            string strFilename = save.FileName.ToString();
                            try
                            {

                                string ruido = DateTime.Now.Ticks.ToString();
                                byte[] byteData = request2.bajarArchivoPAS("pas",
                                ruido,
                                utiles.GetMD5("lkjsfywdfgDRTEr89(((45%%#" + ruido),
                                v_path);
                                FileStream newFile = new FileStream(strFilename.Trim(), FileMode.Create);
                                newFile.Write(byteData, 0, byteData.Length);
                                newFile.Close();
                                System.Diagnostics.Process.Start(strFilename.Trim());
                            }
                            catch (Exception Ex)
                            {

                                MessageBox.Show("Ocurrio el sgte error: " + Ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("No existe el archivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocurrió el siguiente error: " + ex.ToString() + " - Favor contacte con informática.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }        



        #region MÓDULO - REPORTE


        /// <summary>
        /// Evento validated del módulo del campo -> [Código de Cliente].
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCodClienteR_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!txtCodClienteR.Text.ToString().Trim().Equals(""))
                {

                    string cod_cliente = txtCodClienteR.Text.ToString().Trim().PadLeft(6, '0');

                    txtCodClienteR.Text = cod_cliente; // Asignamos los ceros en caso de que el cliente no haya agregado toda la longitud de caracteres.                                       
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocurrió el siguiente error: " + ex.ToString() + " - Favor contacte con informática.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Método que bloquea algunos elementos de la columna de la grilla
        /// </summary>
        private void Bloquear_Grilla_Reporte()
        {
            try
            {
                for (int i = 0; i < gridViewReporte.Columns.Count; i++)
                {
                    gridViewReporte.Columns[i].OptionsColumn.AllowEdit = false;

                }

                gridViewReporte.Columns["Reporte"].OptionsColumn.AllowEdit = true;
                gridViewReporte.Columns["Formulario"].OptionsColumn.AllowEdit = true;                

            }
            catch
            {
                return;
            }
        }


        /// <summary>
        /// Evento clic del botón Exportar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btExportarR_Click(object sender, EventArgs e)
        {
            // Verificamos si existen datos para poder Exportar.
            if (gridViewReporte.RowCount > 0)
            {
                SaveFileDialog _save = new SaveFileDialog();
                _save.Title = "Exportar a excel";
                _save.Filter = "xls|*.xls";

                if (_save.ShowDialog() == DialogResult.OK)
                {
                    if (_save.FileName.Length > 1)
                    {
                        gcReporte.ExportToExcelOld(_save.FileName);
                        XtraMessageBox.Show("Guardado correctamente en" + "\n" + _save.FileName + ".", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Favor escriba el nombre del archivo a Exportar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("No existen registros para poder Exportar.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento clic del botón Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLimpiarR_Click(object sender, EventArgs e)
        {
            limpiarCamposReporte();
        }

        /// <summary>
        /// Método que limpia los parametros asignados por el usuario para la carga del reporte.
        /// </summary>
        private void limpiarCamposReporte()
        {
            try
            {
                // Código del cliente.
                txtCodClienteR.Text = null;
                err_cliente_R.Dispose();

                // Sucursal de carga.
                txtCuentaR.Text = null; //En caso de que la sucursal del usuario sea CASA MATRIZ - Podra visualizar todas las sucursales; sino solo los registros de su propia sucursal.
                err_Suc_Carga_R.Dispose();

                // Fecha de inicio - Fecha de Finalización.
                cargarFechasReporte();

                // Limpiamos la grilla.
                gcReporte.DataSource = null;
                gridViewReporte.PopulateColumns();

            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Método que carga el rango de fechas -> Desde (Inicio del Mes) - Hasta (Último día del Mes).
        /// </summary>
        private void cargarFechasReporte()
        {
            try
            {
                int var_mesActual = DateTime.Now.Month; // Obtengo el mes actual.
                int var_anio = DateTime.Now.Year; // Obtengo el año actual.
                int var_mesSiguiente = DateTime.Now.Month + 1; // Obtengo el mes siguiente,
                dtFechaIni.EditValue = DateTime.Parse("01/" + var_mesActual + "/" + var_anio);// Pongo el 1 porque siempre es el primer día.
                dtFechaFin.EditValue = DateTime.Parse("01/" + var_mesSiguiente + "/" + var_anio).AddDays(-1); // Resto un día al mes y con esto obtengo el ultimo día.
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Evento clic del botón -> [Buscar].
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBuscarR_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar_reporte()) {
                    string codigo = txtCodClienteR.Text.ToString().Trim();
                    string cuenta = txtCuentaR.Text.ToString().Trim();
                    string telefono = txtNroTelefonoR.Text.ToString().Trim();

                    string desde;
                    if (dtFechaIni.EditValue == null)
                        desde = "";
                    else
                        desde = dtFechaIni.EditValue.ToString();

                    string hasta;
                    if (dtFechaFin.EditValue == null)
                        hasta = "";
                    else                        
                        hasta = dtFechaFin.EditValue.ToString();



                    dt = capaNegocios.sp_lis_tcash_cata_rep(codigo, cuenta, telefono, desde, hasta).resultado.Tables[0];                   
                    DataTable dt_reporte = new DataTable();
                    dt_reporte.Merge(dt);

                    // Grilla con el listado de registros de la tabla USERWEB.INFO_TCASH_CATASTRO con el estado 0.
                    dt_reporte.Columns.Add("Reporte", typeof(System.String));
                    dt_reporte.Columns.Add("Formulario", typeof(System.String));

                    if (dt_reporte.Rows.Count == 0)
                    {
                        XtraMessageBox.Show("No se encontraron datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    gcReporte.DataSource = dt_reporte;
                    gridViewReporte.BestFitColumns();

                    gridViewReporte.Columns["Reporte"].ColumnEdit = btnReporte;
                    gridViewReporte.Columns["Reporte"].VisibleIndex = 9;

                    gridViewReporte.Columns["Formulario"].ColumnEdit = btnFormularioR;
                    gridViewReporte.Columns["Formulario"].VisibleIndex = 10;

                    Bloquear_Grilla_Reporte();

                    // Ocultar columna Id de la grilla
                    gridViewReporte.Columns["Id Catastro"].Visible = false;
                    gridViewReporte.Columns["Ruta del Archivo"].Visible = false;

                    
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocurrió el siguiente error: " + ex.ToString() + " - Favor contacte con informática.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private bool validar_reporte()
        {
            int ban=0;

            if (!(dtFechaIni.EditValue == null) && !(dtFechaFin.EditValue == null)) {                 
                if ((DateTime)dtFechaIni.EditValue > (DateTime)dtFechaFin.EditValue)
                {
                    ban = 0;
                    XtraMessageBox.Show("Fecha desde no puede ser mayor a fecha hasta.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ban = 1;                
            }
            
            if (dtFechaIni.EditValue == null && dtFechaFin.EditValue == null)
            {
                ban = 1;
            }

            if (!(dtFechaIni.EditValue == null) && dtFechaFin.EditValue == null)
            {
                ban = 0;
                XtraMessageBox.Show("Fecha desde no puede ser nulo.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtFechaIni.EditValue == null && !(dtFechaFin.EditValue == null))
            {
                ban = 0;
                XtraMessageBox.Show("Fecha desde no puede ser nulo.", "Finansys 2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
                          
            if (ban.Equals(0))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        #endregion

        private void btnFormularioR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (gridViewReporte.RowCount > 0)
                {
                    int[] v_seleccionado = gridViewReporte.GetSelectedRows();
                    string v_path = gridViewReporte.GetRowCellValue(v_seleccionado[0], "Ruta del Archivo").ToString().Trim();
                    if (!v_path.Equals(""))
                    {
                        DialogResult dialogo = XtraMessageBox.Show("Esta seguro que desea realizar la descarga del archivo", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogo == DialogResult.Yes)
                        {

                            WSAlzaArchivos.extractos request2 = new WSAlzaArchivos.extractos();
                            int pos;
                            SaveFileDialog save = new SaveFileDialog();
                            pos = v_path.ToString().Trim().LastIndexOf('\\');
                            string[] VALOR = v_path.Replace(@"\", "*").Split('*');
                            save.FileName = VALOR[0].ToString() + "_" + v_path.ToString().Trim().Substring(pos + 1, (v_path.ToString().Trim().Length - (pos + 1)));
                            string strFilename = save.FileName.ToString();
                            try
                            {

                                string ruido = DateTime.Now.Ticks.ToString();
                                byte[] byteData = request2.bajarArchivoPAS("pas",
                                ruido,
                                utiles.GetMD5("lkjsfywdfgDRTEr89(((45%%#" + ruido),
                                v_path);
                                FileStream newFile = new FileStream(strFilename.Trim(), FileMode.Create);
                                newFile.Write(byteData, 0, byteData.Length);
                                newFile.Close();
                                System.Diagnostics.Process.Start(strFilename.Trim());
                            }
                            catch (Exception Ex)
                            {
                                MessageBox.Show("Ocurrio el sgte error: " + Ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene archivos cargados", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }                    
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocurrió el siguiente error: " + ex.ToString() + " - Favor contacte con informática.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReporte_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataTable dt = new DataTable();

            int[] v_seleccionado = gridViewReporte.GetSelectedRows();

            string v_id = gridViewReporte.GetRowCellValue(v_seleccionado[0], "Id Catastro").ToString().Trim();

            dt = capaNegocios.sp_report_catastro_tmoney(v_id).resultado.Tables[0];

            RepOperacionesElectronicas report = new RepOperacionesElectronicas();
            report.DataSource = dt;
            report.ShowPreviewDialog();
        }

        private void btnAprobar_EditValueChanged(object sender, EventArgs e)
        {
            if (btnAprobar.ValueChecked.Equals("S"))
            {
                int[] checkButton = gridViewAutorizar.GetSelectedRows();
                gridViewAutorizar.SetRowCellValue(checkButton[0], "Rechazar", "N");
            }
        }

        private void btnRechazar_EditValueChanged(object sender, EventArgs e)
        {
            if (btnRechazar.ValueChecked.Equals("S"))
            {
                int[] checkButton = gridViewAutorizar.GetSelectedRows();
                gridViewAutorizar.SetRowCellValue(checkButton[0], "Aprobar", "N");
            }
        }
    }
}
