namespace f2.productos
{
    partial class tarjetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarjetas));
            this.lbMontoTotalLinea = new DevExpress.XtraEditors.LabelControl();
            this.btGrabar = new DevExpress.XtraEditors.SimpleButton();
            this.gcTarjetas = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.checkTarjetas = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMontoTotalLinea
            // 
            this.lbMontoTotalLinea.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoTotalLinea.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbMontoTotalLinea.Location = new System.Drawing.Point(179, 15);
            this.lbMontoTotalLinea.Name = "lbMontoTotalLinea";
            this.lbMontoTotalLinea.Size = new System.Drawing.Size(210, 21);
            this.lbMontoTotalLinea.TabIndex = 1002;
            this.lbMontoTotalLinea.Text = "Tarjetas de Crédito - Vigente";
            // 
            // btGrabar
            // 
            this.btGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btGrabar.Image")));
            this.btGrabar.Location = new System.Drawing.Point(478, 320);
            this.btGrabar.Name = "btGrabar";
            this.btGrabar.Size = new System.Drawing.Size(78, 23);
            this.btGrabar.TabIndex = 1;
            this.btGrabar.Text = "&Confirmar";
            this.btGrabar.ToolTip = "Presione Alt + C";
            this.btGrabar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btGrabar.ToolTipTitle = "Combinación de Teclas";
            this.btGrabar.Click += new System.EventHandler(this.btGrabar_Click);
            // 
            // gcTarjetas
            // 
            this.gcTarjetas.Location = new System.Drawing.Point(12, 46);
            this.gcTarjetas.MainView = this.gridView1;
            this.gcTarjetas.Name = "gcTarjetas";
            this.gcTarjetas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkTarjetas});
            this.gcTarjetas.Size = new System.Drawing.Size(544, 268);
            this.gcTarjetas.TabIndex = 1003;
            this.gcTarjetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcTarjetas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // checkTarjetas
            // 
            this.checkTarjetas.AutoHeight = false;
            this.checkTarjetas.Name = "checkTarjetas";
            this.checkTarjetas.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkTarjetas.ValueGrayed = false;
            // 
            // tarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 356);
            this.Controls.Add(this.gcTarjetas);
            this.Controls.Add(this.btGrabar);
            this.Controls.Add(this.lbMontoTotalLinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "tarjetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarjetas de Crédito";
            ((System.ComponentModel.ISupportInitialize)(this.gcTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbMontoTotalLinea;
        private DevExpress.XtraEditors.SimpleButton btGrabar;
        private DevExpress.XtraGrid.GridControl gcTarjetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkTarjetas;
    }
}