namespace testPTZ
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
            this.status = new System.Windows.Forms.TextBox();
            this.btnPanLeft = new System.Windows.Forms.Button();
            this.btnPanRight = new System.Windows.Forms.Button();
            this.btnTiltUp = new System.Windows.Forms.Button();
            this.btnTiltDown = new System.Windows.Forms.Button();
            this.cbCameras = new System.Windows.Forms.ComboBox();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(45, 539);
            this.status.Multiline = true;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(493, 132);
            this.status.TabIndex = 1;
            // 
            // btnPanLeft
            // 
            this.btnPanLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPanLeft.Location = new System.Drawing.Point(45, 251);
            this.btnPanLeft.Name = "btnPanLeft";
            this.btnPanLeft.Size = new System.Drawing.Size(151, 101);
            this.btnPanLeft.TabIndex = 2;
            this.btnPanLeft.Text = "← Left";
            this.btnPanLeft.UseVisualStyleBackColor = true;
            this.btnPanLeft.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnPanRight
            // 
            this.btnPanRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanRight.Location = new System.Drawing.Point(387, 251);
            this.btnPanRight.Name = "btnPanRight";
            this.btnPanRight.Size = new System.Drawing.Size(151, 101);
            this.btnPanRight.TabIndex = 3;
            this.btnPanRight.Text = "Right →";
            this.btnPanRight.UseVisualStyleBackColor = true;
            this.btnPanRight.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnTiltUp
            // 
            this.btnTiltUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTiltUp.Location = new System.Drawing.Point(220, 110);
            this.btnTiltUp.Name = "btnTiltUp";
            this.btnTiltUp.Size = new System.Drawing.Size(151, 101);
            this.btnTiltUp.TabIndex = 4;
            this.btnTiltUp.Text = "↑ UP ↑";
            this.btnTiltUp.UseVisualStyleBackColor = true;
            this.btnTiltUp.Click += new System.EventHandler(this.btnTilt_Click);
            // 
            // btnTiltDown
            // 
            this.btnTiltDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTiltDown.Location = new System.Drawing.Point(220, 408);
            this.btnTiltDown.Name = "btnTiltDown";
            this.btnTiltDown.Size = new System.Drawing.Size(151, 101);
            this.btnTiltDown.TabIndex = 5;
            this.btnTiltDown.Text = "↓ Down ↓";
            this.btnTiltDown.UseVisualStyleBackColor = true;
            this.btnTiltDown.Click += new System.EventHandler(this.btnTilt_Click);
            // 
            // cbCameras
            // 
            this.cbCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCameras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCameras.FormattingEnabled = true;
            this.cbCameras.Location = new System.Drawing.Point(180, 25);
            this.cbCameras.Name = "cbCameras";
            this.cbCameras.Size = new System.Drawing.Size(346, 28);
            this.cbCameras.TabIndex = 6;
            this.cbCameras.SelectedValueChanged += new System.EventHandler(this.OnChangeCamera);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnZoomOut.Location = new System.Drawing.Point(235, 322);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(120, 57);
            this.btnZoomOut.TabIndex = 7;
            this.btnZoomOut.Text = "o → OOO";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnZoomIn.Location = new System.Drawing.Point(235, 236);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(120, 57);
            this.btnZoomIn.TabIndex = 8;
            this.btnZoomIn.Text = "OOO → o";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Camera Device";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 696);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.cbCameras);
            this.Controls.Add(this.btnTiltDown);
            this.Controls.Add(this.btnTiltUp);
            this.Controls.Add(this.btnPanRight);
            this.Controls.Add(this.btnPanLeft);
            this.Controls.Add(this.status);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlueJeans Camera Control";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button btnPanLeft;
        private System.Windows.Forms.Button btnPanRight;
        private System.Windows.Forms.Button btnTiltUp;
        private System.Windows.Forms.Button btnTiltDown;
        private System.Windows.Forms.ComboBox cbCameras;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Label label1;
    }
}

