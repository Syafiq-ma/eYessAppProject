namespace eYes_DesktopApp_Proj
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label totalTimeLabel;
            System.Windows.Forms.Label timePerUseLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.recordHistoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.recordHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBRecordHistoryDataSet = new eYes_DesktopApp_Proj.DBRecordHistoryDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recordHistoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalTimeTextBox = new System.Windows.Forms.TextBox();
            this.timePerUseTextBox = new System.Windows.Forms.TextBox();
            this.recordHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCek = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnPesan = new System.Windows.Forms.Button();
            this.dtFilter = new System.Windows.Forms.DateTimePicker();
            this.tbTampilkanDate = new System.Windows.Forms.TextBox();
            this.tbTampilkanTotalTime = new System.Windows.Forms.TextBox();
            this.tbTampilkanTimePerUse = new System.Windows.Forms.TextBox();
            this.chartHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.recordHistoryTableAdapter = new eYes_DesktopApp_Proj.DBRecordHistoryDataSetTableAdapters.RecordHistoryTableAdapter();
            this.tableAdapterManager = new eYes_DesktopApp_Proj.DBRecordHistoryDataSetTableAdapters.TableAdapterManager();
            dateLabel = new System.Windows.Forms.Label();
            totalTimeLabel = new System.Windows.Forms.Label();
            timePerUseLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recordHistoryBindingNavigator)).BeginInit();
            this.recordHistoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBRecordHistoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(366, 110);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(119, 20);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Tanggal hari ini:";
            // 
            // totalTimeLabel
            // 
            totalTimeLabel.AutoSize = true;
            totalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalTimeLabel.Location = new System.Drawing.Point(297, 145);
            totalTimeLabel.Name = "totalTimeLabel";
            totalTimeLabel.Size = new System.Drawing.Size(188, 20);
            totalTimeLabel.TabIndex = 5;
            totalTimeLabel.Text = "Total waktu penggunaan:";
            // 
            // timePerUseLabel
            // 
            timePerUseLabel.AutoSize = true;
            timePerUseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timePerUseLabel.Location = new System.Drawing.Point(285, 177);
            timePerUseLabel.Name = "timePerUseLabel";
            timePerUseLabel.Size = new System.Drawing.Size(200, 20);
            timePerUseLabel.TabIndex = 7;
            timePerUseLabel.Text = "Durasi setiap penggunaan:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(851, 425);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(188, 20);
            label5.TabIndex = 44;
            label5.Text = "Total waktu penggunaan:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(839, 454);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(200, 20);
            label12.TabIndex = 45;
            label12.Text = "Durasi setiap penggunaan:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(521, 25);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(219, 29);
            label11.TabIndex = 40;
            label11.Text = "eYes Application";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(428, 54);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(392, 18);
            label10.TabIndex = 39;
            label10.Text = "memotivasimu agar selalu ingat akan kesehatan mata kamu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(1001, 283);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(84, 20);
            label9.TabIndex = 38;
            label9.Text = "Cek Data";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(877, 318);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(98, 20);
            label8.TabIndex = 37;
            label8.Text = "Pilih tanggal:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(969, 390);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 20);
            label7.TabIndex = 36;
            label7.Text = "Tanggal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(1107, 454);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 20);
            label4.TabIndex = 35;
            label4.Text = "jam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(1107, 425);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 20);
            label3.TabIndex = 34;
            label3.Text = "jam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(604, 177);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 20);
            label2.TabIndex = 47;
            label2.Text = "jam";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(604, 145);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 20);
            label1.TabIndex = 48;
            label1.Text = "jam";
            // 
            // recordHistoryBindingNavigator
            // 
            this.recordHistoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.recordHistoryBindingNavigator.BindingSource = this.recordHistoryBindingSource;
            this.recordHistoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.recordHistoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.recordHistoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.recordHistoryBindingNavigatorSaveItem});
            this.recordHistoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.recordHistoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.recordHistoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.recordHistoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.recordHistoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.recordHistoryBindingNavigator.Name = "recordHistoryBindingNavigator";
            this.recordHistoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.recordHistoryBindingNavigator.Size = new System.Drawing.Size(1246, 25);
            this.recordHistoryBindingNavigator.TabIndex = 0;
            this.recordHistoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // recordHistoryBindingSource
            // 
            this.recordHistoryBindingSource.DataMember = "RecordHistory";
            this.recordHistoryBindingSource.DataSource = this.dBRecordHistoryDataSet;
            // 
            // dBRecordHistoryDataSet
            // 
            this.dBRecordHistoryDataSet.DataSetName = "DBRecordHistoryDataSet";
            this.dBRecordHistoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // recordHistoryBindingNavigatorSaveItem
            // 
            this.recordHistoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recordHistoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("recordHistoryBindingNavigatorSaveItem.Image")));
            this.recordHistoryBindingNavigatorSaveItem.Name = "recordHistoryBindingNavigatorSaveItem";
            this.recordHistoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.recordHistoryBindingNavigatorSaveItem.Text = "Save Data";
            this.recordHistoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.recordHistoryBindingNavigatorSaveItem_Click);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.recordHistoryBindingSource, "Date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(493, 110);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(186, 26);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // totalTimeTextBox
            // 
            this.totalTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordHistoryBindingSource, "TotalTime", true));
            this.totalTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTimeTextBox.Location = new System.Drawing.Point(493, 142);
            this.totalTimeTextBox.Name = "totalTimeTextBox";
            this.totalTimeTextBox.Size = new System.Drawing.Size(105, 26);
            this.totalTimeTextBox.TabIndex = 6;
            this.totalTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalTimeTextBox_KeyPress);
            // 
            // timePerUseTextBox
            // 
            this.timePerUseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recordHistoryBindingSource, "TimePerUse", true));
            this.timePerUseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePerUseTextBox.Location = new System.Drawing.Point(493, 174);
            this.timePerUseTextBox.Name = "timePerUseTextBox";
            this.timePerUseTextBox.Size = new System.Drawing.Size(105, 26);
            this.timePerUseTextBox.TabIndex = 8;
            this.timePerUseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timePerUseTextBox_KeyPress);
            // 
            // recordHistoryDataGridView
            // 
            this.recordHistoryDataGridView.AutoGenerateColumns = false;
            this.recordHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.recordHistoryDataGridView.DataSource = this.recordHistoryBindingSource;
            this.recordHistoryDataGridView.Location = new System.Drawing.Point(12, 283);
            this.recordHistoryDataGridView.Name = "recordHistoryDataGridView";
            this.recordHistoryDataGridView.Size = new System.Drawing.Size(344, 220);
            this.recordHistoryDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TotalTime";
            this.dataGridViewTextBoxColumn3.HeaderText = "TotalTime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TimePerUse";
            this.dataGridViewTextBoxColumn4.HeaderText = "TimePerUse";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnCek
            // 
            this.btnCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCek.Location = new System.Drawing.Point(1182, 315);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(52, 26);
            this.btnCek.TabIndex = 43;
            this.btnCek.Text = "Cek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // btnChart
            // 
            this.btnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.Location = new System.Drawing.Point(558, 249);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(121, 32);
            this.btnChart.TabIndex = 42;
            this.btnChart.Text = "Load Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnPesan
            // 
            this.btnPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesan.Location = new System.Drawing.Point(729, 129);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(182, 52);
            this.btnPesan.TabIndex = 41;
            this.btnPesan.Text = "Lihat pesanmu hari ini";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // dtFilter
            // 
            this.dtFilter.CustomFormat = "dd/MM/yyyy";
            this.dtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFilter.Location = new System.Drawing.Point(981, 315);
            this.dtFilter.Name = "dtFilter";
            this.dtFilter.Size = new System.Drawing.Size(184, 26);
            this.dtFilter.TabIndex = 33;
            // 
            // tbTampilkanDate
            // 
            this.tbTampilkanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTampilkanDate.Location = new System.Drawing.Point(1047, 387);
            this.tbTampilkanDate.Name = "tbTampilkanDate";
            this.tbTampilkanDate.ReadOnly = true;
            this.tbTampilkanDate.Size = new System.Drawing.Size(86, 26);
            this.tbTampilkanDate.TabIndex = 32;
            // 
            // tbTampilkanTotalTime
            // 
            this.tbTampilkanTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTampilkanTotalTime.Location = new System.Drawing.Point(1047, 419);
            this.tbTampilkanTotalTime.Name = "tbTampilkanTotalTime";
            this.tbTampilkanTotalTime.ReadOnly = true;
            this.tbTampilkanTotalTime.Size = new System.Drawing.Size(54, 26);
            this.tbTampilkanTotalTime.TabIndex = 31;
            // 
            // tbTampilkanTimePerUse
            // 
            this.tbTampilkanTimePerUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTampilkanTimePerUse.Location = new System.Drawing.Point(1047, 451);
            this.tbTampilkanTimePerUse.Name = "tbTampilkanTimePerUse";
            this.tbTampilkanTimePerUse.ReadOnly = true;
            this.tbTampilkanTimePerUse.Size = new System.Drawing.Size(54, 26);
            this.tbTampilkanTimePerUse.TabIndex = 30;
            // 
            // chartHistory
            // 
            chartArea4.Name = "ChartArea1";
            this.chartHistory.ChartAreas.Add(chartArea4);
            this.chartHistory.DataSource = this.recordHistoryBindingSource;
            legend4.Name = "Legend1";
            this.chartHistory.Legends.Add(legend4);
            this.chartHistory.Location = new System.Drawing.Point(378, 283);
            this.chartHistory.Name = "chartHistory";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Total waktu penggunaan";
            series7.XValueMember = "Date";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series7.YValueMembers = "TotalTime";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Durasi setiap penggunaan";
            series8.XValueMember = "Date";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series8.YValueMembers = "TimePerUse";
            this.chartHistory.Series.Add(series7);
            this.chartHistory.Series.Add(series8);
            this.chartHistory.Size = new System.Drawing.Size(455, 220);
            this.chartHistory.TabIndex = 46;
            this.chartHistory.Text = "chart1";
            // 
            // recordHistoryTableAdapter
            // 
            this.recordHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RecordHistoryTableAdapter = this.recordHistoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = eYes_DesktopApp_Proj.DBRecordHistoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 515);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(this.chartHistory);
            this.Controls.Add(label5);
            this.Controls.Add(label12);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(label11);
            this.Controls.Add(label10);
            this.Controls.Add(label9);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.dtFilter);
            this.Controls.Add(this.tbTampilkanDate);
            this.Controls.Add(this.tbTampilkanTotalTime);
            this.Controls.Add(this.tbTampilkanTimePerUse);
            this.Controls.Add(this.recordHistoryDataGridView);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(totalTimeLabel);
            this.Controls.Add(this.totalTimeTextBox);
            this.Controls.Add(timePerUseLabel);
            this.Controls.Add(this.timePerUseTextBox);
            this.Controls.Add(this.recordHistoryBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "eYes DesktopApp";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordHistoryBindingNavigator)).EndInit();
            this.recordHistoryBindingNavigator.ResumeLayout(false);
            this.recordHistoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBRecordHistoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBRecordHistoryDataSet dBRecordHistoryDataSet;
        private System.Windows.Forms.BindingSource recordHistoryBindingSource;
        private DBRecordHistoryDataSetTableAdapters.RecordHistoryTableAdapter recordHistoryTableAdapter;
        private DBRecordHistoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator recordHistoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton recordHistoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox totalTimeTextBox;
        private System.Windows.Forms.TextBox timePerUseTextBox;
        private System.Windows.Forms.DataGridView recordHistoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.DateTimePicker dtFilter;
        private System.Windows.Forms.TextBox tbTampilkanDate;
        private System.Windows.Forms.TextBox tbTampilkanTotalTime;
        private System.Windows.Forms.TextBox tbTampilkanTimePerUse;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistory;
    }
}

