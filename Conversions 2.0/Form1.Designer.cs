
namespace Conversions_2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._fromUnit = new System.Windows.Forms.ListBox();
            this._toUnit = new System.Windows.Forms.ListBox();
            this._buttConvert = new System.Windows.Forms.Button();
            this._textFromUnit = new System.Windows.Forms.TextBox();
            this._textToUnit = new System.Windows.Forms.TextBox();
            this._listWeightFrom = new System.Windows.Forms.ListBox();
            this._textWeightFrom = new System.Windows.Forms.TextBox();
            this._listWeightTo = new System.Windows.Forms.ListBox();
            this._textWeightTo = new System.Windows.Forms.TextBox();
            this._buttWeightConvert = new System.Windows.Forms.Button();
            this._Tabs = new System.Windows.Forms.TabControl();
            this._tabDistance = new System.Windows.Forms.TabPage();
            this._tabWeight = new System.Windows.Forms.TabPage();
            this._tabTime = new System.Windows.Forms.TabPage();
            this._buttTimeConvert = new System.Windows.Forms.Button();
            this._textTimeFrom = new System.Windows.Forms.TextBox();
            this._textTimeTo = new System.Windows.Forms.TextBox();
            this._listTimeTo = new System.Windows.Forms.ListBox();
            this._listTimeFrom = new System.Windows.Forms.ListBox();
            this._Tabs.SuspendLayout();
            this._tabDistance.SuspendLayout();
            this._tabWeight.SuspendLayout();
            this._tabTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // _fromUnit
            // 
            this._fromUnit.FormattingEnabled = true;
            this._fromUnit.ItemHeight = 15;
            this._fromUnit.Location = new System.Drawing.Point(3, 32);
            this._fromUnit.Name = "_fromUnit";
            this._fromUnit.Size = new System.Drawing.Size(119, 124);
            this._fromUnit.TabIndex = 0;
            // 
            // _toUnit
            // 
            this._toUnit.FormattingEnabled = true;
            this._toUnit.ItemHeight = 15;
            this._toUnit.Location = new System.Drawing.Point(254, 32);
            this._toUnit.Name = "_toUnit";
            this._toUnit.Size = new System.Drawing.Size(119, 124);
            this._toUnit.TabIndex = 1;
            // 
            // _buttConvert
            // 
            this._buttConvert.Location = new System.Drawing.Point(148, 133);
            this._buttConvert.Name = "_buttConvert";
            this._buttConvert.Size = new System.Drawing.Size(75, 23);
            this._buttConvert.TabIndex = 2;
            this._buttConvert.Text = "Convert";
            this._buttConvert.UseVisualStyleBackColor = true;
            this._buttConvert.Click += new System.EventHandler(this._buttConvert_Click);
            // 
            // _textFromUnit
            // 
            this._textFromUnit.Location = new System.Drawing.Point(3, 3);
            this._textFromUnit.MaxLength = 15;
            this._textFromUnit.Name = "_textFromUnit";
            this._textFromUnit.Size = new System.Drawing.Size(119, 23);
            this._textFromUnit.TabIndex = 3;
            this._textFromUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._keyPress);
            // 
            // _textToUnit
            // 
            this._textToUnit.Location = new System.Drawing.Point(254, 3);
            this._textToUnit.Name = "_textToUnit";
            this._textToUnit.ReadOnly = true;
            this._textToUnit.Size = new System.Drawing.Size(119, 23);
            this._textToUnit.TabIndex = 4;
            // 
            // _listWeightFrom
            // 
            this._listWeightFrom.FormattingEnabled = true;
            this._listWeightFrom.ItemHeight = 15;
            this._listWeightFrom.Location = new System.Drawing.Point(3, 32);
            this._listWeightFrom.Name = "_listWeightFrom";
            this._listWeightFrom.Size = new System.Drawing.Size(119, 124);
            this._listWeightFrom.TabIndex = 5;
            // 
            // _textWeightFrom
            // 
            this._textWeightFrom.Location = new System.Drawing.Point(3, 3);
            this._textWeightFrom.MaxLength = 15;
            this._textWeightFrom.Name = "_textWeightFrom";
            this._textWeightFrom.Size = new System.Drawing.Size(119, 23);
            this._textWeightFrom.TabIndex = 6;
            this._textWeightFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._keyPress);
            // 
            // _listWeightTo
            // 
            this._listWeightTo.FormattingEnabled = true;
            this._listWeightTo.ItemHeight = 15;
            this._listWeightTo.Location = new System.Drawing.Point(254, 32);
            this._listWeightTo.Name = "_listWeightTo";
            this._listWeightTo.Size = new System.Drawing.Size(119, 124);
            this._listWeightTo.TabIndex = 7;
            // 
            // _textWeightTo
            // 
            this._textWeightTo.Location = new System.Drawing.Point(254, 3);
            this._textWeightTo.Name = "_textWeightTo";
            this._textWeightTo.ReadOnly = true;
            this._textWeightTo.Size = new System.Drawing.Size(119, 23);
            this._textWeightTo.TabIndex = 8;
            // 
            // _buttWeightConvert
            // 
            this._buttWeightConvert.Location = new System.Drawing.Point(148, 133);
            this._buttWeightConvert.Name = "_buttWeightConvert";
            this._buttWeightConvert.Size = new System.Drawing.Size(75, 23);
            this._buttWeightConvert.TabIndex = 9;
            this._buttWeightConvert.Text = "Convert";
            this._buttWeightConvert.UseVisualStyleBackColor = true;
            this._buttWeightConvert.Click += new System.EventHandler(this._buttWeightConvert_Click);
            // 
            // _Tabs
            // 
            this._Tabs.Controls.Add(this._tabDistance);
            this._Tabs.Controls.Add(this._tabWeight);
            this._Tabs.Controls.Add(this._tabTime);
            this._Tabs.Location = new System.Drawing.Point(8, 7);
            this._Tabs.Name = "_Tabs";
            this._Tabs.SelectedIndex = 0;
            this._Tabs.Size = new System.Drawing.Size(384, 384);
            this._Tabs.TabIndex = 10;
            // 
            // _tabDistance
            // 
            this._tabDistance.BackColor = System.Drawing.Color.DimGray;
            this._tabDistance.Controls.Add(this._textFromUnit);
            this._tabDistance.Controls.Add(this._textToUnit);
            this._tabDistance.Controls.Add(this._fromUnit);
            this._tabDistance.Controls.Add(this._toUnit);
            this._tabDistance.Controls.Add(this._buttConvert);
            this._tabDistance.Location = new System.Drawing.Point(4, 24);
            this._tabDistance.Name = "_tabDistance";
            this._tabDistance.Padding = new System.Windows.Forms.Padding(3);
            this._tabDistance.Size = new System.Drawing.Size(376, 356);
            this._tabDistance.TabIndex = 0;
            this._tabDistance.Text = "Distance";
            // 
            // _tabWeight
            // 
            this._tabWeight.BackColor = System.Drawing.Color.DimGray;
            this._tabWeight.Controls.Add(this._textWeightFrom);
            this._tabWeight.Controls.Add(this._buttWeightConvert);
            this._tabWeight.Controls.Add(this._textWeightTo);
            this._tabWeight.Controls.Add(this._listWeightTo);
            this._tabWeight.Controls.Add(this._listWeightFrom);
            this._tabWeight.Location = new System.Drawing.Point(4, 24);
            this._tabWeight.Name = "_tabWeight";
            this._tabWeight.Padding = new System.Windows.Forms.Padding(3);
            this._tabWeight.Size = new System.Drawing.Size(376, 356);
            this._tabWeight.TabIndex = 1;
            this._tabWeight.Text = "Weight";
            // 
            // _tabTime
            // 
            this._tabTime.BackColor = System.Drawing.Color.DimGray;
            this._tabTime.Controls.Add(this._buttTimeConvert);
            this._tabTime.Controls.Add(this._textTimeFrom);
            this._tabTime.Controls.Add(this._textTimeTo);
            this._tabTime.Controls.Add(this._listTimeTo);
            this._tabTime.Controls.Add(this._listTimeFrom);
            this._tabTime.Location = new System.Drawing.Point(4, 24);
            this._tabTime.Name = "_tabTime";
            this._tabTime.Size = new System.Drawing.Size(376, 356);
            this._tabTime.TabIndex = 2;
            this._tabTime.Text = "Time";
            // 
            // _buttTimeConvert
            // 
            this._buttTimeConvert.Location = new System.Drawing.Point(148, 133);
            this._buttTimeConvert.Name = "_buttTimeConvert";
            this._buttTimeConvert.Size = new System.Drawing.Size(75, 23);
            this._buttTimeConvert.TabIndex = 14;
            this._buttTimeConvert.Text = "Convert";
            this._buttTimeConvert.UseVisualStyleBackColor = true;
            this._buttTimeConvert.Click += new System.EventHandler(this._buttTimeConvert_Click);
            // 
            // _textTimeFrom
            // 
            this._textTimeFrom.Location = new System.Drawing.Point(3, 3);
            this._textTimeFrom.MaxLength = 15;
            this._textTimeFrom.Name = "_textTimeFrom";
            this._textTimeFrom.Size = new System.Drawing.Size(119, 23);
            this._textTimeFrom.TabIndex = 11;
            this._textTimeFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._keyPress);
            // 
            // _textTimeTo
            // 
            this._textTimeTo.Location = new System.Drawing.Point(254, 3);
            this._textTimeTo.Name = "_textTimeTo";
            this._textTimeTo.ReadOnly = true;
            this._textTimeTo.Size = new System.Drawing.Size(119, 23);
            this._textTimeTo.TabIndex = 12;
            // 
            // _listTimeTo
            // 
            this._listTimeTo.FormattingEnabled = true;
            this._listTimeTo.ItemHeight = 15;
            this._listTimeTo.Location = new System.Drawing.Point(254, 32);
            this._listTimeTo.Name = "_listTimeTo";
            this._listTimeTo.Size = new System.Drawing.Size(119, 124);
            this._listTimeTo.TabIndex = 13;
            // 
            // _listTimeFrom
            // 
            this._listTimeFrom.FormattingEnabled = true;
            this._listTimeFrom.ItemHeight = 15;
            this._listTimeFrom.Location = new System.Drawing.Point(3, 32);
            this._listTimeFrom.Name = "_listTimeFrom";
            this._listTimeFrom.Size = new System.Drawing.Size(119, 124);
            this._listTimeFrom.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(394, 393);
            this.Controls.Add(this._Tabs);
            this.Name = "Form1";
            this.Text = "Conversions 2.0";
            this._Tabs.ResumeLayout(false);
            this._tabDistance.ResumeLayout(false);
            this._tabDistance.PerformLayout();
            this._tabWeight.ResumeLayout(false);
            this._tabWeight.PerformLayout();
            this._tabTime.ResumeLayout(false);
            this._tabTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox _fromUnit;
        private System.Windows.Forms.ListBox _toUnit;
        private System.Windows.Forms.Button _buttConvert;
        private System.Windows.Forms.TextBox _textFromUnit;
        private System.Windows.Forms.TextBox _textToUnit;
        private System.Windows.Forms.ListBox _listWeightFrom;
        private System.Windows.Forms.TextBox _textWeightFrom;
        private System.Windows.Forms.ListBox _listWeightTo;
        private System.Windows.Forms.TextBox _textWeightTo;
        private System.Windows.Forms.Button _buttWeightConvert;
        private System.Windows.Forms.TabControl _Tabs;
        private System.Windows.Forms.TabPage _tabDistance;
        private System.Windows.Forms.TabPage _tabWeight;
        private System.Windows.Forms.TabPage _tabTime;
        private System.Windows.Forms.Button _buttTimeConvert;
        private System.Windows.Forms.TextBox _textTimeFrom;
        private System.Windows.Forms.TextBox _textTimeTo;
        private System.Windows.Forms.ListBox _listTimeTo;
        private System.Windows.Forms.ListBox _listTimeFrom;
    }
}

