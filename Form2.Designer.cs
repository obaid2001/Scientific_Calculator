namespace Calculator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSPowerY = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnSinInverse = new System.Windows.Forms.Button();
            this.btnCosInverse = new System.Windows.Forms.Button();
            this.btnTanInverse = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn_Equal = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnDeg = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnRad = new System.Windows.Forms.Button();
            this.btnPluMinus = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnXCube = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnXSquare = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelShowOpt = new System.Windows.Forms.Label();
            this.rtbDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHistoryDiplay = new System.Windows.Forms.Label();
            this.btnDlete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Silver;
            this.txtResult.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtResult.Location = new System.Drawing.Point(15, 139);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(352, 61);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCos.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(231, 217);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(65, 49);
            this.btnCos.TabIndex = 32;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSPowerY
            // 
            this.btnSPowerY.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSPowerY.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPowerY.Location = new System.Drawing.Point(86, 217);
            this.btnSPowerY.Name = "btnSPowerY";
            this.btnSPowerY.Size = new System.Drawing.Size(65, 49);
            this.btnSPowerY.TabIndex = 34;
            this.btnSPowerY.Text = "xʸ";
            this.btnSPowerY.UseVisualStyleBackColor = false;
            this.btnSPowerY.Click += new System.EventHandler(this.operationOnNumbers);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSin.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(157, 217);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(65, 49);
            this.btnSin.TabIndex = 35;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTan.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Location = new System.Drawing.Point(302, 217);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(65, 49);
            this.btnTan.TabIndex = 36;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // button7
            // 
            this.button7.AccessibleName = "btn10x";
            this.button7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(86, 272);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 49);
            this.button7.TabIndex = 38;
            this.button7.Text = "10ˣ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btn10x_Click);
            // 
            // btnSinInverse
            // 
            this.btnSinInverse.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSinInverse.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinInverse.Location = new System.Drawing.Point(157, 272);
            this.btnSinInverse.Name = "btnSinInverse";
            this.btnSinInverse.Size = new System.Drawing.Size(65, 49);
            this.btnSinInverse.TabIndex = 39;
            this.btnSinInverse.Text = "Sin⁻¹";
            this.btnSinInverse.UseVisualStyleBackColor = false;
            this.btnSinInverse.Click += new System.EventHandler(this.btnSinInverse_Click);
            // 
            // btnCosInverse
            // 
            this.btnCosInverse.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCosInverse.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosInverse.Location = new System.Drawing.Point(231, 272);
            this.btnCosInverse.Name = "btnCosInverse";
            this.btnCosInverse.Size = new System.Drawing.Size(65, 49);
            this.btnCosInverse.TabIndex = 40;
            this.btnCosInverse.Text = "cos⁻¹";
            this.btnCosInverse.UseVisualStyleBackColor = false;
            this.btnCosInverse.Click += new System.EventHandler(this.btnCosInverse_Click);
            // 
            // btnTanInverse
            // 
            this.btnTanInverse.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTanInverse.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanInverse.Location = new System.Drawing.Point(302, 272);
            this.btnTanInverse.Name = "btnTanInverse";
            this.btnTanInverse.Size = new System.Drawing.Size(65, 49);
            this.btnTanInverse.TabIndex = 41;
            this.btnTanInverse.Text = "tan⁻¹";
            this.btnTanInverse.UseVisualStyleBackColor = false;
            this.btnTanInverse.Click += new System.EventHandler(this.btnTanInverse_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClearEntry.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntry.Location = new System.Drawing.Point(86, 327);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(65, 49);
            this.btnClearEntry.TabIndex = 42;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(160, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 49);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBackSpace.Font = new System.Drawing.Font("Wingdings", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnBackSpace.Location = new System.Drawing.Point(231, 327);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(65, 49);
            this.btnBackSpace.TabIndex = 44;
            this.btnBackSpace.Text = "";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(302, 327);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(65, 49);
            this.btnDivide.TabIndex = 45;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.operationOnNumbers);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMul.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(302, 382);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(65, 49);
            this.btnMul.TabIndex = 46;
            this.btnMul.Text = "x";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.operationOnNumbers);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(302, 437);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(65, 49);
            this.btnMinus.TabIndex = 47;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.operationOnNumbers);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(302, 492);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(65, 49);
            this.btnPlus.TabIndex = 48;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.operationOnNumbers);
            // 
            // btn_Equal
            // 
            this.btn_Equal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Equal.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Equal.Location = new System.Drawing.Point(302, 547);
            this.btn_Equal.Name = "btn_Equal";
            this.btn_Equal.Size = new System.Drawing.Size(65, 49);
            this.btn_Equal.TabIndex = 49;
            this.btn_Equal.Text = "=";
            this.btn_Equal.UseVisualStyleBackColor = false;
            this.btn_Equal.Click += new System.EventHandler(this.btn_Equal_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button19.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(231, 547);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(65, 49);
            this.button19.TabIndex = 53;
            this.button19.Text = ".";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.inputNumbers);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(231, 492);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(65, 49);
            this.btn3.TabIndex = 52;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.inputNumbers);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(231, 437);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(65, 49);
            this.btn6.TabIndex = 51;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.inputNumbers);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn9.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(231, 382);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(65, 49);
            this.btn9.TabIndex = 50;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.inputNumbers);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button23.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(160, 547);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(65, 49);
            this.button23.TabIndex = 57;
            this.button23.Text = "0";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.inputNumbers);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(160, 492);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 49);
            this.btn2.TabIndex = 56;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.inputNumbers);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(160, 437);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(65, 49);
            this.btn5.TabIndex = 55;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.inputNumbers);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn8.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(160, 382);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(65, 49);
            this.btn8.TabIndex = 54;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.inputNumbers);
            // 
            // btnDeg
            // 
            this.btnDeg.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDeg.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeg.Location = new System.Drawing.Point(86, 547);
            this.btnDeg.Name = "btnDeg";
            this.btnDeg.Size = new System.Drawing.Size(65, 49);
            this.btnDeg.TabIndex = 61;
            this.btnDeg.Text = "Deg";
            this.btnDeg.UseVisualStyleBackColor = false;
            this.btnDeg.Click += new System.EventHandler(this.btnDeg_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(86, 492);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(65, 49);
            this.btn1.TabIndex = 60;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.inputNumbers);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(86, 437);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(65, 49);
            this.btn4.TabIndex = 59;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.inputNumbers);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(86, 382);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(65, 49);
            this.btn7.TabIndex = 58;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.inputNumbers);
            // 
            // btnRad
            // 
            this.btnRad.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRad.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRad.Location = new System.Drawing.Point(15, 547);
            this.btnRad.Name = "btnRad";
            this.btnRad.Size = new System.Drawing.Size(65, 49);
            this.btnRad.TabIndex = 68;
            this.btnRad.Text = "Rad";
            this.btnRad.UseVisualStyleBackColor = false;
            this.btnRad.Click += new System.EventHandler(this.btnRad_Click);
            // 
            // btnPluMinus
            // 
            this.btnPluMinus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPluMinus.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPluMinus.Location = new System.Drawing.Point(15, 492);
            this.btnPluMinus.Name = "btnPluMinus";
            this.btnPluMinus.Size = new System.Drawing.Size(65, 49);
            this.btnPluMinus.TabIndex = 67;
            this.btnPluMinus.Text = "  ± ";
            this.btnPluMinus.UseVisualStyleBackColor = false;
            this.btnPluMinus.Click += new System.EventHandler(this.btnPluMinus_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.Location = new System.Drawing.Point(15, 437);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(65, 49);
            this.btnFactorial.TabIndex = 66;
            this.btnFactorial.Text = "n!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPi.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.Location = new System.Drawing.Point(15, 382);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(65, 49);
            this.btnPi.TabIndex = 65;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnXCube
            // 
            this.btnXCube.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnXCube.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXCube.Location = new System.Drawing.Point(15, 327);
            this.btnXCube.Name = "btnXCube";
            this.btnXCube.Size = new System.Drawing.Size(65, 49);
            this.btnXCube.TabIndex = 64;
            this.btnXCube.Text = "x³";
            this.btnXCube.UseVisualStyleBackColor = false;
            this.btnXCube.Click += new System.EventHandler(this.btnXCube_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRoot.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoot.Location = new System.Drawing.Point(15, 272);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(65, 49);
            this.btnRoot.TabIndex = 63;
            this.btnRoot.Text = "√";
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // btnXSquare
            // 
            this.btnXSquare.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnXSquare.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXSquare.Location = new System.Drawing.Point(15, 217);
            this.btnXSquare.Name = "btnXSquare";
            this.btnXSquare.Size = new System.Drawing.Size(65, 49);
            this.btnXSquare.TabIndex = 62;
            this.btnXSquare.Text = "x²";
            this.btnXSquare.UseVisualStyleBackColor = false;
            this.btnXSquare.Click += new System.EventHandler(this.btnXSquare_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 49);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 45);
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.scientificToolStripMenuItem.Text = "Scientific";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 70;
            this.label1.Text = "Scientific ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelShowOpt
            // 
            this.labelShowOpt.AutoSize = true;
            this.labelShowOpt.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowOpt.Location = new System.Drawing.Point(285, 75);
            this.labelShowOpt.Name = "labelShowOpt";
            this.labelShowOpt.Size = new System.Drawing.Size(0, 31);
            this.labelShowOpt.TabIndex = 71;
            // 
            // rtbDisplayHistory
            // 
            this.rtbDisplayHistory.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rtbDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDisplayHistory.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDisplayHistory.Location = new System.Drawing.Point(476, 139);
            this.rtbDisplayHistory.Name = "rtbDisplayHistory";
            this.rtbDisplayHistory.ReadOnly = true;
            this.rtbDisplayHistory.Size = new System.Drawing.Size(219, 402);
            this.rtbDisplayHistory.TabIndex = 72;
            this.rtbDisplayHistory.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 35);
            this.label2.TabIndex = 74;
            this.label2.Text = "History";
            // 
            // lblHistoryDiplay
            // 
            this.lblHistoryDiplay.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryDiplay.Location = new System.Drawing.Point(498, 62);
            this.lblHistoryDiplay.Name = "lblHistoryDiplay";
            this.lblHistoryDiplay.Size = new System.Drawing.Size(214, 28);
            this.lblHistoryDiplay.TabIndex = 75;
            this.lblHistoryDiplay.Text = "There\'s no history yet ";
            // 
            // btnDlete
            // 
            this.btnDlete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDlete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDlete.Font = new System.Drawing.Font("Wingdings 2", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnDlete.Location = new System.Drawing.Point(618, 556);
            this.btnDlete.Name = "btnDlete";
            this.btnDlete.Size = new System.Drawing.Size(77, 30);
            this.btnDlete.TabIndex = 81;
            this.btnDlete.Text = "";
            this.btnDlete.UseVisualStyleBackColor = false;
            this.btnDlete.Click += new System.EventHandler(this.btnCLearHistory);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.Add(this.btnDlete);
            this.Controls.Add(this.lblHistoryDiplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbDisplayHistory);
            this.Controls.Add(this.labelShowOpt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRad);
            this.Controls.Add(this.btnPluMinus);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnXCube);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnXSquare);
            this.Controls.Add(this.btnDeg);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn_Equal);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnTanInverse);
            this.Controls.Add(this.btnCosInverse);
            this.Controls.Add(this.btnSinInverse);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnSPowerY);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSPowerY;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnSinInverse;
        private System.Windows.Forms.Button btnCosInverse;
        private System.Windows.Forms.Button btnTanInverse;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn_Equal;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnDeg;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnRad;
        private System.Windows.Forms.Button btnPluMinus;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnXCube;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnXSquare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelShowOpt;
        private System.Windows.Forms.RichTextBox rtbDisplayHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHistoryDiplay;
        private System.Windows.Forms.Button btnDlete;


    }
}