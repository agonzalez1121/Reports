using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=A;Initial Catalog=importarExcelORS;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
      
        }


        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\arnol\source\repos\WindowsFormsApp11\WindowsFormsApp11\Report1.rdlc";
           
            DataSet ds0 = new DataSet();      
                   
            ds0 = GetData();
            if (ds0.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", ds0.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(subReport1);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }                 

            con.Close();
        }
        public void subReport1(object sender, SubreportProcessingEventArgs e)
        {
            DataSet ds = new DataSet();
            ds = GetNumeroHiPos();
            ReportDataSource rds1 = new ReportDataSource("DataSet1", ds.Tables[0]);
            e.DataSources.Add(rds1);           
           
        }


        public List<DataSet> GetDataSets()
        {
            SqlConnection con = new SqlConnection("Data Source=A;Initial Catalog=importarExcelORS;Integrated Security=True");

            string query1 = "select * from [importarExcelORS].[dbo].[HiPos]";
            string query2 = "select Dept, count (HiPo) as NumeroHiPos from importarExcelORS.dbo.HiPos group by Dept order by count (HiPo) desc";

            List<string> querys = new List<string>();
            querys.Add(query1);
            querys.Add(query2);

            SqlCommand command0 = new SqlCommand(querys[0], con);
            SqlCommand command1 = new SqlCommand(querys[1], con);

            List<SqlCommand> sqlCommands = new List<SqlCommand>();  

            sqlCommands.Add(command0);
            sqlCommands.Add(command1);


           

            List<DataSet> dataSets = new List<DataSet>();
            using(con)
            {
                for (int i = 0; i < dataSets.Count; i++)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        sqlCommands[i].Connection = con;
                        da.SelectCommand = sqlCommands[i];
                        DataSet ds= new DataSet();
                        da.Fill(ds);
                        dataSets.Add(ds);
                    }
                }
            }   
           

            return dataSets;
        }


        public DataSet GetData()
        {
            SqlConnection con = new SqlConnection("Data Source=A;Initial Catalog=importarExcelORS;Integrated Security=True");

            string query = "select * from [importarExcelORS].[dbo].[HiPos]";
            SqlCommand command = new SqlCommand(query,con);
            using (con)
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    command.Connection = con;
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
           
        }

        public DataSet GetSP()
        {
            SqlConnection con = new SqlConnection("Data Source=A;Initial Catalog=importarExcelORS;Integrated Security=True");

            DataSet ds = new DataSet();
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("determinación_Total_Empleados_Area", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                cmd.Connection = con;
                da.SelectCommand = cmd;
               
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ds;
            
        }

        public DataSet GetCapacitacionesArea()
        {
            SqlConnection con = new SqlConnection("Data Source=A;Initial Catalog=importarExcelORS;Integrated Security=True");

            string query = "select AREA, count ([ZONER NAME]) as Capacitaciones_por_Area  from dbo.Capacitaciones_2022 group by AREA \r\n\r\norder by count ([ZONER NAME]) desc";
            SqlCommand command = new SqlCommand(query, con);
            using (con)
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    command.Connection = con;
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\arnol\source\repos\WindowsFormsApp11\WindowsFormsApp11\Report2.rdlc";
            DataSet ds = new DataSet();
            ds = GetSP();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\arnol\source\repos\WindowsFormsApp11\WindowsFormsApp11\Report3.rdlc";
            DataSet ds = new DataSet();
            ds = GetCapacitacionesArea();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("CapacitacionesArea", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            con.Close();
        }

        public DataSet GetspLicenciasActivasLd()
        {
            SqlConnection con = new SqlConnection("Data Source=A;Initial Catalog=importarExcelORS;Integrated Security=True");

            DataSet ds = new DataSet();
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("spLicenciasActivasLd", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                cmd.Connection = con;
                da.SelectCommand = cmd;

                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ds;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\arnol\source\repos\WindowsFormsApp11\WindowsFormsApp11\Report4.rdlc";
            DataSet ds = new DataSet();
            ds = GetspLicenciasActivasLd();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
                
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            con.Close();
        }

        public DataSet GetNumeroCapacitacionesJob()
        {
            SqlConnection con = new SqlConnection("Data Source=A;Initial Catalog=importarExcelORS;Integrated Security=True");

            string query = "select JobAZPeople, count ([ZONER NAME]) as Capacitaciones_por_Job  from dbo.Capacitaciones_2022 group by JobAZPeople order by count ([ZONER NAME]) desc";
            SqlCommand command = new SqlCommand(query, con);
            using (con)
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    command.Connection = con;
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        public DataSet GetHorasNumeroCapacitacion()
        {
            SqlConnection con = new SqlConnection("Data Source=A;Initial Catalog=importarExcelORS;Integrated Security=True");

            string query = "select JobAZPeople,sum (CAST (DURATION AS float ) ) as Horas_capacitacion ,count ([ZONER NAME]) as Numero_Capacitaciones  from importarExcelORS.dbo.Capacitaciones_2022 group by JobAZPeople order by sum (CAST (DURATION AS float ) ) desc";
            SqlCommand command = new SqlCommand(query, con);
            using (con)
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    command.Connection = con;
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\arnol\source\repos\WindowsFormsApp11\WindowsFormsApp11\Report5.rdlc";
            DataSet ds = new DataSet();
            ds = GetNumeroCapacitacionesJob();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            reportViewer1.Visible = true;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\arnol\source\repos\WindowsFormsApp11\WindowsFormsApp11\Report6.rdlc";
            DataSet ds = new DataSet();
            ds = GetHorasNumeroCapacitacion();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            con.Close();
        }

        public DataSet GetNumeroHiPos()
        {
            SqlConnection con = new SqlConnection("Data Source=A;Initial Catalog=importarExcelORS;Integrated Security=True");

            string query = "select Dept, count (HiPo) as NumeroHiPos from importarExcelORS.dbo.HiPos group by Dept order by count (HiPo) desc";
            SqlCommand command = new SqlCommand(query, con);
            using (con)
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    command.Connection = con;
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\arnol\source\repos\WindowsFormsApp11\WindowsFormsApp11\Report7.rdlc";
            DataSet ds = new DataSet();
            ds = GetNumeroHiPos();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            con.Close();
        }

        public DataSet GetReembolsos()
        {
            SqlConnection con = new SqlConnection("Data Source=A;Initial Catalog=importarExcelORS;Integrated Security=True");

            string query = "SELECT  [Solicitud revisada],[IGNITION],[Name],[Cost Center],[Status:],[Area Director Approved Date],[Director],[RPM (Exp consistently met)],[Corrective actions],[Has over a year in the company],[HR Approval],[Hr Approval Date],[Amount Approved (pesos)],[Amount Paid (Pesos)],[Amount left],[Education Program],[School],[Title of Course] FROM [importarExcelORS].[dbo].[Reembolsos]";
            SqlCommand command = new SqlCommand(query, con);
            using (con)
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    command.Connection = con;
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        public DataSet GetCapacitacionGrado()
        {
            SqlConnection con = new SqlConnection("Data Source=A;Initial Catalog=importarExcelORS;Integrated Security=True");

            string query = "select Grade, count (Grade) as Numero_de_Capacitaciones from importarExcelORS.dbo.comparativoCapacitaciones group by Grade order by count (Grade) desc";
            SqlCommand command = new SqlCommand(query, con);
            using (con)
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    command.Connection = con;
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        public DataSet GetCapacitacionPosiciones()
        {
            SqlConnection con = new SqlConnection("Data Source=A;Initial Catalog=importarExcelORS;Integrated Security=True");

            string query = "select Job, count (Job) as Numero_de_Capacitaciones from importarExcelORS.dbo.comparativoCapacitaciones group by Job order by count (Job) desc";
            SqlCommand command = new SqlCommand(query, con);
            using (con)
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    command.Connection = con;
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        public DataSet GetCapacitacionDepartamento()
        {
            SqlConnection con = new SqlConnection("Data Source=A;Initial Catalog=importarExcelORS;Integrated Security=True");

            string query = "select Dept, count (Dept) as Numero_de_Capacitaciones from importarExcelORS.dbo.comparativoCapacitaciones group by Dept order by count (Dept) desc";
            SqlCommand command = new SqlCommand(query, con);
            using (con)
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    command.Connection = con;
                    da.SelectCommand = command;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }




        private void buttonReembolsos_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\arnol\source\repos\WindowsFormsApp11\WindowsFormsApp11\Report9.rdlc";
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            ds = GetCapacitacionGrado();
            ds1 = GetCapacitacionDepartamento();
            ds2 = GetCapacitacionesArea();
            if (ds.Tables[0].Rows.Count > 0 && ds1.Tables[0].Rows.Count >0 && ds2.Tables[0].Rows.Count >0)
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
                

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
               
                reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(subReport2);
               // reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(subReport3);

                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            con.Close();
        }


        public void subReport2(object sender, SubreportProcessingEventArgs e)
        {
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            ds = GetCapacitacionPosiciones();
            ReportDataSource rds1 = new ReportDataSource("DataSet1", ds.Tables[0]);
                     
            e.DataSources.Add(rds1);

        }

        public void subReport3(object sender, SubreportProcessingEventArgs e)
        {
            DataSet ds = new DataSet();
            ds = GetCapacitacionDepartamento();
            ReportDataSource rds1 = new ReportDataSource("DataSet1", ds.Tables[0]);
            e.DataSources.Add(rds1);

        }


        private void buttonCapacitacionesAreaGradosPosiciones_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\arnol\source\repos\WindowsFormsApp11\WindowsFormsApp11\Report9.rdlc";

            DataSet ds0 = new DataSet();

            ds0 = GetCapacitacionGrado();
            if (ds0.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", ds0.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(subReport3);               
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }

            con.Close();
        }

        private void buttonCapacitacionPosiciones_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\arnol\source\repos\WindowsFormsApp11\WindowsFormsApp11\Report10.rdlc";

            DataSet ds0 = new DataSet();

            ds0 = GetCapacitacionPosiciones();
            if (ds0.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", ds0.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }

            con.Close();
        }
    }
}
