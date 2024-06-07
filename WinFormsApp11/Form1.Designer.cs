namespace WinFormsApp11
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
            txtNameInput = new TextBox();
            txtIndex = new TextBox();
            txtValue = new TextBox();
            txtDeleteValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblStatus = new Label();
            btnCreateArray = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label5 = new Label();
            lstArray = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // txtNameInput
            // 
            txtNameInput.Location = new Point(137, 38);
            txtNameInput.Name = "txtNameInput";
            txtNameInput.Size = new Size(100, 23);
            txtNameInput.TabIndex = 0;
            // 
            // txtIndex
            // 
            txtIndex.Location = new Point(137, 105);
            txtIndex.Name = "txtIndex";
            txtIndex.Size = new Size(100, 23);
            txtIndex.TabIndex = 1;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(327, 102);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(169, 23);
            txtValue.TabIndex = 2;
            // 
            // txtDeleteValue
            // 
            txtDeleteValue.Location = new Point(148, 201);
            txtDeleteValue.Name = "txtDeleteValue";
            txtDeleteValue.Size = new Size(155, 23);
            txtDeleteValue.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(43, 41);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 4;
            label1.Text = "InputElement";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(43, 113);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Index";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.MediumSpringGreen;
            label3.Location = new Point(27, 204);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 6;
            label3.Text = "Index to Delelete";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(239, 302);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Display";
            // 
            // btnCreateArray
            // 
            btnCreateArray.ForeColor = Color.Red;
            btnCreateArray.Location = new Point(310, 38);
            btnCreateArray.Name = "btnCreateArray";
            btnCreateArray.Size = new Size(76, 23);
            btnCreateArray.TabIndex = 8;
            btnCreateArray.Text = "CraetArray";
            btnCreateArray.UseVisualStyleBackColor = true;
            btnCreateArray.Click += btnCreateArray_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.Red;
            btnUpdate.Location = new Point(259, 146);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(93, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(359, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "ToDelete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(259, 105);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 11;
            label5.Text = "Value";
            // 
            // lstArray
            // 
            lstArray.ForeColor = Color.Cyan;
            lstArray.FormattingEnabled = true;
            lstArray.ItemHeight = 15;
            lstArray.Location = new Point(517, 233);
            lstArray.Name = "lstArray";
            lstArray.Size = new Size(144, 94);
            lstArray.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(540, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 101);
            textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(lstArray);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreateArray);
            Controls.Add(lblStatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDeleteValue);
            Controls.Add(txtValue);
            Controls.Add(txtIndex);
            Controls.Add(txtNameInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNameInput;
        private TextBox txtIndex;
        private TextBox txtValue;
        private TextBox txtDeleteValue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblStatus;
        private Button btnCreateArray;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label5;
        private ListBox lstArray;
        private TextBox textBox1;
    }
}
