namespace HorasExtrasX
{
    partial class FormPrincipal
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txbPath = new System.Windows.Forms.TextBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(8, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(255, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Realizar busca na pasta local (arquivos .xlsx)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txbPath
            // 
            this.txbPath.Enabled = false;
            this.txbPath.Location = new System.Drawing.Point(125, 99);
            this.txbPath.Name = "txbPath";
            this.txbPath.ReadOnly = true;
            this.txbPath.Size = new System.Drawing.Size(596, 23);
            this.txbPath.TabIndex = 1;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoras.Location = new System.Drawing.Point(8, 7);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(141, 30);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horas Extras:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(155, 7);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 30);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "00:00";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(572, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Enabled = false;
            this.btnFolder.Location = new System.Drawing.Point(8, 99);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(111, 23);
            this.btnFolder.TabIndex = 7;
            this.btnFolder.Text = "Selecionar Pasta";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 186);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.txbPath);
            this.Controls.Add(this.checkBox1);
            this.Name = "FormPrincipal";
            this.Text = "Horas Extras";

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txbPath;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button button2;
    }
}

