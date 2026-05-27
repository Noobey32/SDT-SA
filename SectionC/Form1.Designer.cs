namespace SectionC
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
            txtCode = new TextBox();
            txtMake = new TextBox();
            txtModel = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            lblOutput = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(373, 99);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(146, 23);
            txtCode.TabIndex = 0;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(373, 128);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(146, 23);
            txtMake.TabIndex = 1;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(373, 157);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(146, 23);
            txtModel.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(282, 211);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(363, 211);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(444, 211);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 5;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            lblOutput.Location = new Point(282, 43);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(237, 23);
            lblOutput.TabIndex = 6;
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 102);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 7;
            label2.Text = "Mobile Code";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 131);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Make";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 160);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 9;
            label4.Text = "Quantity";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblOutput);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(txtCode);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtModel;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
        private Label lblOutput;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
