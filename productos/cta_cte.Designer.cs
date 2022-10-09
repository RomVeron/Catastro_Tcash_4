namespace f2.productos
{
    partial class cta_cte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cta_cte));
            this.lbMontoTotalLinea = new DevExpress.XtraEditors.LabelControl();
            this.btGrabar = new DevExpress.XtraEditors.SimpleButton();
            this.gccta_cte = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.checkcta_cte = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gccta_cte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkcta_cte)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMontoTotalLinea
            // 
            this.lbMontoTotalLinea.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoTotalLinea.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbMontoTotalLinea.Location = new System.Drawing.Point(222, 15);
            this.lbMontoTotalLinea.Name = "lbMontoTotalLinea";
            this.lbMontoTotalLinea.Size = new System.Drawing.Size(124, 21);
            this.lbMontoTotalLinea.TabIndex = 1002;
            this.lbMontoTotalLinea.Text = "Cuenta Corriente";
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
            // gccta_cte
            // 
            this.gccta_cte.Location = new System.Drawing.Point(12, 46);
            this.gccta_cte.MainView = this.gridView1;
            this.gccta_cte.Name = "gccta_cte";
            this.gccta_cte.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkcta_cte});
            this.gccta_cte.Size = new System.Drawing.Size(544, 268);
            this.gccta_cte.TabIndex = 1003;
            this.gccta_cte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gccta_cte;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // checkcta_cte
            // 
            this.checkcta_cte.AutoHeight = false;
            this.checkcta_cte.Name = "checkcta_cte";
            this.checkcta_cte.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkcta_cte.ValueGrayed = false;
            // 
            // cta_cte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 356);
            this.Controls.Add(this.gccta_cte);
            this.Controls.Add(this.btGrabar);
            this.Controls.Add(this.lbMontoTotalLinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "cta_cte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta Corriente";
            ((System.ComponentModel.ISupportInitialize)(this.gccta_cte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkcta_cte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbMontoTotalLinea;
        private DevExpress.XtraEditors.SimpleButton btGrabar;
        private DevExpress.XtraGrid.GridControl gccta_cte;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkcta_cte;
    }
}