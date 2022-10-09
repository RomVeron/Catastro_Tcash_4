namespace f2.productos
{
    partial class caja_ahorro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(caja_ahorro));
            this.lbMontoTotalLinea = new DevExpress.XtraEditors.LabelControl();
            this.btGrabar = new DevExpress.XtraEditors.SimpleButton();
            this.gccaja_ahorro = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.checkcaja_ahorro = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gccaja_ahorro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkcaja_ahorro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMontoTotalLinea
            // 
            this.lbMontoTotalLinea.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoTotalLinea.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbMontoTotalLinea.Location = new System.Drawing.Point(230, 15);
            this.lbMontoTotalLinea.Name = "lbMontoTotalLinea";
            this.lbMontoTotalLinea.Size = new System.Drawing.Size(109, 21);
            this.lbMontoTotalLinea.TabIndex = 1002;
            this.lbMontoTotalLinea.Text = "Caja de Ahorro";
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
            // gccaja_ahorro
            // 
            this.gccaja_ahorro.Location = new System.Drawing.Point(12, 46);
            this.gccaja_ahorro.MainView = this.gridView1;
            this.gccaja_ahorro.Name = "gccaja_ahorro";
            this.gccaja_ahorro.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkcaja_ahorro});
            this.gccaja_ahorro.Size = new System.Drawing.Size(544, 268);
            this.gccaja_ahorro.TabIndex = 1003;
            this.gccaja_ahorro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gccaja_ahorro;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // checkcaja_ahorro
            // 
            this.checkcaja_ahorro.AutoHeight = false;
            this.checkcaja_ahorro.Name = "checkcaja_ahorro";
            this.checkcaja_ahorro.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkcaja_ahorro.ValueGrayed = false;
            // 
            // caja_ahorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 356);
            this.Controls.Add(this.gccaja_ahorro);
            this.Controls.Add(this.btGrabar);
            this.Controls.Add(this.lbMontoTotalLinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "caja_ahorro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja de Ahorro";
            ((System.ComponentModel.ISupportInitialize)(this.gccaja_ahorro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkcaja_ahorro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbMontoTotalLinea;
        private DevExpress.XtraEditors.SimpleButton btGrabar;
        private DevExpress.XtraGrid.GridControl gccaja_ahorro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkcaja_ahorro;
    }
}