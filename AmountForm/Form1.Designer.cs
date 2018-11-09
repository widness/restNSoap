namespace AmountForm
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.charge = new System.Windows.Forms.Button();
			this.check = new System.Windows.Forms.Button();
			this.username = new System.Windows.Forms.Label();
			this.amount = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.AccessibleDescription = "";
			this.textBox1.AccessibleName = "";
			this.textBox1.Location = new System.Drawing.Point(240, 54);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(132, 146);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 1;
			// 
			// charge
			// 
			this.charge.Location = new System.Drawing.Point(143, 172);
			this.charge.Name = "charge";
			this.charge.Size = new System.Drawing.Size(75, 23);
			this.charge.TabIndex = 2;
			this.charge.Text = "Charger";
			this.charge.UseVisualStyleBackColor = true;
			this.charge.Click += new System.EventHandler(this.charge_Click);
			// 
			// check
			// 
			this.check.Location = new System.Drawing.Point(255, 80);
			this.check.Name = "check";
			this.check.Size = new System.Drawing.Size(75, 23);
			this.check.TabIndex = 3;
			this.check.Text = "verifier crédit";
			this.check.UseVisualStyleBackColor = true;
			this.check.Click += new System.EventHandler(this.check_Click);
			// 
			// username
			// 
			this.username.AutoSize = true;
			this.username.Location = new System.Drawing.Point(237, 38);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(84, 13);
			this.username.TabIndex = 4;
			this.username.Tag = "";
			this.username.Text = "Nom d\'utilisateur";
			// 
			// amount
			// 
			this.amount.AutoSize = true;
			this.amount.Location = new System.Drawing.Point(129, 130);
			this.amount.Name = "amount";
			this.amount.Size = new System.Drawing.Size(103, 13);
			this.amount.TabIndex = 5;
			this.amount.Text = "Montant a recharger";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "ID utilisateur";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(67, 54);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 7;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(30, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "connaitre votre nom d\'utilisateur";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 216);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.amount);
			this.Controls.Add(this.username);
			this.Controls.Add(this.check);
			this.Controls.Add(this.charge);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Recharge de credit";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button charge;
		private System.Windows.Forms.Button check;
		private System.Windows.Forms.Label username;
		private System.Windows.Forms.Label amount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button1;
	}
}

