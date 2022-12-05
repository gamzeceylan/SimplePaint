
namespace SimplePaint
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
            this.hexagon = new System.Windows.Forms.PictureBox();
            this.triangle = new System.Windows.Forms.PictureBox();
            this.rectangle = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.circle = new System.Windows.Forms.PictureBox();
            this.burgundy = new System.Windows.Forms.PictureBox();
            this.white = new System.Windows.Forms.PictureBox();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.black = new System.Windows.Forms.PictureBox();
            this.shapeGrpbx = new System.Windows.Forms.GroupBox();
            this.newPageBtn = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.PictureBox();
            this.chooseBtn = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.purple = new System.Windows.Forms.PictureBox();
            this.orange = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.importBtn = new System.Windows.Forms.PictureBox();
            this.exportBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drawingArea = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.hexagon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgundy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.white)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            this.shapeGrpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPageBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hexagon
            // 
            this.hexagon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexagon.BackColor = System.Drawing.Color.White;
            this.hexagon.Image = global::SimplePaint.Properties.Resources.hexagon;
            this.hexagon.Location = new System.Drawing.Point(105, 91);
            this.hexagon.Name = "hexagon";
            this.hexagon.Size = new System.Drawing.Size(69, 59);
            this.hexagon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hexagon.TabIndex = 3;
            this.hexagon.TabStop = false;
            this.hexagon.Click += new System.EventHandler(this.hexagon_Click);
            // 
            // triangle
            // 
            this.triangle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.triangle.BackColor = System.Drawing.Color.White;
            this.triangle.Image = global::SimplePaint.Properties.Resources.triangle;
            this.triangle.Location = new System.Drawing.Point(17, 91);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(69, 59);
            this.triangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.triangle.TabIndex = 2;
            this.triangle.TabStop = false;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // rectangle
            // 
            this.rectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangle.BackColor = System.Drawing.Color.White;
            this.rectangle.Image = global::SimplePaint.Properties.Resources.rectangle;
            this.rectangle.Location = new System.Drawing.Point(17, 26);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(69, 59);
            this.rectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rectangle.TabIndex = 0;
            this.rectangle.TabStop = false;
            this.rectangle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangle_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.hexagon);
            this.groupBox1.Controls.Add(this.triangle);
            this.groupBox1.Controls.Add(this.circle);
            this.groupBox1.Controls.Add(this.rectangle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çizim Şekli";
            // 
            // circle
            // 
            this.circle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circle.BackColor = System.Drawing.Color.White;
            this.circle.Image = global::SimplePaint.Properties.Resources.circle;
            this.circle.Location = new System.Drawing.Point(105, 26);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(69, 59);
            this.circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circle.TabIndex = 1;
            this.circle.TabStop = false;
            this.circle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.circle_MouseClick);
            // 
            // burgundy
            // 
            this.burgundy.BackColor = System.Drawing.Color.Maroon;
            this.burgundy.Location = new System.Drawing.Point(81, 122);
            this.burgundy.Name = "burgundy";
            this.burgundy.Size = new System.Drawing.Size(43, 42);
            this.burgundy.TabIndex = 8;
            this.burgundy.TabStop = false;
            this.burgundy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.burgundy_MouseClick);
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.Location = new System.Drawing.Point(130, 122);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(43, 42);
            this.white.TabIndex = 7;
            this.white.TabStop = false;
            this.white.MouseClick += new System.Windows.Forms.MouseEventHandler(this.white_MouseClick);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(130, 74);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(43, 42);
            this.yellow.TabIndex = 6;
            this.yellow.TabStop = false;
            this.yellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.yellow_MouseClick);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(81, 74);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(43, 42);
            this.black.TabIndex = 5;
            this.black.TabStop = false;
            this.black.MouseClick += new System.Windows.Forms.MouseEventHandler(this.black_MouseClick);
            // 
            // shapeGrpbx
            // 
            this.shapeGrpbx.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shapeGrpbx.Controls.Add(this.newPageBtn);
            this.shapeGrpbx.Controls.Add(this.deleteBtn);
            this.shapeGrpbx.Controls.Add(this.chooseBtn);
            this.shapeGrpbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.shapeGrpbx.Location = new System.Drawing.Point(0, 355);
            this.shapeGrpbx.Name = "shapeGrpbx";
            this.shapeGrpbx.Size = new System.Drawing.Size(198, 107);
            this.shapeGrpbx.TabIndex = 2;
            this.shapeGrpbx.TabStop = false;
            this.shapeGrpbx.Text = "Şekil İşlemleri";
            // 
            // newPageBtn
            // 
            this.newPageBtn.Image = global::SimplePaint.Properties.Resources.newPage;
            this.newPageBtn.Location = new System.Drawing.Point(143, 36);
            this.newPageBtn.Name = "newPageBtn";
            this.newPageBtn.Size = new System.Drawing.Size(44, 52);
            this.newPageBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newPageBtn.TabIndex = 2;
            this.newPageBtn.TabStop = false;
            this.newPageBtn.Click += new System.EventHandler(this.newPageBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Image = global::SimplePaint.Properties.Resources.trash;
            this.deleteBtn.Location = new System.Drawing.Point(82, 36);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(55, 52);
            this.deleteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.TabStop = false;
            this.deleteBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deleteBtn_MouseClick);
            // 
            // chooseBtn
            // 
            this.chooseBtn.Image = global::SimplePaint.Properties.Resources.hand;
            this.chooseBtn.Location = new System.Drawing.Point(19, 36);
            this.chooseBtn.Name = "chooseBtn";
            this.chooseBtn.Size = new System.Drawing.Size(54, 52);
            this.chooseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chooseBtn.TabIndex = 0;
            this.chooseBtn.TabStop = false;
            this.chooseBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseBtn_MouseClick);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.Location = new System.Drawing.Point(130, 26);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(43, 42);
            this.green.TabIndex = 4;
            this.green.TabStop = false;
            this.green.MouseClick += new System.Windows.Forms.MouseEventHandler(this.green_MouseClick);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.Location = new System.Drawing.Point(81, 26);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(43, 42);
            this.blue.TabIndex = 3;
            this.blue.TabStop = false;
            this.blue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.blue_MouseClick);
            // 
            // purple
            // 
            this.purple.BackColor = System.Drawing.Color.Purple;
            this.purple.Location = new System.Drawing.Point(29, 122);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(43, 42);
            this.purple.TabIndex = 2;
            this.purple.TabStop = false;
            this.purple.MouseClick += new System.Windows.Forms.MouseEventHandler(this.purple_MouseClick);
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orange.Location = new System.Drawing.Point(29, 74);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(43, 42);
            this.orange.TabIndex = 1;
            this.orange.TabStop = false;
            this.orange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.orange_MouseClick);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(29, 26);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(43, 42);
            this.red.TabIndex = 0;
            this.red.TabStop = false;
            this.red.MouseClick += new System.Windows.Forms.MouseEventHandler(this.red_MouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.importBtn);
            this.groupBox4.Controls.Add(this.exportBtn);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 462);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 114);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dosya İşlemleri";
            // 
            // importBtn
            // 
            this.importBtn.Image = global::SimplePaint.Properties.Resources.import;
            this.importBtn.Location = new System.Drawing.Point(18, 26);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(55, 52);
            this.importBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.importBtn.TabIndex = 2;
            this.importBtn.TabStop = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Image = global::SimplePaint.Properties.Resources.export;
            this.exportBtn.Location = new System.Drawing.Point(82, 26);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(55, 52);
            this.exportBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exportBtn.TabIndex = 1;
            this.exportBtn.TabStop = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.errorLbl);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.shapeGrpbx);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1023, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 803);
            this.panel2.TabIndex = 0;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLbl.Location = new System.Drawing.Point(6, 599);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(50, 20);
            this.errorLbl.TabIndex = 5;
            this.errorLbl.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.burgundy);
            this.groupBox2.Controls.Add(this.white);
            this.groupBox2.Controls.Add(this.yellow);
            this.groupBox2.Controls.Add(this.black);
            this.groupBox2.Controls.Add(this.green);
            this.groupBox2.Controls.Add(this.blue);
            this.groupBox2.Controls.Add(this.purple);
            this.groupBox2.Controls.Add(this.orange);
            this.groupBox2.Controls.Add(this.red);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 185);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renk Seçimi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.drawingArea);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 805);
            this.panel1.TabIndex = 1;
            // 
            // drawingArea
            // 
            this.drawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingArea.ForeColor = System.Drawing.Color.Transparent;
            this.drawingArea.Location = new System.Drawing.Point(0, 0);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(1023, 803);
            this.drawingArea.TabIndex = 1;
            this.drawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseDown);
            this.drawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseMove);
            this.drawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 805);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hexagon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgundy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.white)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).EndInit();
            this.shapeGrpbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newPageBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.importBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hexagon;
        private System.Windows.Forms.PictureBox triangle;
        private System.Windows.Forms.PictureBox rectangle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox circle;
        private System.Windows.Forms.PictureBox burgundy;
        private System.Windows.Forms.PictureBox white;
        private System.Windows.Forms.PictureBox yellow;
        private System.Windows.Forms.PictureBox black;
        private System.Windows.Forms.GroupBox shapeGrpbx;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.PictureBox purple;
        private System.Windows.Forms.PictureBox orange;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel drawingArea;
        private System.Windows.Forms.PictureBox newPageBtn;
        private System.Windows.Forms.PictureBox deleteBtn;
        private System.Windows.Forms.PictureBox chooseBtn;
        private System.Windows.Forms.PictureBox importBtn;
        private System.Windows.Forms.PictureBox exportBtn;
        private System.Windows.Forms.Label errorLbl;
    }
}

