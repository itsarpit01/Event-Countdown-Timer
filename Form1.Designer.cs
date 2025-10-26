namespace Event_handler_project
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
            this.components = new System.ComponentModel.Container();
            this.lblEventName = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.Location = new System.Drawing.Point(10, 10);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(80, 20);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "Event Name";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(100, 10);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(200, 22);
            this.txtEventName.TabIndex = 1;
            // 
            // lblEventDate
            // 
            this.lblEventDate.Location = new System.Drawing.Point(10, 40);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(180, 20);
            this.lblEventDate.TabIndex = 2;
            this.lblEventDate.Text = "Event Date";
            // 
            // txtEventDate
            // 
            this.txtEventDate.Location = new System.Drawing.Point(100, 40);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(200, 22);
            this.txtEventDate.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(10, 70);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 30);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Countdown";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCountdown
            // 
            this.lblCountdown.Location = new System.Drawing.Point(10, 110);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(150, 20);
            this.lblCountdown.TabIndex = 5;
            this.lblCountdown.Text = "Time remaining:";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Location = new System.Drawing.Point(120, 110);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(44, 16);
            this.lblTimeRemaining.TabIndex = 6;
            this.lblTimeRemaining.Text = "label1";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Event_handler_project.Properties.Resources._01fba3da34283bfbb626ad5372902d79;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtEventDate);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.lblEventName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Timer timer;
    }
}

