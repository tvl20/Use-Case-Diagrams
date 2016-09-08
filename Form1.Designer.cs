namespace Use_Case_DiagramApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_UseCase = new System.Windows.Forms.TextBox();
            this.tb_Actor_Name = new System.Windows.Forms.TextBox();
            this.rbtn_line = new System.Windows.Forms.RadioButton();
            this.rbtn_useCase = new System.Windows.Forms.RadioButton();
            this.rbtn_actor = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_modesCreate = new System.Windows.Forms.RadioButton();
            this.rbtn_modesSelect = new System.Windows.Forms.RadioButton();
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.Pn_useCase = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_UseCase);
            this.groupBox1.Controls.Add(this.tb_Actor_Name);
            this.groupBox1.Controls.Add(this.rbtn_line);
            this.groupBox1.Controls.Add(this.rbtn_useCase);
            this.groupBox1.Controls.Add(this.rbtn_actor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object";
            // 
            // tb_UseCase
            // 
            this.tb_UseCase.Location = new System.Drawing.Point(111, 47);
            this.tb_UseCase.Name = "tb_UseCase";
            this.tb_UseCase.Size = new System.Drawing.Size(100, 22);
            this.tb_UseCase.TabIndex = 4;
            // 
            // tb_Actor_Name
            // 
            this.tb_Actor_Name.Location = new System.Drawing.Point(111, 20);
            this.tb_Actor_Name.Name = "tb_Actor_Name";
            this.tb_Actor_Name.Size = new System.Drawing.Size(100, 22);
            this.tb_Actor_Name.TabIndex = 3;
            // 
            // rbtn_line
            // 
            this.rbtn_line.AutoSize = true;
            this.rbtn_line.Location = new System.Drawing.Point(6, 75);
            this.rbtn_line.Name = "rbtn_line";
            this.rbtn_line.Size = new System.Drawing.Size(56, 21);
            this.rbtn_line.TabIndex = 2;
            this.rbtn_line.TabStop = true;
            this.rbtn_line.Text = "Line";
            this.rbtn_line.UseVisualStyleBackColor = true;
            // 
            // rbtn_useCase
            // 
            this.rbtn_useCase.AutoSize = true;
            this.rbtn_useCase.Location = new System.Drawing.Point(6, 48);
            this.rbtn_useCase.Name = "rbtn_useCase";
            this.rbtn_useCase.Size = new System.Drawing.Size(88, 21);
            this.rbtn_useCase.TabIndex = 1;
            this.rbtn_useCase.TabStop = true;
            this.rbtn_useCase.Text = "Use case";
            this.rbtn_useCase.UseVisualStyleBackColor = true;
            // 
            // rbtn_actor
            // 
            this.rbtn_actor.AutoSize = true;
            this.rbtn_actor.Location = new System.Drawing.Point(6, 21);
            this.rbtn_actor.Name = "rbtn_actor";
            this.rbtn_actor.Size = new System.Drawing.Size(62, 21);
            this.rbtn_actor.TabIndex = 0;
            this.rbtn_actor.TabStop = true;
            this.rbtn_actor.Text = "Actor";
            this.rbtn_actor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_modesCreate);
            this.groupBox2.Controls.Add(this.rbtn_modesSelect);
            this.groupBox2.Location = new System.Drawing.Point(267, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 101);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modes";
            // 
            // rbtn_modesCreate
            // 
            this.rbtn_modesCreate.AutoSize = true;
            this.rbtn_modesCreate.Location = new System.Drawing.Point(6, 48);
            this.rbtn_modesCreate.Name = "rbtn_modesCreate";
            this.rbtn_modesCreate.Size = new System.Drawing.Size(71, 21);
            this.rbtn_modesCreate.TabIndex = 1;
            this.rbtn_modesCreate.TabStop = true;
            this.rbtn_modesCreate.Text = "Create";
            this.rbtn_modesCreate.UseVisualStyleBackColor = true;
            // 
            // rbtn_modesSelect
            // 
            this.rbtn_modesSelect.AutoSize = true;
            this.rbtn_modesSelect.Location = new System.Drawing.Point(6, 21);
            this.rbtn_modesSelect.Name = "rbtn_modesSelect";
            this.rbtn_modesSelect.Size = new System.Drawing.Size(68, 21);
            this.rbtn_modesSelect.TabIndex = 0;
            this.rbtn_modesSelect.TabStop = true;
            this.rbtn_modesSelect.Text = "Select";
            this.rbtn_modesSelect.UseVisualStyleBackColor = true;
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.Location = new System.Drawing.Point(535, 12);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(75, 40);
            this.btn_clearAll.TabIndex = 4;
            this.btn_clearAll.Text = "Clear all";
            this.btn_clearAll.UseVisualStyleBackColor = true;
            this.btn_clearAll.Click += new System.EventHandler(this.btn_clearAll_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(535, 68);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 40);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Pn_useCase
            // 
            this.Pn_useCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pn_useCase.Location = new System.Drawing.Point(12, 119);
            this.Pn_useCase.Name = "Pn_useCase";
            this.Pn_useCase.Size = new System.Drawing.Size(598, 302);
            this.Pn_useCase.TabIndex = 6;
            this.Pn_useCase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pn_useCase_MouseClick);
            this.Pn_useCase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pn_useCase_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "X: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mouse Position:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pn_useCase);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_clearAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Use Case Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_line;
        private System.Windows.Forms.RadioButton rbtn_useCase;
        private System.Windows.Forms.RadioButton rbtn_actor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_modesCreate;
        private System.Windows.Forms.RadioButton rbtn_modesSelect;
        private System.Windows.Forms.Button btn_clearAll;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Panel Pn_useCase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Actor_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_UseCase;
        private System.Windows.Forms.Label label5;
    }
}