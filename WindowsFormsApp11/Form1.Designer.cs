namespace WindowsFormsApp11
{
    partial class Form1
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.buttonEvaluacionPotencial = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonTotalEmpleados = new System.Windows.Forms.Button();
            this.buttonCapacitaciones = new System.Windows.Forms.Button();
            this.buttonEmpleadosLinkedin = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonHorasCapacitacion = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCapacitacionesAreaGrados = new System.Windows.Forms.Button();
            this.buttonReembolsos = new System.Windows.Forms.Button();
            this.buttonCapacitacionPosiciones = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGenerarReporte = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEvaluacionPotencial
            // 
            this.buttonEvaluacionPotencial.BackColor = System.Drawing.Color.White;
            this.buttonEvaluacionPotencial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEvaluacionPotencial.Location = new System.Drawing.Point(3, 3);
            this.buttonEvaluacionPotencial.Name = "buttonEvaluacionPotencial";
            this.buttonEvaluacionPotencial.Size = new System.Drawing.Size(131, 26);
            this.buttonEvaluacionPotencial.TabIndex = 2;
            this.buttonEvaluacionPotencial.Text = "Evaluacion de potencial";
            this.buttonEvaluacionPotencial.UseVisualStyleBackColor = false;
            this.buttonEvaluacionPotencial.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp11.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(263, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(701, 497);
            this.reportViewer1.TabIndex = 3;
            // 
            // buttonTotalEmpleados
            // 
            this.buttonTotalEmpleados.Location = new System.Drawing.Point(156, 3);
            this.buttonTotalEmpleados.Name = "buttonTotalEmpleados";
            this.buttonTotalEmpleados.Size = new System.Drawing.Size(131, 26);
            this.buttonTotalEmpleados.TabIndex = 4;
            this.buttonTotalEmpleados.Text = "Total de empleados";
            this.buttonTotalEmpleados.UseVisualStyleBackColor = true;
            this.buttonTotalEmpleados.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCapacitaciones
            // 
            this.buttonCapacitaciones.Location = new System.Drawing.Point(318, 3);
            this.buttonCapacitaciones.Name = "buttonCapacitaciones";
            this.buttonCapacitaciones.Size = new System.Drawing.Size(124, 26);
            this.buttonCapacitaciones.TabIndex = 5;
            this.buttonCapacitaciones.Text = "Capacitaciones";
            this.buttonCapacitaciones.UseVisualStyleBackColor = true;
            this.buttonCapacitaciones.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonEmpleadosLinkedin
            // 
            this.buttonEmpleadosLinkedin.Location = new System.Drawing.Point(454, 3);
            this.buttonEmpleadosLinkedin.Name = "buttonEmpleadosLinkedin";
            this.buttonEmpleadosLinkedin.Size = new System.Drawing.Size(154, 26);
            this.buttonEmpleadosLinkedin.TabIndex = 6;
            this.buttonEmpleadosLinkedin.Text = "Empleados con Linkedin";
            this.buttonEmpleadosLinkedin.UseVisualStyleBackColor = true;
            this.buttonEmpleadosLinkedin.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(619, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 26);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonHorasCapacitacion
            // 
            this.buttonHorasCapacitacion.Location = new System.Drawing.Point(751, 3);
            this.buttonHorasCapacitacion.Name = "buttonHorasCapacitacion";
            this.buttonHorasCapacitacion.Size = new System.Drawing.Size(123, 26);
            this.buttonHorasCapacitacion.TabIndex = 8;
            this.buttonHorasCapacitacion.Text = "Horas de capacitacion";
            this.buttonHorasCapacitacion.UseVisualStyleBackColor = true;
            this.buttonHorasCapacitacion.Click += new System.EventHandler(this.button6_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.88728F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.11272F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(131, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(967, 503);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.buttonCapacitacionesAreaGrados, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.buttonReembolsos, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonCapacitacionPosiciones, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.73684F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.26316F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(254, 429);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 360);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(248, 66);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.buttonGenerarReporte, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(119, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(126, 60);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 33);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.dateTimePicker2, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.dateTimePicker1, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(110, 60);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // buttonCapacitacionesAreaGrados
            // 
            this.buttonCapacitacionesAreaGrados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCapacitacionesAreaGrados.Location = new System.Drawing.Point(48, 302);
            this.buttonCapacitacionesAreaGrados.Name = "buttonCapacitacionesAreaGrados";
            this.buttonCapacitacionesAreaGrados.Size = new System.Drawing.Size(158, 42);
            this.buttonCapacitacionesAreaGrados.TabIndex = 0;
            this.buttonCapacitacionesAreaGrados.Text = "Capacitaciones por Area y Grados";
            this.buttonCapacitacionesAreaGrados.UseVisualStyleBackColor = true;
            this.buttonCapacitacionesAreaGrados.Click += new System.EventHandler(this.buttonCapacitacionesAreaGradosPosiciones_Click);
            // 
            // buttonReembolsos
            // 
            this.buttonReembolsos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReembolsos.Location = new System.Drawing.Point(62, 173);
            this.buttonReembolsos.Name = "buttonReembolsos";
            this.buttonReembolsos.Size = new System.Drawing.Size(130, 52);
            this.buttonReembolsos.TabIndex = 2;
            this.buttonReembolsos.Text = "Reembolsos";
            this.buttonReembolsos.UseVisualStyleBackColor = true;
            this.buttonReembolsos.Click += new System.EventHandler(this.buttonReembolsos_Click);
            // 
            // buttonCapacitacionPosiciones
            // 
            this.buttonCapacitacionPosiciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCapacitacionPosiciones.Location = new System.Drawing.Point(58, 235);
            this.buttonCapacitacionPosiciones.Name = "buttonCapacitacionPosiciones";
            this.buttonCapacitacionPosiciones.Size = new System.Drawing.Size(137, 48);
            this.buttonCapacitacionPosiciones.TabIndex = 3;
            this.buttonCapacitacionPosiciones.Text = "Capacitacion por posiciones";
            this.buttonCapacitacionPosiciones.UseVisualStyleBackColor = true;
            this.buttonCapacitacionPosiciones.Click += new System.EventHandler(this.buttonCapacitacionPosiciones_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(880, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 26);
            this.button7.TabIndex = 9;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.Controls.Add(this.button7, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonHorasCapacitacion, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonTotalEmpleados, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonCapacitaciones, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEmpleadosLinkedin, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEvaluacionPotencial, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(121, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1016, 32);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // buttonGenerarReporte
            // 
            this.buttonGenerarReporte.Location = new System.Drawing.Point(3, 3);
            this.buttonGenerarReporte.Name = "buttonGenerarReporte";
            this.buttonGenerarReporte.Size = new System.Drawing.Size(120, 23);
            this.buttonGenerarReporte.TabIndex = 0;
            this.buttonGenerarReporte.Text = "Generar reporte";
            this.buttonGenerarReporte.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1164, 561);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1180, 600);
            this.MinimumSize = new System.Drawing.Size(1080, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button buttonEvaluacionPotencial;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button buttonTotalEmpleados;
        private System.Windows.Forms.Button buttonCapacitaciones;
        private System.Windows.Forms.Button buttonEmpleadosLinkedin;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonHorasCapacitacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonCapacitacionesAreaGrados;
        private System.Windows.Forms.Button buttonReembolsos;
        private System.Windows.Forms.Button buttonCapacitacionPosiciones;
        private System.Windows.Forms.Button buttonGenerarReporte;
    }
}

