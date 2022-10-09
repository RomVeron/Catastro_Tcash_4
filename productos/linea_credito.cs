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
    public partial class linea_credito : DevExpress.XtraEditors.XtraForm
    {
        #region Definición de Variables

        businessLayer capaNegocios = new businessLayer();
        private double v_monto_lcr; // Línea de crédito original.
        public double v_monto_lcr_mod; // Línea de crédito en caso de módificación por parte del usuario.
        public bool v_se_modif = false; // Esta bandera indica si se realizó alguna modificación de monto.
        #endregion
        
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="monto_lcr_orig"></param>
        public linea_credito(double monto_lcr)
        {
            InitializeComponent();
            v_monto_lcr = monto_lcr;
            CargaMonto();
        }

        /// <summary>
        /// Método que carga la línea de crédito vigente del cliente.
        /// </summary>
        private void CargaMonto()
        {
            txtMontoLCR.Text = v_monto_lcr.ToString();
        }

        /// <summary>
        /// Evento clic del botón Grabar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGrabar_Click(object sender, EventArgs e)
        {
            
            v_monto_lcr_mod = double.Parse(txtMontoLCR.Text.ToString().Trim());
            if (v_monto_lcr != v_monto_lcr_mod)
            {
                DialogResult dialogo = XtraMessageBox.Show("Esta seguro que desea asignar este monto", "Finansys 2", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogo == DialogResult.Yes)
                {
                    v_se_modif = true;
                }
                else
                {
                    v_se_modif = false;
                }
            }
            else
            { v_se_modif = false; }

            
            this.Close();
        }

        /// <summary>
        /// Evento keyPress del campo Monto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMontoLCR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar == '-')) //#PI22258
            {
                e.Handled = true;
                return;
            }
        }

        private void txtMontoLCR_KeyDown(object sender, KeyEventArgs e) //#PI22258
        {
            e.Handled = true;
        }

    }
}