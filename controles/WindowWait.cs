using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace f2.gui
{
    public partial class WindowWait : XtraForm
    {
        #region DEFINICIÓN DE VARIABLES

        public int _progress = 0;
        int crono = 0;
        int cantidadItems = 0;

        #endregion

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="capaNegocios"></param>
        public WindowWait(string message,string version)
        {
            InitializeComponent();
            labelControl1.Text = message;
            linearScaleComponent1.Value = 0;
            
        }

        public WindowWait(string message)
        {
            InitializeComponent();
            labelControl1.Text = message;
            linearScaleComponent1.Value = 0;

        }        

        private void timerProgreso_Tick(object sender, EventArgs e)
        {
            crono += 9;
            linearScaleComponent1.Value = crono;
            cantidadItems++;
            if (cantidadItems >= 11)
            {
                crono = 9;
                linearScaleComponent1.Value = crono;
                cantidadItems = 0;
            }
        }
        private void WindowWait_FormClosing(object sender, FormClosingEventArgs e)
        {
            labelControl1.Visible = false;            
            gaugeControl1.Visible = false;
            
        }

    }
}