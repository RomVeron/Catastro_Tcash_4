using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit;
using f2.clases;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace f2.reportes
{
    public partial class RepOperacionesElectronicas : DevExpress.XtraReports.UI.XtraReport
    {
        #region Definición de variables.
        private businessLayer capaNegocios = new businessLayer();
        private string empresa;
        private bool marca_agua = false; //PN 22596
        private string cod_cliente;
        private string tipo_reporte = ""; //PN 22596
        private string nombre_cliente;
        private bool check_cta_cte, check_ahorro, check_tarjeta, check_linea_credito = false;
        private DataTable dt_tarjetas = new DataTable(); // Datos de la tarjeta de crédito.
        private DataTable dt_cta_cte = new DataTable(); // Datos de la cuenta corriente.
        private DataTable dt_caja_ahorro = new DataTable(); // Datos de la caja de ahorro.
        private string v_detalle_cta_cte = "";
        private string v_detalle_caja_ahorro = "";
        private string v_detalle_tarjeta = "";
        private double v_monto_lcr = 0;
        private string formato_monto_lcr = "";
        private string Numeracion = "";
        private int v_contador_op = 0;
        private string v_operaciones_vigentes = "";
      //PN22596
        private string V_TIPO_CARTA = "N";
        private string V_TITULO = "";
        private string V_ENCABEZADO = "";
        private string V_CUERPO_1 = "";
        private string V_CUERPO_2 = "";
        private string V_CUERPO_3 = "";
        private string V_CUERPO_4 = "";
        private string V_CUERPO_5 = "";
        private string V_CUERPO_6 = "";
        private string V_CUERPO_7 = "";
        private string V_CUERPO_8 = "";
        private string V_CUERPO_9 = "";
        private string V_CUERPO_10 = "";
        private string V_CUERPO_11 = "";
        private string V_CUERPO_12 = "";
        private string V_CUERPO_13 = "";
        private string V_CUERPO_14 = "";
        private string V_DESPEDIDA = "";
        private string V_PIE_PAGINA = "";
      // FIN PN22596

        #endregion

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public RepOperacionesElectronicas() //PN 22596
        {
            InitializeComponent();
            this.capaNegocios = capaNegocios;
            this.empresa = empresa;
            this.cod_cliente = cod_cliente;
            this.nombre_cliente = nombre_cliente;
            this.check_cta_cte = check_cta_cte;
            this.check_ahorro = check_ahorro;
            this.check_tarjeta = check_tarjeta;
            this.check_linea_credito = check_linea_credito;
            this.dt_tarjetas = dt_tarjetas;
            this.dt_cta_cte = dt_cta_cte;
            this.dt_caja_ahorro = dt_caja_ahorro;
            this.v_monto_lcr = v_monto_lcr;
            this.tipo_reporte = tipo_reporte; //PN 22596
/*            obtenerDatosDeLaCarta(); //PN 22596 
*/            
        }

/*
        private void obtenerDatosDeLaCarta()
        {
            DataTable dt_parametros_carta = capaNegocios.sp_parametros_carta_Referencia().resultado.Tables[0];

            if (dt_parametros_carta.Rows.Count > 0)
            {
                if (V_TIPO_CARTA == "N")
                {
                    V_TITULO = dt_parametros_carta.Rows[0]["DT_VALOR"].ToString();
                    V_ENCABEZADO = dt_parametros_carta.Rows[1]["DT_VALOR"].ToString();
                    V_CUERPO_1 = dt_parametros_carta.Rows[2]["DT_VALOR"].ToString();
                    V_CUERPO_2 = dt_parametros_carta.Rows[3]["DT_VALOR"].ToString();
                    V_CUERPO_3 = dt_parametros_carta.Rows[4]["DT_VALOR"].ToString();
                    V_CUERPO_4 = dt_parametros_carta.Rows[5]["DT_VALOR"].ToString();
                    V_CUERPO_5 = dt_parametros_carta.Rows[6]["DT_VALOR"].ToString();
                    V_CUERPO_6 = dt_parametros_carta.Rows[7]["DT_VALOR"].ToString();
                    V_CUERPO_7 = dt_parametros_carta.Rows[8]["DT_VALOR"].ToString();
                    V_CUERPO_8 = dt_parametros_carta.Rows[9]["DT_VALOR"].ToString();
                    V_CUERPO_9 = dt_parametros_carta.Rows[10]["DT_VALOR"].ToString();
                    V_CUERPO_10 = dt_parametros_carta.Rows[11]["DT_VALOR"].ToString();
                    V_CUERPO_11 = dt_parametros_carta.Rows[12]["DT_VALOR"].ToString();
                    V_CUERPO_12 = dt_parametros_carta.Rows[13]["DT_VALOR"].ToString();
                    V_CUERPO_13 = dt_parametros_carta.Rows[14]["DT_VALOR"].ToString();
                    V_CUERPO_14 = dt_parametros_carta.Rows[15]["DT_VALOR"].ToString();
                    V_DESPEDIDA = dt_parametros_carta.Rows[16]["DT_VALOR"].ToString();
                    V_PIE_PAGINA = dt_parametros_carta.Rows[17]["DT_VALOR"].ToString();
                }
            }
        }
*/

    }
}
