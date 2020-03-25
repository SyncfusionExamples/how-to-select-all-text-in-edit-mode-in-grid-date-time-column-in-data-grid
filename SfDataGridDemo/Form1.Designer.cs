namespace DemoSFDataGridIssue
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
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn2 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.sfDataGridSample = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridSample)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGridSample
            // 
            this.sfDataGridSample.AccessibleName = "Table";
            this.sfDataGridSample.AddNewRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Bottom;
            this.sfDataGridSample.AllowDeleting = true;
            this.sfDataGridSample.AllowDraggingColumns = true;
            this.sfDataGridSample.AllowGrouping = false;
            this.sfDataGridSample.AllowResizingColumns = true;
            this.sfDataGridSample.AllowSelectionOnMouseDown = true;
            this.sfDataGridSample.AutoGenerateColumns = false;
            gridDateTimeColumn1.AllowDragging = true;
            gridDateTimeColumn1.AllowGrouping = false;
            gridDateTimeColumn1.AllowResizing = true;
            gridDateTimeColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridDateTimeColumn1.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Default;
            gridDateTimeColumn1.HeaderText = "Date Value";
            gridDateTimeColumn1.MappingName = "DateValue";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.ShowDropDownButton = false;
            gridDateTimeColumn1.ValidationMode = Syncfusion.WinForms.DataGrid.Enums.GridValidationMode.InView;
            gridDateTimeColumn1.Width = 137D;
            gridDateTimeColumn2.AllowDragging = true;
            gridDateTimeColumn2.AllowGrouping = false;
            gridDateTimeColumn2.AllowResizing = true;
            gridDateTimeColumn2.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridDateTimeColumn2.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Default;
            gridDateTimeColumn2.HeaderText = "Time Value";
            gridDateTimeColumn2.MappingName = "TimeValue";
            gridDateTimeColumn2.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn2.Pattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            gridDateTimeColumn2.ShowDropDownButton = false;
            gridDateTimeColumn2.ValidationMode = Syncfusion.WinForms.DataGrid.Enums.GridValidationMode.InView;
            gridDateTimeColumn2.Width = 137D;
            gridTextColumn1.AllowDragging = true;
            gridTextColumn1.AllowGrouping = false;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderText = "String Value";
            gridTextColumn1.MappingName = "StringValue";
            gridTextColumn1.ValidationMode = Syncfusion.WinForms.DataGrid.Enums.GridValidationMode.InEdit;
            this.sfDataGridSample.Columns.Add(gridDateTimeColumn1);
            this.sfDataGridSample.Columns.Add(gridDateTimeColumn2);
            this.sfDataGridSample.Columns.Add(gridTextColumn1);
            this.sfDataGridSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridSample.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick;
            this.sfDataGridSample.EditorSelectionBehavior = Syncfusion.WinForms.DataGrid.Enums.EditorSelectionBehavior.SelectAll;
            this.sfDataGridSample.Location = new System.Drawing.Point(0, 0);
            this.sfDataGridSample.Name = "sfDataGridSample";
            this.sfDataGridSample.SelectionUnit = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Cell;
            this.sfDataGridSample.ShowRowHeader = true;
            this.sfDataGridSample.Size = new System.Drawing.Size(428, 380);
            this.sfDataGridSample.TabIndex = 0;
            this.sfDataGridSample.Text = "sfDataGrid1";
            this.sfDataGridSample.ValidationMode = Syncfusion.WinForms.DataGrid.Enums.GridValidationMode.InEdit;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 380);
            this.Controls.Add(this.sfDataGridSample);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridSample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridSample;
    }
}

