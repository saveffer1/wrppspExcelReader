using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Drawing;

namespace TestApp
{
    public partial class Form1 : Form
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sheetCombo = new System.Windows.Forms.ComboBox();
            this.Sheet = new System.Windows.Forms.Label();
            this.firstRowNamesCheckBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Supported files|*.xls;*.xlsx;*.xlsb;*.csv|xls|*.xls|xlsx|*.xlsx|xlsb|*.xlsb|csv|*" +
    ".csv|All|*.*";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(345, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(405, 425);
            this.dataGridView1.TabIndex = 3;
            // 
            // sheetCombo
            // 
            this.sheetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sheetCombo.FormattingEnabled = true;
            this.sheetCombo.Location = new System.Drawing.Point(88, 38);
            this.sheetCombo.Margin = new System.Windows.Forms.Padding(2);
            this.sheetCombo.Name = "sheetCombo";
            this.sheetCombo.Size = new System.Drawing.Size(147, 21);
            this.sheetCombo.TabIndex = 4;
            this.sheetCombo.SelectedIndexChanged += new System.EventHandler(this.SheetComboSelectedIndexChanged);
            // 
            // Sheet
            // 
            this.Sheet.AutoSize = true;
            this.Sheet.ForeColor = System.Drawing.Color.White;
            this.Sheet.Location = new System.Drawing.Point(12, 41);
            this.Sheet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sheet.Name = "Sheet";
            this.Sheet.Size = new System.Drawing.Size(72, 13);
            this.Sheet.TabIndex = 5;
            this.Sheet.Text = "Choose sheet";
            // 
            // firstRowNamesCheckBox
            // 
            this.firstRowNamesCheckBox.AutoSize = true;
            this.firstRowNamesCheckBox.Checked = true;
            this.firstRowNamesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.firstRowNamesCheckBox.ForeColor = System.Drawing.Color.White;
            this.firstRowNamesCheckBox.Location = new System.Drawing.Point(239, 40);
            this.firstRowNamesCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstRowNamesCheckBox.Name = "firstRowNamesCheckBox";
            this.firstRowNamesCheckBox.Size = new System.Drawing.Size(176, 17);
            this.firstRowNamesCheckBox.TabIndex = 6;
            this.firstRowNamesCheckBox.Text = "first row contains column names";
            this.firstRowNamesCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(427, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(427, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.firstRowNamesCheckBox);
            this.Controls.Add(this.Sheet);
            this.Controls.Add(this.sheetCombo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "wrppsp Excel Reader";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox sheetCombo;
        private System.Windows.Forms.Label Sheet;
        private System.Windows.Forms.CheckBox firstRowNamesCheckBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label1;
        private DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        /*
        public static void GetValues(DataSet dataset, string sheetName)
        {
            foreach (DataRow row in dataset.Tables[sheetName].Rows)
            {
                foreach (var value in row.ItemArray)
                {
                    Console.WriteLine("{0}, {1}", value, value.GetType());
                }
            }
        }
        */

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private static IList<string> GetTablenames(DataTableCollection tables)
        {
            var tableList = new List<string>();
            foreach (var table in tables)
            {
                tableList.Add(table.ToString());
            }

            return tableList;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

            try
            {
                using var stream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                var sw = new Stopwatch();
                sw.Start();
                string x = textBox1.Text.Substring(textBox1.Text.Length - 3); ;
                if (x == "csv")
                {
                    using IExcelDataReader reader = ExcelReaderFactory.CreateCsvReader(stream);
                    var openTiming = sw.ElapsedMilliseconds;
                    // reader.IsFirstRowAsColumnNames = firstRowNamesCheckBox.Checked;
                    ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        UseColumnDataType = false,
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = firstRowNamesCheckBox.Checked
                        }
                    });

                    toolStripStatusLabel1.Text = "Elapsed: " + sw.ElapsedMilliseconds.ToString() + " ms (" + openTiming.ToString() + " ms to open)";

                    var tablenames = GetTablenames(ds.Tables);
                    sheetCombo.DataSource = tablenames;

                    if (tablenames.Count > 0)
                        sheetCombo.SelectedIndex = 0;
                }
                else
                {
                    using IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
                    var openTiming = sw.ElapsedMilliseconds;
                    // reader.IsFirstRowAsColumnNames = firstRowNamesCheckBox.Checked;
                    ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        UseColumnDataType = false,
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = firstRowNamesCheckBox.Checked
                        }
                    });

                    toolStripStatusLabel1.Text = "Elapsed: " + sw.ElapsedMilliseconds.ToString() + " ms (" + openTiming.ToString() + " ms to open)";

                    var tablenames = GetTablenames(ds.Tables);
                    sheetCombo.DataSource = tablenames;

                    if (tablenames.Count > 0)
                        sheetCombo.SelectedIndex = 0;
                }

            }
            catch
            {
                try
                {
                    using var stream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                    var sw = new Stopwatch();
                    sw.Start();
                    string x = textBox1.Text.Substring(textBox1.Text.Length - 3); ;
                    //string input = Microsoft.VisualBasic.Interaction.InputBox("Input Password", "Password Protected", "InputPasswordHere", 100, 100);
                    string value = "";
                    if (Form1.InputBox("This file has password protected.", "Please input the password:", ref value) == DialogResult.OK)
                    {
                        using IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream, new ExcelReaderConfiguration() { Password = value });
                        var openTiming = sw.ElapsedMilliseconds;
                        // reader.IsFirstRowAsColumnNames = firstRowNamesCheckBox.Checked;
                        ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            UseColumnDataType = false,
                            ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = firstRowNamesCheckBox.Checked
                            }
                        });

                        toolStripStatusLabel1.Text = "Elapsed: " + sw.ElapsedMilliseconds.ToString() + " ms (" + openTiming.ToString() + " ms to open)";

                        var tablenames = GetTablenames(ds.Tables);
                        sheetCombo.DataSource = tablenames;

                        if (tablenames.Count > 0)
                            sheetCombo.SelectedIndex = 0;
                    }
                    else
                    {
                        //throw new ExcelDataReader.Exceptions.InvalidPasswordException("Invalid password");
                        throw new Exception("Cannot open the specified file: user are canceled");
                    }
                    
                }
                catch (Exception ex)
                {
                    //ex.Message
                    MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button2Click(object sender, EventArgs e)
        {
            
        }

        private void SelectTable()
        {
            var tablename = sheetCombo.SelectedItem.ToString();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds; // dataset
            dataGridView1.DataMember = tablename;

            // GetValues(ds, tablename);
        }

        private void SheetComboSelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTable();
        }
    }
}
