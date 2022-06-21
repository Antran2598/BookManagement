
namespace PresentationLayer
{
    partial class FormPrint
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsSale = new PresentationLayer.DsSale();
            this.Vw_detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Vw_detailTableAdapter = new PresentationLayer.DsSaleTableAdapters.Vw_detailTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DsSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_detailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Vw_detailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentationLayer.saleReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 54);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1172, 609);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsSale
            // 
            this.DsSale.DataSetName = "DsSale";
            this.DsSale.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Vw_detailBindingSource
            // 
            this.Vw_detailBindingSource.DataMember = "Vw_detail";
            this.Vw_detailBindingSource.DataSource = this.DsSale;
            // 
            // Vw_detailTableAdapter
            // 
            this.Vw_detailTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(986, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(764, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 695);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormPrint";
            this.Text = "FormPrint";
            this.Load += new System.EventHandler(this.FormPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_detailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Vw_detailBindingSource;
        private DsSale DsSale;
        private DsSaleTableAdapters.Vw_detailTableAdapter Vw_detailTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}