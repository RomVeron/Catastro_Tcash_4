namespace f2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barVersion = new DevExpress.XtraBars.BarStaticItem();
            this.brVersion = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.err_cliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_empresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_dirigido = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_productos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.err_nombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_direccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_telefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_email = new System.Windows.Forms.ErrorProvider(this.components);
            this.bkGuardar = new System.ComponentModel.BackgroundWorker();
            this.err_ref = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_debito_cuenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.bkImpresion = new System.ComponentModel.BackgroundWorker();
            this.err_cliente_R = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_Suc_Carga_R = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_Adjunto = new System.Windows.Forms.ErrorProvider(this.components);
            this.gridViewAutorizar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcAutorizar = new DevExpress.XtraGrid.GridControl();
            this.btnAprobar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnRechazar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnFormulario = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabReporte = new DevExpress.XtraTab.XtraTabPage();
            this.txtCuentaR = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNroTelefonoR = new DevExpress.XtraEditors.TextEdit();
            this.btLimpiarR = new DevExpress.XtraEditors.SimpleButton();
            this.btBuscarR = new DevExpress.XtraEditors.SimpleButton();
            this.btExportarR = new DevExpress.XtraEditors.SimpleButton();
            this.lbCodClienteR = new DevExpress.XtraEditors.LabelControl();
            this.txtCodClienteR = new DevExpress.XtraEditors.TextEdit();
            this.lbSucCargaR = new DevExpress.XtraEditors.LabelControl();
            this.lbFechaFin = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaFin = new DevExpress.XtraEditors.DateEdit();
            this.lbFechaInicio = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaIni = new DevExpress.XtraEditors.DateEdit();
            this.gcReporte = new DevExpress.XtraGrid.GridControl();
            this.gridViewReporte = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnReporte = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnFormularioR = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.lbImpresion = new DevExpress.XtraEditors.LabelControl();
            this.tabAutorizador = new DevExpress.XtraTab.XtraTabPage();
            this.btRefrescar = new DevExpress.XtraEditors.SimpleButton();
            this.btGrabar = new DevExpress.XtraEditors.SimpleButton();
            this.lbEmpresaEntidad = new DevExpress.XtraEditors.LabelControl();
            this.tabRegistro = new DevExpress.XtraTab.XtraTabPage();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFormulario = new DevExpress.XtraEditors.TextEdit();
            this.rgTipoCatastro = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.btNotaCliente = new DevExpress.XtraEditors.SimpleButton();
            this.lbNotaCliente = new DevExpress.XtraEditors.LabelControl();
            this.lbTipoPago = new DevExpress.XtraEditors.LabelControl();
            this.combo_debito_cuenta = new DevExpress.XtraEditors.LookUpEdit();
            this.lbDebito_Cuenta = new DevExpress.XtraEditors.LabelControl();
            this.btlimpiar_carta = new DevExpress.XtraEditors.SimpleButton();
            this.lbValidProducts = new DevExpress.XtraEditors.LabelControl();
            this.btManual = new DevExpress.XtraEditors.SimpleButton();
            this.txtNombreCliente = new DevExpress.XtraEditors.TextEdit();
            this.lbCartaReferencia = new DevExpress.XtraEditors.LabelControl();
            this.lbCod_Cliente = new DevExpress.XtraEditors.LabelControl();
            this.txtCodCliente = new DevExpress.XtraEditors.TextEdit();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.tabModulos = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_empresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_dirigido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_direccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_telefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_ref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_debito_cuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_cliente_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Suc_Carga_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Adjunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAutorizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAutorizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAprobar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRechazar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFormulario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.tabReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroTelefonoR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodClienteR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIni.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFormularioR)).BeginInit();
            this.tabAutorizador.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormulario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoCatastro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_debito_cuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabModulos)).BeginInit();
            this.tabModulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barVersion,
            this.brVersion,
            this.barStaticItem2,
            this.barStaticItem3});
            this.barManager.MaxItemId = 15;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.barManager.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barStaticItem3, DevExpress.XtraBars.BarItemPaintStyle.Standard)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "brVersion";
            this.barStaticItem2.Id = 3;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "brUsuario";
            this.barStaticItem3.Id = 14;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(897, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 700);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(897, 30);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 700);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(897, 0);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 700);
            // 
            // barVersion
            // 
            this.barVersion.Caption = "barVersion";
            this.barVersion.Id = 0;
            this.barVersion.Name = "barVersion";
            this.barVersion.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // brVersion
            // 
            this.brVersion.Caption = "barVersion";
            this.brVersion.Id = 2;
            this.brVersion.Name = "brVersion";
            this.brVersion.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "Usuario";
            this.barStaticItem4.Id = 8;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barVersion";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Size = new System.Drawing.Size(0, 0);
            // 
            // err_cliente
            // 
            this.err_cliente.ContainerControl = this;
            this.err_cliente.Icon = ((System.Drawing.Icon)(resources.GetObject("err_cliente.Icon")));
            // 
            // err_empresa
            // 
            this.err_empresa.ContainerControl = this;
            this.err_empresa.Icon = ((System.Drawing.Icon)(resources.GetObject("err_empresa.Icon")));
            // 
            // err_dirigido
            // 
            this.err_dirigido.ContainerControl = this;
            this.err_dirigido.Icon = ((System.Drawing.Icon)(resources.GetObject("err_dirigido.Icon")));
            // 
            // err_productos
            // 
            this.err_productos.ContainerControl = this;
            this.err_productos.Icon = ((System.Drawing.Icon)(resources.GetObject("err_productos.Icon")));
            // 
            // btnEliminar
            // 
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // err_nombre
            // 
            this.err_nombre.ContainerControl = this;
            this.err_nombre.Icon = ((System.Drawing.Icon)(resources.GetObject("err_nombre.Icon")));
            // 
            // err_direccion
            // 
            this.err_direccion.ContainerControl = this;
            this.err_direccion.Icon = ((System.Drawing.Icon)(resources.GetObject("err_direccion.Icon")));
            // 
            // err_telefono
            // 
            this.err_telefono.ContainerControl = this;
            this.err_telefono.Icon = ((System.Drawing.Icon)(resources.GetObject("err_telefono.Icon")));
            // 
            // err_email
            // 
            this.err_email.ContainerControl = this;
            this.err_email.Icon = ((System.Drawing.Icon)(resources.GetObject("err_email.Icon")));
            // 
            // bkGuardar
            // 
            this.bkGuardar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkGuardar_DoWork);
            this.bkGuardar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkGuardar_RunWorkerCompleted);
            // 
            // err_ref
            // 
            this.err_ref.ContainerControl = this;
            this.err_ref.Icon = ((System.Drawing.Icon)(resources.GetObject("err_ref.Icon")));
            // 
            // err_debito_cuenta
            // 
            this.err_debito_cuenta.ContainerControl = this;
            this.err_debito_cuenta.Icon = ((System.Drawing.Icon)(resources.GetObject("err_debito_cuenta.Icon")));
            // 
            // err_cliente_R
            // 
            this.err_cliente_R.ContainerControl = this;
            this.err_cliente_R.Icon = ((System.Drawing.Icon)(resources.GetObject("err_cliente_R.Icon")));
            // 
            // err_Suc_Carga_R
            // 
            this.err_Suc_Carga_R.ContainerControl = this;
            this.err_Suc_Carga_R.Icon = ((System.Drawing.Icon)(resources.GetObject("err_Suc_Carga_R.Icon")));
            // 
            // err_Adjunto
            // 
            this.err_Adjunto.ContainerControl = this;
            this.err_Adjunto.Icon = ((System.Drawing.Icon)(resources.GetObject("err_Adjunto.Icon")));
            // 
            // gridViewAutorizar
            // 
            this.gridViewAutorizar.GridControl = this.gcAutorizar;
            this.gridViewAutorizar.Name = "gridViewAutorizar";
            this.gridViewAutorizar.OptionsView.ColumnAutoWidth = false;
            this.gridViewAutorizar.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewAutorizar.OptionsView.ShowGroupPanel = false;
            this.gridViewAutorizar.OptionsView.ShowIndicator = false;
            // 
            // gcAutorizar
            // 
            this.gcAutorizar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcAutorizar.Location = new System.Drawing.Point(12, 107);
            this.gcAutorizar.MainView = this.gridViewAutorizar;
            this.gcAutorizar.Margin = new System.Windows.Forms.Padding(4);
            this.gcAutorizar.MenuManager = this.barManager;
            this.gcAutorizar.Name = "gcAutorizar";
            this.gcAutorizar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnAprobar,
            this.btnRechazar,
            this.btnFormulario});
            this.gcAutorizar.Size = new System.Drawing.Size(865, 421);
            this.gcAutorizar.TabIndex = 0;
            this.gcAutorizar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAutorizar,
            this.gridView6});
            // 
            // btnAprobar
            // 
            this.btnAprobar.AutoHeight = false;
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.NullText = "N";
            this.btnAprobar.ValueChecked = "S";
            this.btnAprobar.ValueGrayed = 'N';
            this.btnAprobar.ValueUnchecked = "N";
            this.btnAprobar.EditValueChanged += new System.EventHandler(this.btnAprobar_EditValueChanged);
            // 
            // btnRechazar
            // 
            this.btnRechazar.AutoHeight = false;
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.NullText = "N";
            this.btnRechazar.ValueChecked = "S";
            this.btnRechazar.ValueGrayed = 'N';
            this.btnRechazar.ValueUnchecked = "N";
            this.btnRechazar.EditValueChanged += new System.EventHandler(this.btnRechazar_EditValueChanged);
            // 
            // btnFormulario
            // 
            this.btnFormulario.AutoHeight = false;
            this.btnFormulario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.TopCenter, ((System.Drawing.Image)(resources.GetObject("btnFormulario.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnFormulario.Name = "btnFormulario";
            this.btnFormulario.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnFormulario.Click += new System.EventHandler(this.btnFormulario_Click);
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.gcAutorizar;
            this.gridView6.Name = "gridView6";
            // 
            // tabReporte
            // 
            this.tabReporte.Controls.Add(this.txtCuentaR);
            this.tabReporte.Controls.Add(this.labelControl1);
            this.tabReporte.Controls.Add(this.txtNroTelefonoR);
            this.tabReporte.Controls.Add(this.btLimpiarR);
            this.tabReporte.Controls.Add(this.btBuscarR);
            this.tabReporte.Controls.Add(this.btExportarR);
            this.tabReporte.Controls.Add(this.lbCodClienteR);
            this.tabReporte.Controls.Add(this.txtCodClienteR);
            this.tabReporte.Controls.Add(this.lbSucCargaR);
            this.tabReporte.Controls.Add(this.lbFechaFin);
            this.tabReporte.Controls.Add(this.dtFechaFin);
            this.tabReporte.Controls.Add(this.lbFechaInicio);
            this.tabReporte.Controls.Add(this.dtFechaIni);
            this.tabReporte.Controls.Add(this.gcReporte);
            this.tabReporte.Controls.Add(this.lbImpresion);
            this.tabReporte.Margin = new System.Windows.Forms.Padding(4);
            this.tabReporte.Name = "tabReporte";
            this.tabReporte.Size = new System.Drawing.Size(892, 672);
            this.tabReporte.Text = "Reporte";
            // 
            // txtCuentaR
            // 
            this.txtCuentaR.Location = new System.Drawing.Point(240, 129);
            this.txtCuentaR.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuentaR.MenuManager = this.barManager;
            this.txtCuentaR.Name = "txtCuentaR";
            this.txtCuentaR.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaR.Properties.MaxLength = 20;
            this.txtCuentaR.Size = new System.Drawing.Size(133, 22);
            this.txtCuentaR.TabIndex = 1020;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(103, 163);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(122, 16);
            this.labelControl1.TabIndex = 1019;
            this.labelControl1.Text = "Numero de Telefono:";
            this.labelControl1.ToolTipTitle = "Código del cliente";
            // 
            // txtNroTelefonoR
            // 
            this.txtNroTelefonoR.Location = new System.Drawing.Point(240, 160);
            this.txtNroTelefonoR.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroTelefonoR.MenuManager = this.barManager;
            this.txtNroTelefonoR.Name = "txtNroTelefonoR";
            this.txtNroTelefonoR.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroTelefonoR.Properties.MaxLength = 20;
            this.txtNroTelefonoR.Size = new System.Drawing.Size(133, 22);
            this.txtNroTelefonoR.TabIndex = 1018;
            // 
            // btLimpiarR
            // 
            this.btLimpiarR.Image = ((System.Drawing.Image)(resources.GetObject("btLimpiarR.Image")));
            this.btLimpiarR.Location = new System.Drawing.Point(656, 146);
            this.btLimpiarR.Margin = new System.Windows.Forms.Padding(4);
            this.btLimpiarR.Name = "btLimpiarR";
            this.btLimpiarR.Size = new System.Drawing.Size(105, 28);
            this.btLimpiarR.TabIndex = 9;
            this.btLimpiarR.Text = "&Limpiar";
            this.btLimpiarR.ToolTip = "Presione Alt + L";
            this.btLimpiarR.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btLimpiarR.ToolTipTitle = "Combinación de Teclas";
            this.btLimpiarR.Click += new System.EventHandler(this.btLimpiarR_Click);
            // 
            // btBuscarR
            // 
            this.btBuscarR.Image = global::f2.Properties.Resources.view;
            this.btBuscarR.Location = new System.Drawing.Point(656, 110);
            this.btBuscarR.Margin = new System.Windows.Forms.Padding(4);
            this.btBuscarR.Name = "btBuscarR";
            this.btBuscarR.Size = new System.Drawing.Size(105, 28);
            this.btBuscarR.TabIndex = 7;
            this.btBuscarR.Text = "&Buscar";
            this.btBuscarR.ToolTip = "Presione Alt + B";
            this.btBuscarR.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btBuscarR.ToolTipTitle = "Combinación de Teclas";
            this.btBuscarR.Click += new System.EventHandler(this.btBuscarR_Click);
            // 
            // btExportarR
            // 
            this.btExportarR.Image = global::f2.Properties.Resources.excel;
            this.btExportarR.Location = new System.Drawing.Point(656, 601);
            this.btExportarR.Margin = new System.Windows.Forms.Padding(4);
            this.btExportarR.Name = "btExportarR";
            this.btExportarR.Size = new System.Drawing.Size(105, 28);
            this.btExportarR.TabIndex = 8;
            this.btExportarR.Text = "&Exportar";
            this.btExportarR.ToolTip = "Presione Alt + E";
            this.btExportarR.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btExportarR.ToolTipTitle = "Combinación de Teclas";
            this.btExportarR.Click += new System.EventHandler(this.btExportarR_Click);
            // 
            // lbCodClienteR
            // 
            this.lbCodClienteR.Location = new System.Drawing.Point(120, 99);
            this.lbCodClienteR.Margin = new System.Windows.Forms.Padding(4);
            this.lbCodClienteR.Name = "lbCodClienteR";
            this.lbCodClienteR.Size = new System.Drawing.Size(105, 16);
            this.lbCodClienteR.TabIndex = 1017;
            this.lbCodClienteR.Text = "Codigo de Cliente:";
            this.lbCodClienteR.ToolTipTitle = "Código del cliente";
            // 
            // txtCodClienteR
            // 
            this.txtCodClienteR.Location = new System.Drawing.Point(240, 96);
            this.txtCodClienteR.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodClienteR.MenuManager = this.barManager;
            this.txtCodClienteR.Name = "txtCodClienteR";
            this.txtCodClienteR.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodClienteR.Properties.MaxLength = 6;
            this.txtCodClienteR.Size = new System.Drawing.Size(133, 22);
            this.txtCodClienteR.TabIndex = 2;
            this.txtCodClienteR.EditValueChanged += new System.EventHandler(this.txtCodClienteR_EditValueChanged);
            // 
            // lbSucCargaR
            // 
            this.lbSucCargaR.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbSucCargaR.Location = new System.Drawing.Point(180, 132);
            this.lbSucCargaR.Margin = new System.Windows.Forms.Padding(4);
            this.lbSucCargaR.Name = "lbSucCargaR";
            this.lbSucCargaR.Size = new System.Drawing.Size(45, 16);
            this.lbSucCargaR.TabIndex = 1015;
            this.lbSucCargaR.Text = "Cuenta:";
            this.lbSucCargaR.ToolTipTitle = "Sucursal de Carga";
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFechaFin.Location = new System.Drawing.Point(440, 132);
            this.lbFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(37, 16);
            this.lbFechaFin.TabIndex = 1009;
            this.lbFechaFin.Text = "Hasta:";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.EditValue = null;
            this.dtFechaFin.Location = new System.Drawing.Point(491, 129);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaFin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFechaFin.Size = new System.Drawing.Size(133, 22);
            this.dtFechaFin.TabIndex = 6;
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbFechaInicio.Location = new System.Drawing.Point(437, 99);
            this.lbFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(40, 16);
            this.lbFechaInicio.TabIndex = 1008;
            this.lbFechaInicio.Text = "Desde:";
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.EditValue = null;
            this.dtFechaIni.Location = new System.Drawing.Point(491, 96);
            this.dtFechaIni.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaIni.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFechaIni.Size = new System.Drawing.Size(133, 22);
            this.dtFechaIni.TabIndex = 5;
            // 
            // gcReporte
            // 
            this.gcReporte.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcReporte.Location = new System.Drawing.Point(18, 207);
            this.gcReporte.MainView = this.gridViewReporte;
            this.gcReporte.Margin = new System.Windows.Forms.Padding(4);
            this.gcReporte.MenuManager = this.barManager;
            this.gcReporte.Name = "gcReporte";
            this.gcReporte.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnReporte,
            this.btnFormularioR});
            this.gcReporte.Size = new System.Drawing.Size(865, 382);
            this.gcReporte.TabIndex = 1003;
            this.gcReporte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReporte});
            // 
            // gridViewReporte
            // 
            this.gridViewReporte.GridControl = this.gcReporte;
            this.gridViewReporte.Name = "gridViewReporte";
            this.gridViewReporte.OptionsView.ColumnAutoWidth = false;
            this.gridViewReporte.OptionsView.ShowAutoFilterRow = true;
            this.gridViewReporte.OptionsView.ShowGroupPanel = false;
            // 
            // btnReporte
            // 
            this.btnReporte.AutoHeight = false;
            this.btnReporte.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.TopCenter, ((System.Drawing.Image)(resources.GetObject("btnReporte.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnReporte.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnReporte_ButtonClick);
            // 
            // btnFormularioR
            // 
            this.btnFormularioR.AutoHeight = false;
            this.btnFormularioR.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.TopCenter, ((System.Drawing.Image)(resources.GetObject("btnFormularioR.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnFormularioR.Name = "btnFormularioR";
            this.btnFormularioR.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnFormularioR.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnFormularioR_ButtonClick);
            // 
            // lbImpresion
            // 
            this.lbImpresion.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImpresion.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbImpresion.Location = new System.Drawing.Point(344, 33);
            this.lbImpresion.Margin = new System.Windows.Forms.Padding(4);
            this.lbImpresion.Name = "lbImpresion";
            this.lbImpresion.Size = new System.Drawing.Size(190, 28);
            this.lbImpresion.TabIndex = 1002;
            this.lbImpresion.Text = "Reporte de Catastros";
            // 
            // tabAutorizador
            // 
            this.tabAutorizador.Controls.Add(this.btRefrescar);
            this.tabAutorizador.Controls.Add(this.btGrabar);
            this.tabAutorizador.Controls.Add(this.gcAutorizar);
            this.tabAutorizador.Controls.Add(this.lbEmpresaEntidad);
            this.tabAutorizador.Margin = new System.Windows.Forms.Padding(4);
            this.tabAutorizador.Name = "tabAutorizador";
            this.tabAutorizador.Size = new System.Drawing.Size(892, 672);
            this.tabAutorizador.Text = "Autorizaciones";
            // 
            // btRefrescar
            // 
            this.btRefrescar.Location = new System.Drawing.Point(743, 551);
            this.btRefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btRefrescar.Name = "btRefrescar";
            this.btRefrescar.Size = new System.Drawing.Size(87, 28);
            this.btRefrescar.TabIndex = 6;
            this.btRefrescar.Text = "&Refrescar";
            this.btRefrescar.ToolTip = "Presione Alt + L";
            this.btRefrescar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btRefrescar.ToolTipTitle = "Combinación de Teclas";
            this.btRefrescar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btGrabar
            // 
            this.btGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btGrabar.Image")));
            this.btGrabar.Location = new System.Drawing.Point(636, 551);
            this.btGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btGrabar.Name = "btGrabar";
            this.btGrabar.Size = new System.Drawing.Size(87, 28);
            this.btGrabar.TabIndex = 5;
            this.btGrabar.Text = "&Grabar";
            this.btGrabar.ToolTip = "Presione Alt + G";
            this.btGrabar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btGrabar.ToolTipTitle = "Combinación de Teclas";
            this.btGrabar.Click += new System.EventHandler(this.btGrabar_Click);
            // 
            // lbEmpresaEntidad
            // 
            this.lbEmpresaEntidad.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbEmpresaEntidad.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbEmpresaEntidad.Location = new System.Drawing.Point(332, 30);
            this.lbEmpresaEntidad.Margin = new System.Windows.Forms.Padding(4);
            this.lbEmpresaEntidad.Name = "lbEmpresaEntidad";
            this.lbEmpresaEntidad.Size = new System.Drawing.Size(224, 28);
            this.lbEmpresaEntidad.TabIndex = 1010;
            this.lbEmpresaEntidad.Text = "Autorizador de Catastros";
            // 
            // tabRegistro
            // 
            this.tabRegistro.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabRegistro.Appearance.PageClient.Options.UseBackColor = true;
            this.tabRegistro.Controls.Add(this.txtTelefono);
            this.tabRegistro.Controls.Add(this.labelControl2);
            this.tabRegistro.Controls.Add(this.txtFormulario);
            this.tabRegistro.Controls.Add(this.rgTipoCatastro);
            this.tabRegistro.Controls.Add(this.labelControl12);
            this.tabRegistro.Controls.Add(this.btNotaCliente);
            this.tabRegistro.Controls.Add(this.lbNotaCliente);
            this.tabRegistro.Controls.Add(this.lbTipoPago);
            this.tabRegistro.Controls.Add(this.combo_debito_cuenta);
            this.tabRegistro.Controls.Add(this.lbDebito_Cuenta);
            this.tabRegistro.Controls.Add(this.btlimpiar_carta);
            this.tabRegistro.Controls.Add(this.lbValidProducts);
            this.tabRegistro.Controls.Add(this.btManual);
            this.tabRegistro.Controls.Add(this.txtNombreCliente);
            this.tabRegistro.Controls.Add(this.lbCartaReferencia);
            this.tabRegistro.Controls.Add(this.lbCod_Cliente);
            this.tabRegistro.Controls.Add(this.txtCodCliente);
            this.tabRegistro.Controls.Add(this.btnGuardar);
            this.tabRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Size = new System.Drawing.Size(892, 672);
            this.tabRegistro.Text = "Registro";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(251, 157);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MenuManager = this.barManager;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Properties.MaxLength = 50;
            this.txtTelefono.Size = new System.Drawing.Size(133, 22);
            this.txtTelefono.TabIndex = 1034;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(173, 161);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 16);
            this.labelControl2.TabIndex = 1033;
            this.labelControl2.Text = "Telefono:";
            // 
            // txtFormulario
            // 
            this.txtFormulario.EditValue = "Ruta del archivo";
            this.txtFormulario.Enabled = false;
            this.txtFormulario.Location = new System.Drawing.Point(251, 232);
            this.txtFormulario.MenuManager = this.barManager;
            this.txtFormulario.Name = "txtFormulario";
            this.txtFormulario.Size = new System.Drawing.Size(295, 22);
            this.txtFormulario.TabIndex = 1032;
            // 
            // rgTipoCatastro
            // 
            this.rgTipoCatastro.EditValue = 'D';
            this.rgTipoCatastro.Location = new System.Drawing.Point(251, 187);
            this.rgTipoCatastro.Margin = new System.Windows.Forms.Padding(4);
            this.rgTipoCatastro.Name = "rgTipoCatastro";
            this.rgTipoCatastro.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem('I', "IN"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('O', "OUT"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('A', "AMBOS")});
            this.rgTipoCatastro.Size = new System.Drawing.Size(356, 33);
            this.rgTipoCatastro.TabIndex = 5;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(401, 103);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(50, 16);
            this.labelControl12.TabIndex = 1031;
            this.labelControl12.Text = "Nombre:";
            // 
            // btNotaCliente
            // 
            this.btNotaCliente.Image = global::f2.Properties.Resources.adjunto;
            this.btNotaCliente.Location = new System.Drawing.Point(553, 228);
            this.btNotaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btNotaCliente.Name = "btNotaCliente";
            this.btNotaCliente.Size = new System.Drawing.Size(105, 32);
            this.btNotaCliente.TabIndex = 7;
            this.btNotaCliente.Text = "&Adjuntar";
            this.btNotaCliente.ToolTip = "Presione Alt + A";
            this.btNotaCliente.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btNotaCliente.ToolTipTitle = "Combinación de Teclas";
            this.btNotaCliente.Click += new System.EventHandler(this.btNotaCliente_Click);
            // 
            // lbNotaCliente
            // 
            this.lbNotaCliente.Location = new System.Drawing.Point(163, 235);
            this.lbNotaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.lbNotaCliente.Name = "lbNotaCliente";
            this.lbNotaCliente.Size = new System.Drawing.Size(67, 16);
            this.lbNotaCliente.TabIndex = 1030;
            this.lbNotaCliente.Text = "Formulario:";
            // 
            // lbTipoPago
            // 
            this.lbTipoPago.Location = new System.Drawing.Point(148, 196);
            this.lbTipoPago.Margin = new System.Windows.Forms.Padding(4);
            this.lbTipoPago.Name = "lbTipoPago";
            this.lbTipoPago.Size = new System.Drawing.Size(82, 16);
            this.lbTipoPago.TabIndex = 1029;
            this.lbTipoPago.Text = "Tipo Catastro:";
            // 
            // combo_debito_cuenta
            // 
            this.combo_debito_cuenta.Location = new System.Drawing.Point(251, 128);
            this.combo_debito_cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.combo_debito_cuenta.MenuManager = this.barManager;
            this.combo_debito_cuenta.Name = "combo_debito_cuenta";
            this.combo_debito_cuenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combo_debito_cuenta.Properties.NullText = "";
            this.combo_debito_cuenta.Properties.PopupSizeable = false;
            this.combo_debito_cuenta.Properties.PopupWidth = 400;
            this.combo_debito_cuenta.Size = new System.Drawing.Size(503, 22);
            this.combo_debito_cuenta.TabIndex = 6;
            // 
            // lbDebito_Cuenta
            // 
            this.lbDebito_Cuenta.Location = new System.Drawing.Point(183, 133);
            this.lbDebito_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.lbDebito_Cuenta.Name = "lbDebito_Cuenta";
            this.lbDebito_Cuenta.Size = new System.Drawing.Size(45, 16);
            this.lbDebito_Cuenta.TabIndex = 1027;
            this.lbDebito_Cuenta.Text = "Cuenta:";
            // 
            // btlimpiar_carta
            // 
            this.btlimpiar_carta.Image = ((System.Drawing.Image)(resources.GetObject("btlimpiar_carta.Image")));
            this.btlimpiar_carta.Location = new System.Drawing.Point(694, 550);
            this.btlimpiar_carta.Margin = new System.Windows.Forms.Padding(4);
            this.btlimpiar_carta.Name = "btlimpiar_carta";
            this.btlimpiar_carta.Size = new System.Drawing.Size(87, 28);
            this.btlimpiar_carta.TabIndex = 18;
            this.btlimpiar_carta.Text = "&Limpiar";
            this.btlimpiar_carta.ToolTip = "Presione Alt + L";
            this.btlimpiar_carta.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btlimpiar_carta.ToolTipTitle = "Combinación de Teclas";
            this.btlimpiar_carta.Click += new System.EventHandler(this.btLimpiarCarta_Click);
            // 
            // lbValidProducts
            // 
            this.lbValidProducts.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.lbValidProducts.Location = new System.Drawing.Point(692, 476);
            this.lbValidProducts.Margin = new System.Windows.Forms.Padding(4);
            this.lbValidProducts.Name = "lbValidProducts";
            this.lbValidProducts.Size = new System.Drawing.Size(4, 16);
            this.lbValidProducts.TabIndex = 1018;
            this.lbValidProducts.Text = ".";
            // 
            // btManual
            // 
            this.btManual.Image = ((System.Drawing.Image)(resources.GetObject("btManual.Image")));
            this.btManual.Location = new System.Drawing.Point(768, 4);
            this.btManual.Margin = new System.Windows.Forms.Padding(4);
            this.btManual.Name = "btManual";
            this.btManual.Size = new System.Drawing.Size(119, 41);
            this.btManual.TabIndex = 1012;
            this.btManual.Text = "&Manual";
            this.btManual.ToolTip = "Presione Alt + M";
            this.btManual.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btManual.ToolTipTitle = "Combinación de Teclas";
            this.btManual.Click += new System.EventHandler(this.btManual_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(459, 100);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.MenuManager = this.barManager;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(294, 22);
            this.txtNombreCliente.TabIndex = 4;
            // 
            // lbCartaReferencia
            // 
            this.lbCartaReferencia.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartaReferencia.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lbCartaReferencia.Location = new System.Drawing.Point(256, 33);
            this.lbCartaReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.lbCartaReferencia.Name = "lbCartaReferencia";
            this.lbCartaReferencia.Size = new System.Drawing.Size(392, 28);
            this.lbCartaReferencia.TabIndex = 1000;
            this.lbCartaReferencia.Text = "Mantenimiento de Cuentas de Tigo Money";
            // 
            // lbCod_Cliente
            // 
            this.lbCod_Cliente.Location = new System.Drawing.Point(120, 103);
            this.lbCod_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.lbCod_Cliente.Name = "lbCod_Cliente";
            this.lbCod_Cliente.Size = new System.Drawing.Size(108, 16);
            this.lbCod_Cliente.TabIndex = 999;
            this.lbCod_Cliente.Text = "Codigo del Cliente:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(251, 100);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodCliente.MenuManager = this.barManager;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCliente.Properties.MaxLength = 6;
            this.txtCodCliente.Size = new System.Drawing.Size(133, 22);
            this.txtCodCliente.TabIndex = 2;
            this.txtCodCliente.Validated += new System.EventHandler(this.txtCodCliente_Validated);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(578, 550);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 28);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.ToolTip = "Presione Alt + E";
            this.btnGuardar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnGuardar.ToolTipTitle = "Combinación de Teclas";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tabModulos
            // 
            this.tabModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabModulos.Location = new System.Drawing.Point(0, 0);
            this.tabModulos.LookAndFeel.SkinName = "Blue";
            this.tabModulos.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tabModulos.Margin = new System.Windows.Forms.Padding(4);
            this.tabModulos.Name = "tabModulos";
            this.tabModulos.SelectedTabPage = this.tabRegistro;
            this.tabModulos.Size = new System.Drawing.Size(897, 700);
            this.tabModulos.TabIndex = 0;
            this.tabModulos.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabRegistro,
            this.tabAutorizador,
            this.tabReporte});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(897, 730);
            this.Controls.Add(this.tabModulos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Continental S.A.E.C.A.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_empresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_dirigido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_direccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_telefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_ref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_debito_cuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_cliente_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Suc_Carga_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Adjunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAutorizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAutorizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAprobar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRechazar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFormulario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.tabReporte.ResumeLayout(false);
            this.tabReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroTelefonoR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodClienteR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIni.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFormularioR)).EndInit();
            this.tabAutorizador.ResumeLayout(false);
            this.tabAutorizador.PerformLayout();
            this.tabRegistro.ResumeLayout(false);
            this.tabRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormulario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipoCatastro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_debito_cuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabModulos)).EndInit();
            this.tabModulos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barVersion;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarStaticItem brVersion;
        private System.Windows.Forms.ErrorProvider err_cliente;
        private System.Windows.Forms.ErrorProvider err_empresa;
        private System.Windows.Forms.ErrorProvider err_dirigido;
        private System.Windows.Forms.ErrorProvider err_productos;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEliminar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private System.Windows.Forms.ErrorProvider err_nombre;
        private System.Windows.Forms.ErrorProvider err_direccion;
        private System.Windows.Forms.ErrorProvider err_telefono;
        private System.Windows.Forms.ErrorProvider err_email;
        private System.ComponentModel.BackgroundWorker bkGuardar;
        private System.Windows.Forms.ErrorProvider err_ref;
        private System.Windows.Forms.ErrorProvider err_debito_cuenta;
        private System.ComponentModel.BackgroundWorker bkImpresion;
        private System.Windows.Forms.ErrorProvider err_cliente_R;
        private System.Windows.Forms.ErrorProvider err_Suc_Carga_R;
        private System.Windows.Forms.ErrorProvider err_Adjunto;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraTab.XtraTabControl tabModulos;
        private DevExpress.XtraTab.XtraTabPage tabRegistro;
        private DevExpress.XtraEditors.SimpleButton btNotaCliente;
        private DevExpress.XtraEditors.LabelControl lbNotaCliente;
        private DevExpress.XtraEditors.LabelControl lbTipoPago;
        private DevExpress.XtraEditors.RadioGroup rgTipoCatastro;
        private DevExpress.XtraEditors.LookUpEdit combo_debito_cuenta;
        private DevExpress.XtraEditors.LabelControl lbDebito_Cuenta;
        private DevExpress.XtraEditors.SimpleButton btlimpiar_carta;
        private DevExpress.XtraEditors.LabelControl lbValidProducts;
        private DevExpress.XtraEditors.SimpleButton btManual;
        private DevExpress.XtraEditors.TextEdit txtNombreCliente;
        private DevExpress.XtraEditors.LabelControl lbCartaReferencia;
        private DevExpress.XtraEditors.LabelControl lbCod_Cliente;
        private DevExpress.XtraEditors.TextEdit txtCodCliente;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraTab.XtraTabPage tabAutorizador;
        private DevExpress.XtraEditors.SimpleButton btRefrescar;
        private DevExpress.XtraEditors.SimpleButton btGrabar;
        private DevExpress.XtraGrid.GridControl gcAutorizar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAutorizar;
        private DevExpress.XtraEditors.LabelControl lbEmpresaEntidad;
        private DevExpress.XtraTab.XtraTabPage tabReporte;
        private DevExpress.XtraEditors.SimpleButton btLimpiarR;
        private DevExpress.XtraEditors.SimpleButton btBuscarR;
        private DevExpress.XtraEditors.SimpleButton btExportarR;
        private DevExpress.XtraEditors.LabelControl lbCodClienteR;
        private DevExpress.XtraEditors.TextEdit txtCodClienteR;
        private DevExpress.XtraEditors.LabelControl lbSucCargaR;
        private DevExpress.XtraEditors.LabelControl lbFechaFin;
        private DevExpress.XtraEditors.DateEdit dtFechaFin;
        private DevExpress.XtraEditors.LabelControl lbFechaInicio;
        private DevExpress.XtraEditors.DateEdit dtFechaIni;
        private DevExpress.XtraGrid.GridControl gcReporte;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReporte;
        private DevExpress.XtraEditors.LabelControl lbImpresion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtFormulario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNroTelefonoR;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit btnAprobar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit btnRechazar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnFormulario;
        private DevExpress.XtraEditors.TextEdit txtCuentaR;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnReporte;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnFormularioR;
    }
}

