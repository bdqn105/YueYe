namespace LogisPrj
{
    partial class FrmFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFee));
            this.btnRoadtoll = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoadtoll
            // 
            this.btnRoadtoll.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRoadtoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoadtoll.Location = new System.Drawing.Point(12, 12);
            this.btnRoadtoll.Name = "btnRoadtoll";
            this.btnRoadtoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoadtoll.TabIndex = 0;
            this.btnRoadtoll.Text = "过路费";
            this.btnRoadtoll.UseVisualStyleBackColor = false;
            this.btnRoadtoll.Click += new System.EventHandler(this.btnRoadtoll_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(93, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "加油费";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRoadtoll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFee";
            this.Text = "费用管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoadtoll;
        private System.Windows.Forms.Button button2;
    }
}