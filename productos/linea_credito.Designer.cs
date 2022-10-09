namespace f2.productos
{
    partial class linea_credito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMontoPYG = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoLCR = new DevExpress.XtraEditors.TextEdit();
            this.lbMontoTotalLinea = new DevExpress.XtraEditors.LabelControl();
            this.btGrabar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoLCR.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMontoPYG
            // 
            this.lbMontoPYG.Location = new System.Drawing.Point(23, 63);
            this.lbMontoPYG.Name = "lbMontoPYG";
            this.lbMontoPYG.Size = new System.Drawing.Size(71, 13);
            this.lbMontoPYG.TabIndex = 1001;
            this.lbMontoPYG.Text = "Monto en PYG:";
            // 
            // txtMontoLCR
            // 
            this.txtMontoLCR.Location = new System.Drawing.Point(100, 60);
            this.txtMontoLCR.Name = "txtMontoLCR";
            this.txtMontoLCR.Properties.Mask.EditMask = "n0";
            this.txtMontoLCR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMontoLCR.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMontoLCR.Size = new System.Drawing.Size(147, 20);
            this.txtMontoLCR.TabIndex = 0;
            this.txtMontoLCR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMontoLCR_KeyDown);
            this.txtMontoLCR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoLCR_KeyPress);
            // 
            // lbMontoTotalLinea
            // 
            this.lbMontoTotalLinea.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoTotalLinea.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbMontoTotalLinea.Location = new System.Drawing.Point(96, 19);
            this.lbMontoTotalLinea.Name = "lbMontoTotalLinea";
            this.lbMontoTotalLinea.Size = new System.Drawing.Size(168, 21);
            this.lbMontoTotalLinea.TabIndex = 1002;
            this.lbMontoTotalLinea.Text = "Monto Total de la línea";
            // 
            // btGrabar
            // 
            this.btGrabar.Image = global::f2.Properties.Resources.ok;
            this.btGrabar.Location = new System.Drawing.Point(253, 59);
            this.btGrabar.Name = "btGrabar";
            this.btGrabar.Size = new System.Drawing.Size(78, 23);
            this.btGrabar.TabIndex = 1;
            this.btGrabar.Text = "&Confirmar";
            this.btGrabar.ToolTip = "Presione Alt + C";
            this.btGrabar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btGrabar.ToolTipTitle = "Combinación de Teclas";
            this.btGrabar.Click += new System.EventHandler(this.btGrabar_Click);
            // 
            // linea_credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 132);
            this.Controls.Add(this.btGrabar);
            this.Controls.Add(this.lbMontoTotalLinea);
            this.Controls.Add(this.lbMontoPYG);
            this.Controls.Add(this.txtMontoLCR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "linea_credito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Línea de Crédito";
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoLCR.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbMontoPYG;
        private DevExpress.XtraEditors.TextEdit txtMontoLCR;
        private DevExpress.XtraEditors.LabelControl lbMontoTotalLinea;
        private DevExpress.XtraEditors.SimpleButton btGrabar;
    }
}