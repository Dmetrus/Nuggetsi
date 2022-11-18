namespace NUGGET
{
    partial class FlightsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeETA = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numericCountPas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericProcDop = new System.Windows.Forms.NumericUpDown();
            this.numericFlight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericPricePas = new System.Windows.Forms.NumericUpDown();
            this.numericPriceCrew = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericCountCrew = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textSum = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProcDop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPricePas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceCrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountCrew)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 102);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 102);
            this.label1.TabIndex = 1;
            this.label1.Text = "Информация о рейсе";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип самолёта";
            // 
            // comboType
            // 
            this.comboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(285, 158);
            this.comboType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(265, 21);
            this.comboType.TabIndex = 2;
            this.comboType.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboType_DrawItem);
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Время прибытия";
            // 
            // dateTimeETA
            // 
            this.dateTimeETA.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            this.dateTimeETA.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeETA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeETA.Location = new System.Drawing.Point(285, 189);
            this.dateTimeETA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimeETA.Name = "dateTimeETA";
            this.dateTimeETA.Size = new System.Drawing.Size(265, 20);
            this.dateTimeETA.TabIndex = 4;
            this.dateTimeETA.Value = new System.DateTime(2022, 11, 15, 0, 0, 0, 0);
            this.dateTimeETA.ValueChanged += new System.EventHandler(this.dateTimeETA_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Кол-во пассажиров";
            // 
            // numericCountPas
            // 
            this.numericCountPas.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericCountPas.Location = new System.Drawing.Point(285, 222);
            this.numericCountPas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericCountPas.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericCountPas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCountPas.Name = "numericCountPas";
            this.numericCountPas.Size = new System.Drawing.Size(266, 20);
            this.numericCountPas.TabIndex = 6;
            this.numericCountPas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericCountPas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCountPas.ValueChanged += new System.EventHandler(this.numericCountPas_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Сбор на пассажира";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 345);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "% надбавки";
            // 
            // numericProcDop
            // 
            this.numericProcDop.DecimalPlaces = 2;
            this.numericProcDop.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericProcDop.Location = new System.Drawing.Point(285, 352);
            this.numericProcDop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericProcDop.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericProcDop.Name = "numericProcDop";
            this.numericProcDop.Size = new System.Drawing.Size(266, 20);
            this.numericProcDop.TabIndex = 10;
            this.numericProcDop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericProcDop.ValueChanged += new System.EventHandler(this.numericProcDop_ValueChanged);
            // 
            // numericFlight
            // 
            this.numericFlight.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericFlight.Location = new System.Drawing.Point(285, 125);
            this.numericFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericFlight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericFlight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFlight.Name = "numericFlight";
            this.numericFlight.Size = new System.Drawing.Size(266, 20);
            this.numericFlight.TabIndex = 18;
            this.numericFlight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericFlight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFlight.ValueChanged += new System.EventHandler(this.numericFlight_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Номер рейса";
            // 
            // numericPricePas
            // 
            this.numericPricePas.DecimalPlaces = 2;
            this.numericPricePas.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericPricePas.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericPricePas.Location = new System.Drawing.Point(285, 255);
            this.numericPricePas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericPricePas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPricePas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPricePas.Name = "numericPricePas";
            this.numericPricePas.Size = new System.Drawing.Size(266, 20);
            this.numericPricePas.TabIndex = 19;
            this.numericPricePas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPricePas.Value = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericPricePas.ValueChanged += new System.EventHandler(this.numericPricePas_ValueChanged);
            // 
            // numericPriceCrew
            // 
            this.numericPriceCrew.DecimalPlaces = 2;
            this.numericPriceCrew.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericPriceCrew.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericPriceCrew.Location = new System.Drawing.Point(285, 322);
            this.numericPriceCrew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericPriceCrew.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPriceCrew.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPriceCrew.Name = "numericPriceCrew";
            this.numericPriceCrew.Size = new System.Drawing.Size(266, 20);
            this.numericPriceCrew.TabIndex = 23;
            this.numericPriceCrew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPriceCrew.Value = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericPriceCrew.ValueChanged += new System.EventHandler(this.numericPriceCrew_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 312);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Сбор на экипаж";
            // 
            // numericCountCrew
            // 
            this.numericCountCrew.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericCountCrew.Location = new System.Drawing.Point(285, 288);
            this.numericCountCrew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericCountCrew.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericCountCrew.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCountCrew.Name = "numericCountCrew";
            this.numericCountCrew.Size = new System.Drawing.Size(266, 20);
            this.numericCountCrew.TabIndex = 21;
            this.numericCountCrew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericCountCrew.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCountCrew.ValueChanged += new System.EventHandler(this.numericCountCrew_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(10, 278);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "Кол-во экипажа";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(10, 378);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 29);
            this.label10.TabIndex = 24;
            this.label10.Text = "Выручка";
            // 
            // textSum
            // 
            this.textSum.BackColor = System.Drawing.SystemColors.Menu;
            this.textSum.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSum.Location = new System.Drawing.Point(285, 382);
            this.textSum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textSum.Name = "textSum";
            this.textSum.ReadOnly = true;
            this.textSum.Size = new System.Drawing.Size(265, 20);
            this.textSum.TabIndex = 25;
            this.textSum.Text = "7200";
            this.textSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textSum.TextChanged += new System.EventHandler(this.textSum_TextChanged);
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.SystemColors.Info;
            this.butSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butSave.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butSave.Location = new System.Drawing.Point(7, 459);
            this.butSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(154, 59);
            this.butSave.TabIndex = 0;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = false;
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butCancel.Location = new System.Drawing.Point(397, 459);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(154, 59);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = false;
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 532);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.textSum);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericPriceCrew);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericCountCrew);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericPricePas);
            this.Controls.Add(this.numericFlight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericProcDop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericCountPas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeETA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(581, 571);
            this.MinimumSize = new System.Drawing.Size(581, 571);
            this.Name = "FlightsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавления рейса";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericCountPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProcDop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPricePas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPriceCrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountCrew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.DateTimePicker dateTimeETA;
        private System.Windows.Forms.NumericUpDown numericCountPas;
        private System.Windows.Forms.NumericUpDown numericProcDop;
        private System.Windows.Forms.NumericUpDown numericFlight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericPricePas;
        private System.Windows.Forms.NumericUpDown numericPriceCrew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericCountCrew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butCancel;
    }
}