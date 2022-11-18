namespace NUGGET
{
    partial class AirportForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenuMS = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Correction = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeliteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsTS = new System.Windows.Forms.ToolStrip();
            this.AddTool = new System.Windows.Forms.ToolStripButton();
            this.ChangeTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeliteTool = new System.Windows.Forms.ToolStripButton();
            this.FlightsDGV = new System.Windows.Forms.DataGridView();
            this.numFlightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price4PasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countCrewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price4CrewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procDopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoSS = new System.Windows.Forms.StatusStrip();
            this.CountFlightsTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountPasTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountCrewTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.SumTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuMS.SuspendLayout();
            this.toolsTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlightsDGV)).BeginInit();
            this.infoSS.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuMS
            // 
            this.mainMenuMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Correction,
            this.About});
            this.mainMenuMS.Location = new System.Drawing.Point(0, 0);
            this.mainMenuMS.Name = "mainMenuMS";
            this.mainMenuMS.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenuMS.Size = new System.Drawing.Size(1031, 24);
            this.mainMenuMS.TabIndex = 0;
            this.mainMenuMS.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "Файл";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(109, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Correction
            // 
            this.Correction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenu,
            this.ChangeMenu,
            this.toolStripSeparator1,
            this.DeliteMenu});
            this.Correction.Name = "Correction";
            this.Correction.Size = new System.Drawing.Size(59, 20);
            this.Correction.Text = "Правка";
            // 
            // AddMenu
            // 
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(128, 22);
            this.AddMenu.Text = "Добавить";
            this.AddMenu.Click += new System.EventHandler(this.AddTool_Click);
            // 
            // ChangeMenu
            // 
            this.ChangeMenu.Enabled = false;
            this.ChangeMenu.Name = "ChangeMenu";
            this.ChangeMenu.Size = new System.Drawing.Size(128, 22);
            this.ChangeMenu.Text = "Изменить";
            this.ChangeMenu.Click += new System.EventHandler(this.ChangeTool_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // DeliteMenu
            // 
            this.DeliteMenu.Enabled = false;
            this.DeliteMenu.Name = "DeliteMenu";
            this.DeliteMenu.Size = new System.Drawing.Size(128, 22);
            this.DeliteMenu.Text = "Удалить";
            this.DeliteMenu.Click += new System.EventHandler(this.DeleteTool_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(94, 20);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // toolsTS
            // 
            this.toolsTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTool,
            this.ChangeTool,
            this.toolStripSeparator2,
            this.DeliteTool});
            this.toolsTS.Location = new System.Drawing.Point(0, 24);
            this.toolsTS.Name = "toolsTS";
            this.toolsTS.Size = new System.Drawing.Size(1031, 25);
            this.toolsTS.TabIndex = 1;
            this.toolsTS.Text = "toolStrip1";
            // 
            // AddTool
            // 
            this.AddTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTool.Name = "AddTool";
            this.AddTool.Size = new System.Drawing.Size(63, 22);
            this.AddTool.Text = "Добавить";
            this.AddTool.Click += new System.EventHandler(this.AddTool_Click);
            // 
            // ChangeTool
            // 
            this.ChangeTool.Enabled = false;
            this.ChangeTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeTool.Name = "ChangeTool";
            this.ChangeTool.Size = new System.Drawing.Size(65, 22);
            this.ChangeTool.Text = "Изменить";
            this.ChangeTool.Click += new System.EventHandler(this.ChangeTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // DeliteTool
            // 
            this.DeliteTool.Enabled = false;
            this.DeliteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeliteTool.Name = "DeliteTool";
            this.DeliteTool.Size = new System.Drawing.Size(55, 22);
            this.DeliteTool.Text = "Удалить";
            this.DeliteTool.Click += new System.EventHandler(this.DeleteTool_Click);
            // 
            // FlightsDGV
            // 
            this.FlightsDGV.AllowUserToAddRows = false;
            this.FlightsDGV.AllowUserToDeleteRows = false;
            this.FlightsDGV.AllowUserToResizeColumns = false;
            this.FlightsDGV.AllowUserToResizeRows = false;
            this.FlightsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numFlightColumn,
            this.typeColumn,
            this.etaColumn,
            this.countPasColumn,
            this.price4PasColumn,
            this.countCrewColumn,
            this.price4CrewColumn,
            this.procDopColumn,
            this.sumColumn});
            this.FlightsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlightsDGV.Location = new System.Drawing.Point(0, 49);
            this.FlightsDGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FlightsDGV.MultiSelect = false;
            this.FlightsDGV.Name = "FlightsDGV";
            this.FlightsDGV.ReadOnly = true;
            dataGridViewCellStyle9.NullValue = "fgn";
            this.FlightsDGV.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.FlightsDGV.Size = new System.Drawing.Size(1031, 483);
            this.FlightsDGV.TabIndex = 2;
            this.FlightsDGV.SelectionChanged += new System.EventHandler(this.FlightsDGV_SelectionChanged);
            // 
            // numFlightColumn
            // 
            this.numFlightColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numFlightColumn.DataPropertyName = "numFlight";
            dataGridViewCellStyle1.Format = "####";
            dataGridViewCellStyle1.NullValue = null;
            this.numFlightColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.numFlightColumn.HeaderText = "Номер рейса";
            this.numFlightColumn.Name = "numFlightColumn";
            this.numFlightColumn.ReadOnly = true;
            // 
            // typeColumn
            // 
            this.typeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeColumn.DataPropertyName = "Type";
            this.typeColumn.HeaderText = "Тип самолёта";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            // 
            // etaColumn
            // 
            this.etaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.etaColumn.DataPropertyName = "ETA";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.etaColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.etaColumn.HeaderText = "Время прибытия";
            this.etaColumn.Name = "etaColumn";
            this.etaColumn.ReadOnly = true;
            // 
            // countPasColumn
            // 
            this.countPasColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countPasColumn.DataPropertyName = "CountPas";
            dataGridViewCellStyle3.Format = "N0";
            this.countPasColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.countPasColumn.HeaderText = "Кол-во пассажиров";
            this.countPasColumn.Name = "countPasColumn";
            this.countPasColumn.ReadOnly = true;
            // 
            // price4PasColumn
            // 
            this.price4PasColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price4PasColumn.DataPropertyName = "PricePas";
            dataGridViewCellStyle4.Format = "C2";
            this.price4PasColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.price4PasColumn.HeaderText = "Сбор на пассажира";
            this.price4PasColumn.Name = "price4PasColumn";
            this.price4PasColumn.ReadOnly = true;
            // 
            // countCrewColumn
            // 
            this.countCrewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countCrewColumn.DataPropertyName = "CountCrew";
            dataGridViewCellStyle5.Format = "N0";
            this.countCrewColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.countCrewColumn.HeaderText = "Кол-во экипажа";
            this.countCrewColumn.Name = "countCrewColumn";
            this.countCrewColumn.ReadOnly = true;
            // 
            // price4CrewColumn
            // 
            this.price4CrewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price4CrewColumn.DataPropertyName = "PriceCrew";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.price4CrewColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.price4CrewColumn.HeaderText = "Сбор на экипаж";
            this.price4CrewColumn.Name = "price4CrewColumn";
            this.price4CrewColumn.ReadOnly = true;
            // 
            // procDopColumn
            // 
            this.procDopColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.procDopColumn.DataPropertyName = "ProcDop";
            dataGridViewCellStyle7.Format = "N2";
            this.procDopColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.procDopColumn.HeaderText = "% надбавки";
            this.procDopColumn.Name = "procDopColumn";
            this.procDopColumn.ReadOnly = true;
            // 
            // sumColumn
            // 
            this.sumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sumColumn.DataPropertyName = "Sum";
            dataGridViewCellStyle8.Format = "C2";
            this.sumColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.sumColumn.HeaderText = "Выручка";
            this.sumColumn.Name = "sumColumn";
            this.sumColumn.ReadOnly = true;
            // 
            // infoSS
            // 
            this.infoSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountFlightsTSSL,
            this.CountPasTSSL,
            this.CountCrewTSSL,
            this.SumTSSL});
            this.infoSS.Location = new System.Drawing.Point(0, 510);
            this.infoSS.Name = "infoSS";
            this.infoSS.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.infoSS.Size = new System.Drawing.Size(1031, 22);
            this.infoSS.TabIndex = 3;
            this.infoSS.Text = "statusStrip1";
            // 
            // CountFlightsTSSL
            // 
            this.CountFlightsTSSL.Name = "CountFlightsTSSL";
            this.CountFlightsTSSL.Size = new System.Drawing.Size(97, 17);
            this.CountFlightsTSSL.Text = "Кол-во рейсов 0";
            // 
            // CountPasTSSL
            // 
            this.CountPasTSSL.Name = "CountPasTSSL";
            this.CountPasTSSL.Size = new System.Drawing.Size(117, 17);
            this.CountPasTSSL.Text = "Всего пассажиров 0";
            // 
            // CountCrewTSSL
            // 
            this.CountCrewTSSL.Name = "CountCrewTSSL";
            this.CountCrewTSSL.Size = new System.Drawing.Size(97, 17);
            this.CountCrewTSSL.Text = "Всего экипажа 0";
            // 
            // SumTSSL
            // 
            this.SumTSSL.Name = "SumTSSL";
            this.SumTSSL.Size = new System.Drawing.Size(105, 17);
            this.SumTSSL.Text = "Общая выручка 0";
            // 
            // AirportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 532);
            this.Controls.Add(this.infoSS);
            this.Controls.Add(this.FlightsDGV);
            this.Controls.Add(this.toolsTS);
            this.Controls.Add(this.mainMenuMS);
            this.MainMenuStrip = this.mainMenuMS;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1047, 571);
            this.Name = "AirportForm";
            this.Text = "Аэропорт";
            this.mainMenuMS.ResumeLayout(false);
            this.mainMenuMS.PerformLayout();
            this.toolsTS.ResumeLayout(false);
            this.toolsTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlightsDGV)).EndInit();
            this.infoSS.ResumeLayout(false);
            this.infoSS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuMS;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Correction;
        private System.Windows.Forms.ToolStripMenuItem AddMenu;
        private System.Windows.Forms.ToolStripMenuItem ChangeMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DeliteMenu;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStrip toolsTS;
        private System.Windows.Forms.ToolStripButton AddTool;
        private System.Windows.Forms.ToolStripButton ChangeTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DeliteTool;
        private System.Windows.Forms.DataGridView FlightsDGV;
        private System.Windows.Forms.StatusStrip infoSS;
        private System.Windows.Forms.ToolStripStatusLabel CountFlightsTSSL;
        private System.Windows.Forms.ToolStripStatusLabel SumTSSL;
        private System.Windows.Forms.ToolStripStatusLabel CountPasTSSL;
        private System.Windows.Forms.ToolStripStatusLabel CountCrewTSSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFlightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price4PasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countCrewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price4CrewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procDopColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumColumn;
    }
}

