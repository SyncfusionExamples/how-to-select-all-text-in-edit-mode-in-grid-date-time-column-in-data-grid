using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.Input;
using Syncfusion.WinForms.DataGrid.Renderers;
using Syncfusion.WinForms.GridCommon.ScrollAxis;

namespace DemoSFDataGridIssue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupDataGrid();
            var testRecords = GenerateTestData();
            sfDataGridSample.DataSource = testRecords;

            this.sfDataGridSample.CellRenderers.Remove("DateTime");
            this.sfDataGridSample.CellRenderers.Add("DateTime", new CustomDateTimeEdit(this.sfDataGridSample));
        }

        private void SetupDataGrid()
        {
            // For demonstration purposes, set the non-default values for the SFDataGrid
            sfDataGridSample.AddNewRowPosition = RowPosition.Bottom;
            sfDataGridSample.AllowDeleting = true;
            sfDataGridSample.AllowDraggingColumns = true;
            sfDataGridSample.AllowGrouping = false;
            sfDataGridSample.AllowResizingColumns = true;
            sfDataGridSample.AllowSelectionOnMouseDown = true;
            sfDataGridSample.AutoGenerateColumns = false;
            sfDataGridSample.EditMode = EditMode.SingleClick;
            sfDataGridSample.EditorSelectionBehavior = EditorSelectionBehavior.SelectAll;
            sfDataGridSample.SelectionUnit = SelectionUnit.Cell;
            sfDataGridSample.ShowRowHeader = true;
            sfDataGridSample.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            sfDataGridSample.ValidationMode = GridValidationMode.InEdit;

            // Setup our event handler
            sfDataGridSample.SelectionChanged += sfDataGridUpdate_SelectionChanged;

            // For demonstration purposes, set the non-default values for the columns
            GridDateTimeColumn col1 = (GridDateTimeColumn)sfDataGridSample.Columns["DateValue"];
            col1.CellStyle.HorizontalAlignment = HorizontalAlignment.Center;
            col1.Pattern = DateTimePattern.ShortDate;
            col1.ShowDropDownButton = false;
            col1.AllowDragging = true;
            col1.ValidationMode = GridValidationMode.InView;
            col1.DateTimeEditingMode = DateTimeEditingMode.Default;
            col1.AllowGrouping = false;
            col1.AllowResizing = true;

            GridDateTimeColumn col2 = (GridDateTimeColumn)sfDataGridSample.Columns["TimeValue"];
            col2.CellStyle.HorizontalAlignment = HorizontalAlignment.Center;
            col2.Pattern = DateTimePattern.ShortTime;
            col2.ShowDropDownButton = false;
            col2.AllowDragging = true;
            col2.ValidationMode = GridValidationMode.InView;
            col2.DateTimeEditingMode = DateTimeEditingMode.Default;
            col2.AllowGrouping = false;
            col2.AllowResizing = true;

            GridTextColumn col3 = (GridTextColumn)sfDataGridSample.Columns["StringValue"];
            col3.CellStyle.HorizontalAlignment = HorizontalAlignment.Left;
            col3.AllowDragging = true;
            col3.ValidationMode = GridValidationMode.InEdit;
            col3.AllowGrouping = false;
            col3.AllowResizing = true;
        }

        private List<DemoRecord> GenerateTestData()
        {
            var testRecords = new List<DemoRecord>();
            DateTime startDate = DateTime.Now;

            testRecords.Add(new DemoRecord(startDate.AddDays(0), startDate, "Maria Anders"));
            testRecords.Add(new DemoRecord(startDate.AddDays(1), startDate, "Ana Trujilo"));
            testRecords.Add(new DemoRecord(startDate.AddDays(2), startDate, "Antonio Moreno"));
            testRecords.Add(new DemoRecord(startDate.AddDays(3), startDate, "Thomas Hardy"));
            testRecords.Add(new DemoRecord(startDate.AddDays(4), startDate, "Christina Berglund"));
            testRecords.Add(new DemoRecord(startDate.AddDays(5), startDate, "Hanna Moos"));
            testRecords.Add(new DemoRecord(startDate.AddDays(6), startDate, "Frederique Citeaux"));
            testRecords.Add(new DemoRecord(startDate.AddDays(7), startDate, "Martin Sommer"));
            testRecords.Add(new DemoRecord(startDate.AddDays(8), startDate, "Laurence Lebihan"));
            testRecords.Add(new DemoRecord(startDate.AddDays(9), startDate, "Elizabeth Lincoln"));

            return testRecords;
        }

        private void sfDataGridUpdate_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            if (sfDataGridSample.CurrentCell != null)
            {
                sfDataGridSample.CurrentCell.BeginEdit();
                if (sfDataGridSample.CurrentCell.CellRenderer != null)
                    if (sfDataGridSample.CurrentCell.CellRenderer.CurrentCellRendererElement != null)
                        sfDataGridSample.CurrentCell.CellRenderer.CurrentCellRendererElement.Select();
            }
        }
    }

    public class CustomDateTimeEdit : GridDateTimeCellRenderer
    {
        public CustomDateTimeEdit(SfDataGrid dataGrid)
        {
            DataGrid = dataGrid;
        }

        /// <summary>
        /// Gets or sets to specify the datagrid.
        /// </summary>
        protected SfDataGrid DataGrid { get; set; }

        protected override void OnInitializeEditElement(DataColumnBase column, RowColumnIndex rowColumnIndex, SfDateTimeEdit uiElement)
        {
            base.OnInitializeEditElement(column, rowColumnIndex, uiElement);

            if (DataGrid.CurrentCell != null)
            {
                if (DataGrid.CurrentCell.CellRenderer != null)
                {
                    var editingTextBox = (uiElement as SfDateTimeEdit).GetType().GetProperty("EditingTextBox", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    (editingTextBox.GetValue(uiElement) as RichTextBox).Focus();
                    (editingTextBox.GetValue(uiElement) as RichTextBox).SelectAll();
                }
            }
        }
    }

    public class DemoRecord
    {
        public DateTime DateValue { get; set; }
        public DateTime TimeValue { get; set; }
        public string StringValue { get; set; }

        public DemoRecord(DateTime dateValue, DateTime timeValue, string stringValue)
        {
            DateValue = dateValue;
            TimeValue = timeValue;
            StringValue = stringValue;
        }
    }
}
