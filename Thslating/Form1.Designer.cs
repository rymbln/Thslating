namespace Thslating
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxExcelFile = new System.Windows.Forms.TextBox();
            this.btnSelectExcel = new System.Windows.Forms.Button();
            this.lbxExcelColumns = new System.Windows.Forms.ListBox();
            this.tbxSheetName = new System.Windows.Forms.TextBox();
            this.lbxForTranslate = new System.Windows.Forms.ListBox();
            this.btnFromTranslate = new System.Windows.Forms.Button();
            this.btnToTranslate = new System.Windows.Forms.Button();
            this.btnTranslateToExcel = new System.Windows.Forms.Button();
            this.tbxTranslatedSheet = new System.Windows.Forms.TextBox();
            this.tbxTranslatedExcel = new System.Windows.Forms.TextBox();
            this.btnSelectAccess = new System.Windows.Forms.Button();
            this.tbxInputAccess = new System.Windows.Forms.TextBox();
            this.btnFromAccessToTranslate = new System.Windows.Forms.Button();
            this.btnFromTranslateToAccess = new System.Windows.Forms.Button();
            this.lbxAccessElements = new System.Windows.Forms.ListBox();
            this.lbxAccessFields = new System.Windows.Forms.ListBox();
            this.tbxAccessNewElement = new System.Windows.Forms.TextBox();
            this.btnTranslateAccess = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(347, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Google";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Yandex";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxExcelFile
            // 
            this.tbxExcelFile.Location = new System.Drawing.Point(13, 14);
            this.tbxExcelFile.Name = "tbxExcelFile";
            this.tbxExcelFile.Size = new System.Drawing.Size(208, 20);
            this.tbxExcelFile.TabIndex = 4;
            // 
            // btnSelectExcel
            // 
            this.btnSelectExcel.Location = new System.Drawing.Point(227, 12);
            this.btnSelectExcel.Name = "btnSelectExcel";
            this.btnSelectExcel.Size = new System.Drawing.Size(75, 23);
            this.btnSelectExcel.TabIndex = 5;
            this.btnSelectExcel.Text = "Excel";
            this.btnSelectExcel.UseVisualStyleBackColor = true;
            this.btnSelectExcel.Click += new System.EventHandler(this.btnSelectExcel_Click);
            // 
            // lbxExcelColumns
            // 
            this.lbxExcelColumns.FormattingEnabled = true;
            this.lbxExcelColumns.Location = new System.Drawing.Point(13, 70);
            this.lbxExcelColumns.Name = "lbxExcelColumns";
            this.lbxExcelColumns.Size = new System.Drawing.Size(289, 186);
            this.lbxExcelColumns.TabIndex = 6;
            // 
            // tbxSheetName
            // 
            this.tbxSheetName.Location = new System.Drawing.Point(13, 44);
            this.tbxSheetName.Name = "tbxSheetName";
            this.tbxSheetName.Size = new System.Drawing.Size(289, 20);
            this.tbxSheetName.TabIndex = 7;
            // 
            // lbxForTranslate
            // 
            this.lbxForTranslate.FormattingEnabled = true;
            this.lbxForTranslate.Location = new System.Drawing.Point(346, 136);
            this.lbxForTranslate.Name = "lbxForTranslate";
            this.lbxForTranslate.Size = new System.Drawing.Size(259, 121);
            this.lbxForTranslate.TabIndex = 8;
            // 
            // btnFromTranslate
            // 
            this.btnFromTranslate.Location = new System.Drawing.Point(308, 199);
            this.btnFromTranslate.Name = "btnFromTranslate";
            this.btnFromTranslate.Size = new System.Drawing.Size(33, 61);
            this.btnFromTranslate.TabIndex = 9;
            this.btnFromTranslate.Text = "<---";
            this.btnFromTranslate.UseVisualStyleBackColor = true;
            this.btnFromTranslate.Click += new System.EventHandler(this.btnFromTranslate_Click);
            // 
            // btnToTranslate
            // 
            this.btnToTranslate.Location = new System.Drawing.Point(307, 136);
            this.btnToTranslate.Name = "btnToTranslate";
            this.btnToTranslate.Size = new System.Drawing.Size(33, 57);
            this.btnToTranslate.TabIndex = 10;
            this.btnToTranslate.Text = "--->";
            this.btnToTranslate.UseVisualStyleBackColor = true;
            this.btnToTranslate.Click += new System.EventHandler(this.btnToTranslate_Click);
            // 
            // btnTranslateToExcel
            // 
            this.btnTranslateToExcel.Location = new System.Drawing.Point(637, 95);
            this.btnTranslateToExcel.Name = "btnTranslateToExcel";
            this.btnTranslateToExcel.Size = new System.Drawing.Size(229, 23);
            this.btnTranslateToExcel.TabIndex = 11;
            this.btnTranslateToExcel.Text = "btnTranslateToExcel";
            this.btnTranslateToExcel.UseVisualStyleBackColor = true;
            this.btnTranslateToExcel.Click += new System.EventHandler(this.btnTranslateToExcel_Click);
            // 
            // tbxTranslatedSheet
            // 
            this.tbxTranslatedSheet.Location = new System.Drawing.Point(637, 45);
            this.tbxTranslatedSheet.Name = "tbxTranslatedSheet";
            this.tbxTranslatedSheet.Size = new System.Drawing.Size(229, 20);
            this.tbxTranslatedSheet.TabIndex = 12;
            // 
            // tbxTranslatedExcel
            // 
            this.tbxTranslatedExcel.Location = new System.Drawing.Point(637, 69);
            this.tbxTranslatedExcel.Name = "tbxTranslatedExcel";
            this.tbxTranslatedExcel.Size = new System.Drawing.Size(229, 20);
            this.tbxTranslatedExcel.TabIndex = 13;
            // 
            // btnSelectAccess
            // 
            this.btnSelectAccess.Location = new System.Drawing.Point(226, 271);
            this.btnSelectAccess.Name = "btnSelectAccess";
            this.btnSelectAccess.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAccess.TabIndex = 15;
            this.btnSelectAccess.Text = "Access";
            this.btnSelectAccess.UseVisualStyleBackColor = true;
            this.btnSelectAccess.Click += new System.EventHandler(this.btnSelectAccess_Click);
            // 
            // tbxInputAccess
            // 
            this.tbxInputAccess.Location = new System.Drawing.Point(12, 273);
            this.tbxInputAccess.Name = "tbxInputAccess";
            this.tbxInputAccess.Size = new System.Drawing.Size(208, 20);
            this.tbxInputAccess.TabIndex = 14;
            // 
            // btnFromAccessToTranslate
            // 
            this.btnFromAccessToTranslate.Location = new System.Drawing.Point(347, 263);
            this.btnFromAccessToTranslate.Name = "btnFromAccessToTranslate";
            this.btnFromAccessToTranslate.Size = new System.Drawing.Size(99, 31);
            this.btnFromAccessToTranslate.TabIndex = 16;
            this.btnFromAccessToTranslate.Text = "TO";
            this.btnFromAccessToTranslate.UseVisualStyleBackColor = true;
            this.btnFromAccessToTranslate.Click += new System.EventHandler(this.btnFromAccessToTranslate_Click);
            // 
            // btnFromTranslateToAccess
            // 
            this.btnFromTranslateToAccess.Location = new System.Drawing.Point(452, 263);
            this.btnFromTranslateToAccess.Name = "btnFromTranslateToAccess";
            this.btnFromTranslateToAccess.Size = new System.Drawing.Size(153, 31);
            this.btnFromTranslateToAccess.TabIndex = 17;
            this.btnFromTranslateToAccess.Text = "FROM";
            this.btnFromTranslateToAccess.UseVisualStyleBackColor = true;
            this.btnFromTranslateToAccess.Click += new System.EventHandler(this.btnFromTranslateToAccess_Click);
            // 
            // lbxAccessElements
            // 
            this.lbxAccessElements.FormattingEnabled = true;
            this.lbxAccessElements.Location = new System.Drawing.Point(13, 300);
            this.lbxAccessElements.Name = "lbxAccessElements";
            this.lbxAccessElements.Size = new System.Drawing.Size(289, 186);
            this.lbxAccessElements.TabIndex = 18;
            this.lbxAccessElements.SelectedIndexChanged += new System.EventHandler(this.lbxAccessElements_SelectedIndexChanged);
            // 
            // lbxAccessFields
            // 
            this.lbxAccessFields.FormattingEnabled = true;
            this.lbxAccessFields.Location = new System.Drawing.Point(329, 300);
            this.lbxAccessFields.Name = "lbxAccessFields";
            this.lbxAccessFields.Size = new System.Drawing.Size(289, 186);
            this.lbxAccessFields.TabIndex = 19;
            // 
            // tbxAccessNewElement
            // 
            this.tbxAccessNewElement.Location = new System.Drawing.Point(637, 274);
            this.tbxAccessNewElement.Name = "tbxAccessNewElement";
            this.tbxAccessNewElement.Size = new System.Drawing.Size(229, 20);
            this.tbxAccessNewElement.TabIndex = 20;
            // 
            // btnTranslateAccess
            // 
            this.btnTranslateAccess.Location = new System.Drawing.Point(637, 300);
            this.btnTranslateAccess.Name = "btnTranslateAccess";
            this.btnTranslateAccess.Size = new System.Drawing.Size(229, 23);
            this.btnTranslateAccess.TabIndex = 21;
            this.btnTranslateAccess.Text = "btnTranslateAccess";
            this.btnTranslateAccess.UseVisualStyleBackColor = true;
            this.btnTranslateAccess.Click += new System.EventHandler(this.btnTranslateAccess_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(637, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 517);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnTranslateAccess);
            this.Controls.Add(this.tbxAccessNewElement);
            this.Controls.Add(this.lbxAccessFields);
            this.Controls.Add(this.lbxAccessElements);
            this.Controls.Add(this.btnFromTranslateToAccess);
            this.Controls.Add(this.btnFromAccessToTranslate);
            this.Controls.Add(this.btnSelectAccess);
            this.Controls.Add(this.tbxInputAccess);
            this.Controls.Add(this.tbxTranslatedExcel);
            this.Controls.Add(this.tbxTranslatedSheet);
            this.Controls.Add(this.btnTranslateToExcel);
            this.Controls.Add(this.btnToTranslate);
            this.Controls.Add(this.btnFromTranslate);
            this.Controls.Add(this.lbxForTranslate);
            this.Controls.Add(this.tbxSheetName);
            this.Controls.Add(this.lbxExcelColumns);
            this.Controls.Add(this.btnSelectExcel);
            this.Controls.Add(this.tbxExcelFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbxExcelFile;
        private System.Windows.Forms.Button btnSelectExcel;
        private System.Windows.Forms.ListBox lbxExcelColumns;
        private System.Windows.Forms.TextBox tbxSheetName;
        private System.Windows.Forms.ListBox lbxForTranslate;
        private System.Windows.Forms.Button btnFromTranslate;
        private System.Windows.Forms.Button btnToTranslate;
        private System.Windows.Forms.Button btnTranslateToExcel;
        private System.Windows.Forms.TextBox tbxTranslatedSheet;
        private System.Windows.Forms.TextBox tbxTranslatedExcel;
        private System.Windows.Forms.Button btnSelectAccess;
        private System.Windows.Forms.TextBox tbxInputAccess;
        private System.Windows.Forms.Button btnFromAccessToTranslate;
        private System.Windows.Forms.Button btnFromTranslateToAccess;
        private System.Windows.Forms.ListBox lbxAccessElements;
        private System.Windows.Forms.ListBox lbxAccessFields;
        private System.Windows.Forms.TextBox tbxAccessNewElement;
        private System.Windows.Forms.Button btnTranslateAccess;
        private System.Windows.Forms.Button button3;
    }
}

