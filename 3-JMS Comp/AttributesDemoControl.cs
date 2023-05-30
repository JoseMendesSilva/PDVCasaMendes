using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace CasaMendes
{
    // This is the event handler delegate for the ThresholdExceeded event.
    public delegate void ThresholdExceededEventHandler(ThresholdExceededEventArgs e);
    // This control demonstrates a simple logging capability.
    [ComplexBindingProperties("DataSource", "DataMember")]
    [DefaultBindingProperty("TitleText")]
    [DefaultEvent("ThresholdExceeded")]
    [DefaultProperty("Threshold")]
    [HelpKeywordAttribute(typeof(UserControl))]
    [ToolboxItem("System.Windows.Forms.Design.AutoSizeToolboxItem,System.Design")]
    public partial class AttributesDemoControl : UserControl
    {
        // This backs the Threshold property.
        private object thresholdValue;
        // The default fore color value for DataGridView cells that
        // contain values that exceed the threshold.
        private static Color defaultAlertForeColorValue = Color.White;
        // The default back color value for DataGridView cells that
        // contain values that exceed the threshold.
        private static Color defaultAlertBackColorValue = Color.Red;
        // The ambient color value.
        private static Color ambientColorValue = Color.Empty;
        // The fore color value for DataGridView cells that
        // contain values that exceed the threshold.
        private Color alertForeColorValue = defaultAlertForeColorValue;
        // The back color value for DataGridView cells that
        // contain values that exceed the threshold.
        private Color alertBackColorValue = defaultAlertBackColorValue;
        // Child controls that comprise this UserControl.
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Label label1;
        // Required for designer support.
        private System.ComponentModel.IContainer components = null;
        // Default constructor.
        public AttributesDemoControl()
        {
            InitializeComponent();
        }

        [Category("Appearance")]
        [Description("The title of the log data.")]

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Localizable(true)]

        [HelpKeywordAttribute("AttributesDemoControlLibrary.AttributesDemoControl.Ti tleText")]
        public string TitleText
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }
        // The inherited Text property is hidden at design time and
        // raises an exception at run time. This enforces a requirement
        // that client code uses the TitleText property instead.
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text
        {
            get
            {
                throw new NotSupportedException();
            }
            set
            {
                throw new NotSupportedException();
            }
        }
        [AmbientValue(typeof(Color), "Empty")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "White")]
        [Description("The color used for painting alert text.")]
        public Color AlertForeColor
        {
            get
            {
                if (this.alertForeColorValue == Color.Empty &&
                this.Parent != null)
                {
                    return Parent.ForeColor;
                }
                return this.alertForeColorValue;
            }
            set
            {
                this.alertForeColorValue = value;
            }
        }
        // This method is used by designers to enable resetting the
        // property to its default value.
        public void ResetAlertForeColor()
        {
            this.AlertForeColor =
           AttributesDemoControl.defaultAlertForeColorValue;
        }
        // This method indicates to designers whether the property
        // value is different from the ambient value, in which case
        // the designer should persist the value.
        private bool ShouldSerializeAlertForeColor()
        {
            return (this.alertForeColorValue !=
           AttributesDemoControl.ambientColorValue);
        }
        [AmbientValue(typeof(Color), "Empty")]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "Red")]
        [Description("The background color for painting alert text.")]
        public Color AlertBackColor
        {
            get
            {
                if (this.alertBackColorValue == Color.Empty &&
                this.Parent != null)
                {
                    return Parent.BackColor;
                }
                return this.alertBackColorValue;
            }
            set
            {
                this.alertBackColorValue = value;
            }
        }
        // This method is used by designers to enable resetting the
        // property to its default value.
        public void ResetAlertBackColor()
        {
            this.AlertBackColor =
           AttributesDemoControl.defaultAlertBackColorValue;
        }
        // This method indicates to designers whether the property
        // value is different from the ambient value, in which case
        // the designer should persist the value.
        private bool ShouldSerializeAlertBackColor()
        {
            return (this.alertBackColorValue !=
           AttributesDemoControl.ambientColorValue);
        }
        [Category("Data")]
        [Description("Indicates the source of data for the control.")]
        [RefreshProperties(RefreshProperties.Repaint)]
        [AttributeProvider(typeof(IListSource))]
        public object DataSource
        {
            get
            {
                return this.dataGridView1.DataSource;
            }
            set
            {
                this.dataGridView1.DataSource = value;
            }
        }
        [Category("Data")]
        [Description("Indicates a sub-list of the data source to show in the control.")]
        public string DataMember
        {
            get
            {
                return this.dataGridView1.DataMember;
            }
            set
            {
                this.dataGridView1.DataMember = value;
            }
        }
        // This property would normally have its BrowsableAttribute
        // set to false, but this code demonstrates using
        // ReadOnlyAttribute, so BrowsableAttribute is true to show
        // it in any attached PropertyGrid control.
        [Browsable(true)]
        [Category("Behavior")]
        [Description("The timestamp of the latest entry.")]
        [ReadOnly(true)]
        public DateTime CurrentLogTime
        {
            get
            {
                int lastRowIndex =
                this.dataGridView1.Rows.GetLastRow(
                DataGridViewElementStates.Visible);
                if (lastRowIndex > -1)
                {
                    DataGridViewRow lastRow =
                   this.dataGridView1.Rows[lastRowIndex];
                    DataGridViewCell lastCell = lastRow.Cells["EntryTime"];
                    return ((DateTime)lastCell.Value);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
            }
        }
        [Category("Behavior")]
        [Description("The value above which the ThresholdExceeded event will be raised.")]
        public object Threshold
        {
            get
            {
                return this.thresholdValue;
            }
            set
            {
                this.thresholdValue = value;
            }
        }
        // This property exists only to demonstrate the
        // PasswordPropertyText attribute. When this control
        // is attached to a PropertyGrid control, the returned
        // string will be displayed with obscuring characters
        // such as asterisks. This property has no other effect.
        [Category("Security")]
        [Description("Demonstrates PasswordPropertyTextAttribute.")]
        [PasswordPropertyText(true)]
        public string Password
        {
            get
            {
                return "This is a demo password.";
            }
        }
        // This property exists only to demonstrate the
        // DisplayName attribute. When this control
        // is attached to a PropertyGrid control, the
        // property will be appear as "RenamedProperty"
        // instead of "MisnamedProperty".
        [Description("Demonstrates DisplayNameAttribute.")]
        [DisplayName("RenamedProperty")]
        public bool MisnamedProperty
        {
            get
            {
                return true;
            }
        }
        // This is the declaration for the ThresholdExceeded event.
        public event ThresholdExceededEventHandler ThresholdExceeded;

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.Value != null)
                {
                    if (e.Value is DateTime)
                    {
                        // Display the log entry time with the
                        // full date/time pattern (long time).
                        e.CellStyle.Format = "F";
                    }
                    else
                    {
                        // Scroll to the most recent entry.
                        DataGridViewRow row =
                       this.dataGridView1.Rows[e.RowIndex];
                        DataGridViewCell cell = row.Cells[e.ColumnIndex];
                        this.dataGridView1.FirstDisplayedCell = cell;
                        if (this.thresholdValue != null)
                        {
                            // Get the type of the log entry.
                            object val = e.Value;
                            Type paramType = val.GetType();
                            // Compare the log entry value to the threshold value.
                            // Use reflection to call the CompareTo method on the
                            // template parameter's type.
                            int compareVal = (int)paramType.InvokeMember("CompareTo", BindingFlags.Default | BindingFlags.InvokeMethod, null, e.Value, new object[] { this.thresholdValue }, System.Globalization.CultureInfo.InvariantCulture);
                            // If the log entry value exceeds the threshold value,
                            // set the cell's fore color and back color properties

                            // and raise the ThresholdExceeded event.
                            if (compareVal > 0)
                            {
                                e.CellStyle.BackColor =
                               this.alertBackColorValue;
                                e.CellStyle.ForeColor =
                               this.alertForeColorValue;
                                ThresholdExceededEventArgs teea =
                                new ThresholdExceededEventArgs(
                               this.thresholdValue,
                                e.Value);
                                this.ThresholdExceeded(teea);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

        }
    }
    // This is the EventArgs class for the ThresholdExceeded event.
    public class ThresholdExceededEventArgs : EventArgs
    {
        private object thresholdValue = null;
        private object exceedingValue = null;
        public ThresholdExceededEventArgs(
        object thresholdValue,
        object exceedingValue)
        {
            this.thresholdValue = thresholdValue;
            this.exceedingValue = exceedingValue;
        }
        public object ThresholdValue
        {
            get
            {
                return this.thresholdValue;
            }
        }
        public object ExceedingValue
        {
            get
            {
                return this.exceedingValue;
            }
        }
    }
}

// This class encapsulates a log entry. It is a parameterized
// type (also known as a template class). The parameter type T
// defines the type of data being logged. For threshold detection
// to work, this type must implement the IComparable interface.
[TypeConverter("LogEntryTypeConverter")]
public class LogEntry<T> where T : IComparable
{
    private T entryValue;
    private DateTime entryTimeValue;
    public LogEntry(
    T value,
    DateTime time)
    {
        this.entryValue = value;
        this.entryTimeValue = time;
    }
    public T Entry
    {
        get
        {
            return this.entryValue;
        }
    }
    public DateTime EntryTime
    {
        get
        {
            return this.entryTimeValue;
        }
    }
    // This is the TypeConverter for the LogEntry class.
    public class LogEntryTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(
        ITypeDescriptorContext context,
        Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }
        public override object ConvertFrom(
        ITypeDescriptorContext context,
        System.Globalization.CultureInfo culture,
        object value)
        {
            if (value is string)
            {
                string[] v = ((string)value).Split(new char[] { '|' });
                Type paramType = typeof(T);
                T entryValue = (T)paramType.InvokeMember(
                "Parse",
                BindingFlags.Static | BindingFlags.Public |
               BindingFlags.InvokeMethod,
                null,
               null,
               new string[] { v[0] },
                culture);
                return new LogEntry<T>(
                entryValue,
                DateTime.Parse(v[2]));
            }
            return base.ConvertFrom(context, culture, value);
        }
        public override object ConvertTo(
        ITypeDescriptorContext context,
        System.Globalization.CultureInfo culture,
        object value,
        Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                LogEntry<T> le = value as LogEntry<T>;
                string stringRepresentation =
                String.Format("{0} | {1}",
                le.Entry,
                le.EntryTime);
                return stringRepresentation;
            }
            return base.ConvertTo(context, culture, value,
           destinationType);
        }
    }
}

