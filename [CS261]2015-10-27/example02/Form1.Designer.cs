﻿namespace Example02
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.guy1GiveButton = new System.Windows.Forms.Button();
            this.guy2GiveButton = new System.Windows.Forms.Button();
            this.guy1Name = new System.Windows.Forms.Label();
            this.guy1Cash = new System.Windows.Forms.Label();
            this.guy2Name = new System.Windows.Forms.Label();
            this.guy2Cash = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guy1GiveButton
            // 
            this.guy1GiveButton.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guy1GiveButton.Location = new System.Drawing.Point(23, 193);
            this.guy1GiveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guy1GiveButton.Name = "guy1GiveButton";
            this.guy1GiveButton.Size = new System.Drawing.Size(159, 81);
            this.guy1GiveButton.TabIndex = 0;
            this.guy1GiveButton.Text = "Guy1 give guy2 600";
            this.guy1GiveButton.UseVisualStyleBackColor = true;
            this.guy1GiveButton.Click += new System.EventHandler(this.guy1GiveButton_Click);
            // 
            // guy2GiveButton
            // 
            this.guy2GiveButton.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guy2GiveButton.Location = new System.Drawing.Point(210, 193);
            this.guy2GiveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guy2GiveButton.Name = "guy2GiveButton";
            this.guy2GiveButton.Size = new System.Drawing.Size(159, 81);
            this.guy2GiveButton.TabIndex = 1;
            this.guy2GiveButton.Text = "Guy2 give guy1 1200";
            this.guy2GiveButton.UseVisualStyleBackColor = true;
            this.guy2GiveButton.Click += new System.EventHandler(this.guy2GiveButton_Click);
            // 
            // guy1Name
            // 
            this.guy1Name.AutoSize = true;
            this.guy1Name.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guy1Name.Location = new System.Drawing.Point(19, 20);
            this.guy1Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guy1Name.Name = "guy1Name";
            this.guy1Name.Size = new System.Drawing.Size(120, 24);
            this.guy1Name.TabIndex = 2;
            this.guy1Name.Text = "Guy1 Name:";
            // 
            // guy1Cash
            // 
            this.guy1Cash.AutoSize = true;
            this.guy1Cash.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guy1Cash.Location = new System.Drawing.Point(19, 55);
            this.guy1Cash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guy1Cash.Name = "guy1Cash";
            this.guy1Cash.Size = new System.Drawing.Size(110, 24);
            this.guy1Cash.TabIndex = 3;
            this.guy1Cash.Text = "Guy1 Cash:";
            // 
            // guy2Name
            // 
            this.guy2Name.AutoSize = true;
            this.guy2Name.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guy2Name.Location = new System.Drawing.Point(206, 20);
            this.guy2Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guy2Name.Name = "guy2Name";
            this.guy2Name.Size = new System.Drawing.Size(120, 24);
            this.guy2Name.TabIndex = 4;
            this.guy2Name.Text = "Guy2 Name:";
            // 
            // guy2Cash
            // 
            this.guy2Cash.AutoSize = true;
            this.guy2Cash.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guy2Cash.Location = new System.Drawing.Point(206, 55);
            this.guy2Cash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guy2Cash.Name = "guy2Cash";
            this.guy2Cash.Size = new System.Drawing.Size(110, 24);
            this.guy2Cash.TabIndex = 5;
            this.guy2Cash.Text = "Guy2 Cash:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guy2Cash);
            this.Controls.Add(this.guy2Name);
            this.Controls.Add(this.guy1Cash);
            this.Controls.Add(this.guy1Name);
            this.Controls.Add(this.guy2GiveButton);
            this.Controls.Add(this.guy1GiveButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guy1GiveButton;
        private System.Windows.Forms.Button guy2GiveButton;
        private System.Windows.Forms.Label guy1Name;
        private System.Windows.Forms.Label guy1Cash;
        private System.Windows.Forms.Label guy2Name;
        private System.Windows.Forms.Label guy2Cash;
        private System.Windows.Forms.Button button1;
    }
}

