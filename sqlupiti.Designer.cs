
namespace SQLupiti
{
    partial class sqlupiti
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
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getResult = new System.Windows.Forms.Button();
            this.queryResult = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(49, 86);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(700, 27);
            this.tbQuery.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter SQL Query:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // getResult
            // 
            this.getResult.Location = new System.Drawing.Point(655, 146);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(94, 29);
            this.getResult.TabIndex = 2;
            this.getResult.Text = "Get result";
            this.getResult.UseVisualStyleBackColor = true;
            this.getResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // queryResult
            // 
            this.queryResult.Location = new System.Drawing.Point(49, 197);
            this.queryResult.Multiline = true;
            this.queryResult.Name = "queryResult";
            this.queryResult.ReadOnly = true;
            this.queryResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.queryResult.Size = new System.Drawing.Size(700, 281);
            this.queryResult.TabIndex = 3;
            this.queryResult.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // sqlupiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 539);
            this.Controls.Add(this.queryResult);
            this.Controls.Add(this.getResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbQuery);
            this.Name = "sqlupiti";
            this.Text = "SQLUpiti";
            this.Load += new System.EventHandler(this.sqlupiti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getResult;
        private System.Windows.Forms.TextBox queryResult;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

