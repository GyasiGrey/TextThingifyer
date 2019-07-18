namespace TextThingifyer
{
    partial class MainForm
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
            this.InputText = new System.Windows.Forms.TextBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.Base64Decode = new System.Windows.Forms.Button();
            this.Base64Encode = new System.Windows.Forms.Button();
            this.JSONPretty = new System.Windows.Forms.Button();
            this.XMLPretty = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputText.Location = new System.Drawing.Point(3, 3);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InputText.Size = new System.Drawing.Size(395, 354);
            this.InputText.TabIndex = 0;
            // 
            // OutputText
            // 
            this.OutputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputText.Location = new System.Drawing.Point(604, 3);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputText.Size = new System.Drawing.Size(396, 354);
            this.OutputText.TabIndex = 1;
            // 
            // Base64Decode
            // 
            this.Base64Decode.Location = new System.Drawing.Point(3, 3);
            this.Base64Decode.Name = "Base64Decode";
            this.Base64Decode.Size = new System.Drawing.Size(126, 23);
            this.Base64Decode.TabIndex = 2;
            this.Base64Decode.Text = "Base64 Decode";
            this.Base64Decode.UseVisualStyleBackColor = true;
            this.Base64Decode.Click += new System.EventHandler(this.Base64Decode_Click);
            // 
            // Base64Encode
            // 
            this.Base64Encode.Location = new System.Drawing.Point(3, 32);
            this.Base64Encode.Name = "Base64Encode";
            this.Base64Encode.Size = new System.Drawing.Size(126, 23);
            this.Base64Encode.TabIndex = 3;
            this.Base64Encode.Text = "Base64 Encode";
            this.Base64Encode.UseVisualStyleBackColor = true;
            this.Base64Encode.Click += new System.EventHandler(this.Base64Encode_Click);
            // 
            // JSONPretty
            // 
            this.JSONPretty.Location = new System.Drawing.Point(3, 61);
            this.JSONPretty.Name = "JSONPretty";
            this.JSONPretty.Size = new System.Drawing.Size(126, 23);
            this.JSONPretty.TabIndex = 4;
            this.JSONPretty.Text = "JSON Pretty";
            this.JSONPretty.UseVisualStyleBackColor = true;
            this.JSONPretty.Click += new System.EventHandler(this.JSONPretty_Click);
            // 
            // XMLPretty
            // 
            this.XMLPretty.Location = new System.Drawing.Point(3, 90);
            this.XMLPretty.Name = "XMLPretty";
            this.XMLPretty.Size = new System.Drawing.Size(126, 23);
            this.XMLPretty.TabIndex = 5;
            this.XMLPretty.Text = "XML Pretty";
            this.XMLPretty.UseVisualStyleBackColor = true;
            this.XMLPretty.Click += new System.EventHandler(this.XMLPretty_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.InputText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OutputText, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1003, 360);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.Base64Decode);
            this.flowLayoutPanel1.Controls.Add(this.Base64Encode);
            this.flowLayoutPanel1.Controls.Add(this.JSONPretty);
            this.flowLayoutPanel1.Controls.Add(this.XMLPretty);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(435, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(132, 116);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 360);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Thingifyer!";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button Base64Decode;
        private System.Windows.Forms.Button Base64Encode;
        private System.Windows.Forms.Button JSONPretty;
        private System.Windows.Forms.Button XMLPretty;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

