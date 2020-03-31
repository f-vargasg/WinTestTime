namespace WinTestTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.txtTimeWait = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.processActivateBrgWrk = new System.ComponentModel.BackgroundWorker();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Wait";
            // 
            // txtOutPut
            // 
            this.txtOutPut.Location = new System.Drawing.Point(12, 118);
            this.txtOutPut.Multiline = true;
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(954, 312);
            this.txtOutPut.TabIndex = 1;
            // 
            // txtTimeWait
            // 
            this.txtTimeWait.Location = new System.Drawing.Point(99, 46);
            this.txtTimeWait.Name = "txtTimeWait";
            this.txtTimeWait.Size = new System.Drawing.Size(390, 26);
            this.txtTimeWait.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Results:";
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(562, 38);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(84, 48);
            this.butStart.TabIndex = 4;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // processActivateBrgWrk
            // 
            this.processActivateBrgWrk.WorkerReportsProgress = true;
            this.processActivateBrgWrk.WorkerSupportsCancellation = true;
            this.processActivateBrgWrk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ProcessActivateBrgWrk_DoWork);
            this.processActivateBrgWrk.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ProcessActivateBrgWrk_ProgressChanged);
            this.processActivateBrgWrk.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ProcessActivateBrgWrk_RunWorkerCompleted);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(720, 38);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(84, 48);
            this.butCancel.TabIndex = 5;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 431);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimeWait);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.TextBox txtTimeWait;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butStart;
        private System.ComponentModel.BackgroundWorker processActivateBrgWrk;
        private System.Windows.Forms.Button butCancel;
    }
}

