namespace Notaciones_polakas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblPreOrder = new System.Windows.Forms.Label();
            this.lblPostOrder = new System.Windows.Forms.Label();
            this.lblInOrder = new System.Windows.Forms.Label();
            this.btnEvaluatePreOrder = new System.Windows.Forms.Button();
            this.txtStackNumbers = new System.Windows.Forms.RichTextBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(26, 12);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(353, 26);
            this.txtExpresion.TabIndex = 0;
            this.txtExpresion.Text = "6-3*4*3*2/8-6/2";
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.Location = new System.Drawing.Point(26, 54);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(78, 30);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPreOrder
            // 
            this.lblPreOrder.AutoSize = true;
            this.lblPreOrder.Location = new System.Drawing.Point(22, 107);
            this.lblPreOrder.Name = "lblPreOrder";
            this.lblPreOrder.Size = new System.Drawing.Size(0, 20);
            this.lblPreOrder.TabIndex = 2;
            // 
            // lblPostOrder
            // 
            this.lblPostOrder.AutoSize = true;
            this.lblPostOrder.Location = new System.Drawing.Point(22, 147);
            this.lblPostOrder.Name = "lblPostOrder";
            this.lblPostOrder.Size = new System.Drawing.Size(0, 20);
            this.lblPostOrder.TabIndex = 3;
            // 
            // lblInOrder
            // 
            this.lblInOrder.AutoSize = true;
            this.lblInOrder.Location = new System.Drawing.Point(22, 204);
            this.lblInOrder.Name = "lblInOrder";
            this.lblInOrder.Size = new System.Drawing.Size(0, 20);
            this.lblInOrder.TabIndex = 4;
            // 
            // btnEvaluatePreOrder
            // 
            this.btnEvaluatePreOrder.AutoSize = true;
            this.btnEvaluatePreOrder.Location = new System.Drawing.Point(457, 245);
            this.btnEvaluatePreOrder.Name = "btnEvaluatePreOrder";
            this.btnEvaluatePreOrder.Size = new System.Drawing.Size(83, 34);
            this.btnEvaluatePreOrder.TabIndex = 5;
            this.btnEvaluatePreOrder.Text = "PreOrder";
            this.btnEvaluatePreOrder.UseVisualStyleBackColor = true;
            this.btnEvaluatePreOrder.Click += new System.EventHandler(this.btnEvaluatePreOrder_Click);
            // 
            // txtStackNumbers
            // 
            this.txtStackNumbers.Location = new System.Drawing.Point(459, 12);
            this.txtStackNumbers.Name = "txtStackNumbers";
            this.txtStackNumbers.Size = new System.Drawing.Size(81, 227);
            this.txtStackNumbers.TabIndex = 6;
            this.txtStackNumbers.Text = "";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(401, 15);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(0, 20);
            this.lblCurrent.TabIndex = 8;
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 568);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.txtStackNumbers);
            this.Controls.Add(this.btnEvaluatePreOrder);
            this.Controls.Add(this.lblInOrder);
            this.Controls.Add(this.lblPostOrder);
            this.Controls.Add(this.lblPreOrder);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtExpresion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblPreOrder;
        private System.Windows.Forms.Label lblPostOrder;
        private System.Windows.Forms.Label lblInOrder;
        private System.Windows.Forms.Button btnEvaluatePreOrder;
        private System.Windows.Forms.RichTextBox txtStackNumbers;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Timer timer;
    }
}

