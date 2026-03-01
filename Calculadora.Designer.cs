
namespace CalculadoraInteresCompost
{
    partial class Calculadora
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_interestCalculator = new System.Windows.Forms.Label();
            this.lbl_initialAmo = new System.Windows.Forms.Label();
            this.txtQuantitat = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.lbl_period = new System.Windows.Forms.Label();
            this.txtTemps = new System.Windows.Forms.TextBox();
            this.lbl_Interest = new System.Windows.Forms.Label();
            this.lblRalles = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_finalValue = new System.Windows.Forms.Label();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.pnlMoure = new System.Windows.Forms.Panel();
            this.timerAnim = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pnlMoure.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lbl_interestCalculator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 61);
            this.panel1.TabIndex = 0;
            // 
            // lbl_interestCalculator
            // 
            this.lbl_interestCalculator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_interestCalculator.AutoSize = true;
            this.lbl_interestCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_interestCalculator.ForeColor = System.Drawing.Color.White;
            this.lbl_interestCalculator.Location = new System.Drawing.Point(111, 9);
            this.lbl_interestCalculator.Name = "lbl_interestCalculator";
            this.lbl_interestCalculator.Size = new System.Drawing.Size(318, 39);
            this.lbl_interestCalculator.TabIndex = 0;
            this.lbl_interestCalculator.Text = "Interest Calculator";
            this.lbl_interestCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_initialAmo
            // 
            this.lbl_initialAmo.AutoSize = true;
            this.lbl_initialAmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_initialAmo.Location = new System.Drawing.Point(67, 87);
            this.lbl_initialAmo.Name = "lbl_initialAmo";
            this.lbl_initialAmo.Size = new System.Drawing.Size(179, 25);
            this.lbl_initialAmo.TabIndex = 1;
            this.lbl_initialAmo.Text = "Initial Amount (€):";
            // 
            // txtQuantitat
            // 
            this.txtQuantitat.Location = new System.Drawing.Point(310, 92);
            this.txtQuantitat.Name = "txtQuantitat";
            this.txtQuantitat.Size = new System.Drawing.Size(185, 20);
            this.txtQuantitat.TabIndex = 2;
            this.txtQuantitat.TextChanged += new System.EventHandler(this.Quantitat_valors);
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(310, 165);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(185, 20);
            this.txtInteres.TabIndex = 4;
            this.txtInteres.TextChanged += new System.EventHandler(this.InteresAnual);
            // 
            // lbl_period
            // 
            this.lbl_period.AutoSize = true;
            this.lbl_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_period.Location = new System.Drawing.Point(67, 235);
            this.lbl_period.Name = "lbl_period";
            this.lbl_period.Size = new System.Drawing.Size(263, 25);
            this.lbl_period.TabIndex = 5;
            this.lbl_period.Text = "Investment Period (years):";
            // 
            // txtTemps
            // 
            this.txtTemps.Location = new System.Drawing.Point(336, 240);
            this.txtTemps.Name = "txtTemps";
            this.txtTemps.Size = new System.Drawing.Size(159, 20);
            this.txtTemps.TabIndex = 6;
            this.txtTemps.TextChanged += new System.EventHandler(this.Temps_Inversio);
            // 
            // lbl_Interest
            // 
            this.lbl_Interest.AutoSize = true;
            this.lbl_Interest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Interest.Location = new System.Drawing.Point(67, 160);
            this.lbl_Interest.Name = "lbl_Interest";
            this.lbl_Interest.Size = new System.Drawing.Size(201, 25);
            this.lbl_Interest.TabIndex = 3;
            this.lbl_Interest.Text = "Annual Interest (%):";
            // 
            // lblRalles
            // 
            this.lblRalles.AutoSize = true;
            this.lblRalles.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblRalles.Location = new System.Drawing.Point(68, 132);
            this.lblRalles.Name = "lblRalles";
            this.lblRalles.Size = new System.Drawing.Size(427, 13);
            this.lblRalles.TabIndex = 7;
            this.lblRalles.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(68, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(177, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(212, 50);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.Calcular);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(68, 96);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(86, 25);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "Result:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(68, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(493, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-";
            // 
            // lbl_finalValue
            // 
            this.lbl_finalValue.AutoSize = true;
            this.lbl_finalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finalValue.Location = new System.Drawing.Point(68, 196);
            this.lbl_finalValue.Name = "lbl_finalValue";
            this.lbl_finalValue.Size = new System.Drawing.Size(126, 25);
            this.lbl_finalValue.TabIndex = 14;
            this.lbl_finalValue.Text = "Final Value:";
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal1.Location = new System.Drawing.Point(209, 196);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(36, 25);
            this.lblVal1.TabIndex = 15;
            this.lblVal1.Text = "0€";
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal2.Location = new System.Drawing.Point(209, 144);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(36, 25);
            this.lblVal2.TabIndex = 17;
            this.lblVal2.Text = "0€";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(68, 144);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(122, 25);
            this.lblTotalProfit.TabIndex = 16;
            this.lblTotalProfit.Text = "Total Profit:";
            // 
            // pnlMoure
            // 
            this.pnlMoure.Controls.Add(this.btnCalculate);
            this.pnlMoure.Controls.Add(this.lblVal2);
            this.pnlMoure.Controls.Add(this.lblResult);
            this.pnlMoure.Controls.Add(this.lblTotalProfit);
            this.pnlMoure.Controls.Add(this.label5);
            this.pnlMoure.Controls.Add(this.lblVal1);
            this.pnlMoure.Controls.Add(this.lbl_finalValue);
            this.pnlMoure.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMoure.Location = new System.Drawing.Point(0, 290);
            this.pnlMoure.Name = "pnlMoure";
            this.pnlMoure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlMoure.Size = new System.Drawing.Size(577, 251);
            this.pnlMoure.TabIndex = 19;
            // 
            // timerAnim
            // 
            this.timerAnim.Interval = 2000;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(577, 541);
            this.Controls.Add(this.pnlMoure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRalles);
            this.Controls.Add(this.txtTemps);
            this.Controls.Add(this.lbl_period);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.lbl_Interest);
            this.Controls.Add(this.txtQuantitat);
            this.Controls.Add(this.lbl_initialAmo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora d\'interès ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMoure.ResumeLayout(false);
            this.pnlMoure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_interestCalculator;
        private System.Windows.Forms.Label lbl_initialAmo;
        private System.Windows.Forms.TextBox txtQuantitat;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label lbl_period;
        private System.Windows.Forms.TextBox txtTemps;
        private System.Windows.Forms.Label lbl_Interest;
        private System.Windows.Forms.Label lblRalles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_finalValue;
        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Panel pnlMoure;
        private System.Windows.Forms.Timer timerAnim;
    }
}

