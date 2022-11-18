namespace PrivateNavSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.WebView_Container = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.goBTN = new System.Windows.Forms.Button();
            this.urlBar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.backBTN = new System.Windows.Forms.Button();
            this.refreshBTN = new System.Windows.Forms.Button();
            this.forwardBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.WebView_Container, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(884, 661);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // WebView_Container
            // 
            this.WebView_Container.ColumnCount = 1;
            this.WebView_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WebView_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebView_Container.Location = new System.Drawing.Point(0, 30);
            this.WebView_Container.Margin = new System.Windows.Forms.Padding(0);
            this.WebView_Container.Name = "WebView_Container";
            this.WebView_Container.RowCount = 1;
            this.WebView_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WebView_Container.Size = new System.Drawing.Size(884, 631);
            this.WebView_Container.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.Controls.Add(this.goBTN, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.urlBar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(884, 30);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // goBTN
            // 
            this.goBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.goBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goBTN.Location = new System.Drawing.Point(839, 0);
            this.goBTN.Margin = new System.Windows.Forms.Padding(0);
            this.goBTN.Name = "goBTN";
            this.goBTN.Size = new System.Drawing.Size(45, 31);
            this.goBTN.TabIndex = 0;
            this.goBTN.Text = "GO!";
            this.goBTN.UseVisualStyleBackColor = true;
            this.goBTN.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // urlBar
            // 
            this.urlBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.urlBar.Location = new System.Drawing.Point(131, 0);
            this.urlBar.Margin = new System.Windows.Forms.Padding(0);
            this.urlBar.Name = "urlBar";
            this.urlBar.Size = new System.Drawing.Size(427, 31);
            this.urlBar.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.Controls.Add(this.backBTN, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.refreshBTN, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.forwardBTN, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(132, 31);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // backBTN
            // 
            this.backBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backBTN.Location = new System.Drawing.Point(0, 0);
            this.backBTN.Margin = new System.Windows.Forms.Padding(0);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(44, 31);
            this.backBTN.TabIndex = 0;
            this.backBTN.Text = "<-";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // refreshBTN
            // 
            this.refreshBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshBTN.Location = new System.Drawing.Point(44, 0);
            this.refreshBTN.Margin = new System.Windows.Forms.Padding(0);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(43, 31);
            this.refreshBTN.TabIndex = 1;
            this.refreshBTN.Text = "-><-";
            this.refreshBTN.UseVisualStyleBackColor = true;
            this.refreshBTN.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // forwardBTN
            // 
            this.forwardBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forwardBTN.Location = new System.Drawing.Point(87, 0);
            this.forwardBTN.Margin = new System.Windows.Forms.Padding(0);
            this.forwardBTN.Name = "forwardBTN";
            this.forwardBTN.Size = new System.Drawing.Size(45, 31);
            this.forwardBTN.TabIndex = 2;
            this.forwardBTN.Text = "->";
            this.forwardBTN.UseVisualStyleBackColor = true;
            this.forwardBTN.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PrivateNavShahrp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel WebView_Container;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button goBTN;
        private System.Windows.Forms.TextBox urlBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.Button forwardBTN;
    }
}

