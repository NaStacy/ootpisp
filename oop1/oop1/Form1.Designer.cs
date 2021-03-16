
namespace oop1
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.pbLine = new System.Windows.Forms.PictureBox();
            this.pbBroken = new System.Windows.Forms.PictureBox();
            this.pbRectangle = new System.Windows.Forms.PictureBox();
            this.pbEllipse = new System.Windows.Forms.PictureBox();
            this.pbPolygon = new System.Windows.Forms.PictureBox();
            this.numUpDownThickness = new System.Windows.Forms.NumericUpDown();
            this.labelThickness = new System.Windows.Forms.Label();
            this.labelAngle = new System.Windows.Forms.Label();
            this.numUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.btnSer = new System.Windows.Forms.Button();
            this.btnDeser = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelColorP = new System.Windows.Forms.Label();
            this.labelColorF = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBroken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPolygon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(5, 522);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(168, 59);
            this.btn.TabIndex = 0;
            this.btn.Text = "generate figure";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(180, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(925, 578);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Red;
            this.btnColor.Location = new System.Drawing.Point(95, 114);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(50, 50);
            this.btnColor.TabIndex = 2;
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // pbLine
            // 
            this.pbLine.Image = ((System.Drawing.Image)(resources.GetObject("pbLine.Image")));
            this.pbLine.Location = new System.Drawing.Point(12, 3);
            this.pbLine.Name = "pbLine";
            this.pbLine.Size = new System.Drawing.Size(50, 50);
            this.pbLine.TabIndex = 3;
            this.pbLine.TabStop = false;
            // 
            // pbBroken
            // 
            this.pbBroken.Image = ((System.Drawing.Image)(resources.GetObject("pbBroken.Image")));
            this.pbBroken.Location = new System.Drawing.Point(68, 4);
            this.pbBroken.Name = "pbBroken";
            this.pbBroken.Size = new System.Drawing.Size(50, 50);
            this.pbBroken.TabIndex = 4;
            this.pbBroken.TabStop = false;
            // 
            // pbRectangle
            // 
            this.pbRectangle.Image = ((System.Drawing.Image)(resources.GetObject("pbRectangle.Image")));
            this.pbRectangle.Location = new System.Drawing.Point(124, 4);
            this.pbRectangle.Name = "pbRectangle";
            this.pbRectangle.Size = new System.Drawing.Size(50, 50);
            this.pbRectangle.TabIndex = 5;
            this.pbRectangle.TabStop = false;
            // 
            // pbEllipse
            // 
            this.pbEllipse.Image = ((System.Drawing.Image)(resources.GetObject("pbEllipse.Image")));
            this.pbEllipse.Location = new System.Drawing.Point(38, 58);
            this.pbEllipse.Name = "pbEllipse";
            this.pbEllipse.Size = new System.Drawing.Size(50, 50);
            this.pbEllipse.TabIndex = 6;
            this.pbEllipse.TabStop = false;
            // 
            // pbPolygon
            // 
            this.pbPolygon.Image = ((System.Drawing.Image)(resources.GetObject("pbPolygon.Image")));
            this.pbPolygon.Location = new System.Drawing.Point(95, 58);
            this.pbPolygon.Name = "pbPolygon";
            this.pbPolygon.Size = new System.Drawing.Size(50, 50);
            this.pbPolygon.TabIndex = 7;
            this.pbPolygon.TabStop = false;
            // 
            // numUpDownThickness
            // 
            this.numUpDownThickness.Location = new System.Drawing.Point(95, 227);
            this.numUpDownThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownThickness.Name = "numUpDownThickness";
            this.numUpDownThickness.Size = new System.Drawing.Size(78, 27);
            this.numUpDownThickness.TabIndex = 8;
            this.numUpDownThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Location = new System.Drawing.Point(12, 234);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(71, 20);
            this.labelThickness.TabIndex = 10;
            this.labelThickness.Text = "Thickness";
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(12, 271);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(54, 20);
            this.labelAngle.TabIndex = 11;
            this.labelAngle.Text = "Angles";
            // 
            // numUpDownAngle
            // 
            this.numUpDownAngle.Location = new System.Drawing.Point(95, 264);
            this.numUpDownAngle.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDownAngle.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUpDownAngle.Name = "numUpDownAngle";
            this.numUpDownAngle.Size = new System.Drawing.Size(78, 27);
            this.numUpDownAngle.TabIndex = 12;
            this.numUpDownAngle.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnSer
            // 
            this.btnSer.Location = new System.Drawing.Point(12, 297);
            this.btnSer.Name = "btnSer";
            this.btnSer.Size = new System.Drawing.Size(161, 32);
            this.btnSer.TabIndex = 13;
            this.btnSer.Text = "Serialization";
            this.btnSer.UseVisualStyleBackColor = true;
            // 
            // btnDeser
            // 
            this.btnDeser.Location = new System.Drawing.Point(12, 335);
            this.btnDeser.Name = "btnDeser";
            this.btnDeser.Size = new System.Drawing.Size(161, 32);
            this.btnDeser.TabIndex = 14;
            this.btnDeser.Text = "Deserialization";
            this.btnDeser.UseVisualStyleBackColor = true;
            // 
            // labelColorP
            // 
            this.labelColorP.AutoSize = true;
            this.labelColorP.Location = new System.Drawing.Point(12, 130);
            this.labelColorP.Name = "labelColorP";
            this.labelColorP.Size = new System.Drawing.Size(70, 20);
            this.labelColorP.TabIndex = 15;
            this.labelColorP.Text = "Pen color";
            // 
            // labelColorF
            // 
            this.labelColorF.AutoSize = true;
            this.labelColorF.Location = new System.Drawing.Point(12, 185);
            this.labelColorF.Name = "labelColorF";
            this.labelColorF.Size = new System.Drawing.Size(66, 20);
            this.labelColorF.TabIndex = 16;
            this.labelColorF.Text = "Fill color";
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.Gold;
            this.btnFill.Location = new System.Drawing.Point(95, 168);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(50, 50);
            this.btnFill.TabIndex = 17;
            this.btnFill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1117, 588);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.labelColorF);
            this.Controls.Add(this.labelColorP);
            this.Controls.Add(this.btnDeser);
            this.Controls.Add(this.btnSer);
            this.Controls.Add(this.numUpDownAngle);
            this.Controls.Add(this.labelAngle);
            this.Controls.Add(this.labelThickness);
            this.Controls.Add(this.numUpDownThickness);
            this.Controls.Add(this.pbPolygon);
            this.Controls.Add(this.pbEllipse);
            this.Controls.Add(this.pbRectangle);
            this.Controls.Add(this.pbBroken);
            this.Controls.Add(this.pbLine);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn);
            this.Name = "Form";
            this.Text = "geometric figures";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBroken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPolygon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox pbLine;
        private System.Windows.Forms.PictureBox pbBroken;
        private System.Windows.Forms.PictureBox pbRectangle;
        private System.Windows.Forms.PictureBox pbEllipse;
        private System.Windows.Forms.PictureBox pbPolygon;
        private System.Windows.Forms.NumericUpDown numUpDownThickness;
        private System.Windows.Forms.Label labelThickness;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.NumericUpDown numUpDownAngle;
        private System.Windows.Forms.Button btnSer;
        private System.Windows.Forms.Button btnDeser;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelColorP;
        private System.Windows.Forms.Label labelColorF;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

