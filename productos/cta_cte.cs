using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace f2.productos
{
    public partial class cta_cte : DevExpress.XtraEditors.XtraForm
    {
        #region Definición de Variables

        businessLayer capaNegocios = new businessLayer();
        private DataTable dt = new DataTable(); // DataTable con los datos originales de la tarjeta.
        public DataTable dt_seleccionados = new DataTable(); // Datos seleccionados por el usuario.

        #endregion
        
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="monto_lcr_orig"></param>C:\Users\ricardo.gonzalez\Desktop\6111 - CARTA REFERENCIA\DESARROLLO\Fuentes\C#\Carta_Referencia_4\productos\cta_cte.cs
        public cta_cte(DataTable tabla)
        {
            InitializeComponent();
            dt = tabla;
            CargaDatos();
            Bloquear_Grilla();
        }

        /// <summary>
        /// Método que carga la grilla con las cta_cte de créditos vigentes del cliente.
        /// </summary>
        private void CargaDatos()
        {
            if (!dt.Columns.Contains("Marcar"))
            {
                dt.Columns.Add("Marcar", typeof(System.Boolean));
                gccta_cte.DataSource = dt;
                gridView1.BestFitColumns();
                gridView1.Columns["Marcar"].ColumnEdit = checkcta_cte;
                gridView1.Columns["Marcar"].VisibleIndex = 0;
            }
            else
            {
                gccta_cte.DataSource = dt;
                gridView1.BestFitColumns();
                gridView1.Columns["Marcar"].ColumnEdit = checkcta_cte;
                gridView1.Columns["Marcar"].VisibleIndex = 0;
            }
            
        }

        /// <summary>
        /// Evento clic del botón Grabar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGrabar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Método que bloquea algunos elementos de la columna de la grilla
        /// </summary>
        private void Bloquear_Grilla()
        {
            try
            {
                for (int i = 0; i < gridView1.Columns.Count; i++)
                {
                    gridView1.Columns[i].OptionsColumn.AllowEdit = false;

                }

                gridView1.Columns["Marcar"].OptionsColumn.AllowEdit = true;

            }
            catch
            {
                return;
            }

        }

    }
}