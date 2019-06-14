/*
 * Created by SharpDevelop.
 * User: Karim
 * Date: 24.09.2017
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calcutron
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.ComboBox comboBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(246, 208);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(81, 25);
			this.button1.TabIndex = 0;
			this.button1.Text = "Выполнить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(521, 208);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(81, 25);
			this.button2.TabIndex = 3;
			this.button2.Text = "Выполнить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Исходная СС";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Необходимая СС";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Введите число";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Location = new System.Drawing.Point(34, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(293, 59);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ответ :";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.textBox4.Location = new System.Drawing.Point(6, 27);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(281, 20);
			this.textBox4.TabIndex = 0;
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(34, 77);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(293, 125);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Параметры :";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(141, 91);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(133, 20);
			this.textBox3.TabIndex = 10;
			
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(141, 60);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(133, 20);
			this.textBox2.TabIndex = 9;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(141, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(133, 20);
			this.textBox1.TabIndex = 8;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(18, 57);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(73, 20);
			this.textBox5.TabIndex = 11;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(150, 57);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(73, 20);
			this.textBox6.TabIndex = 12;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.comboBox1);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.textBox8);
			this.groupBox3.Controls.Add(this.textBox5);
			this.groupBox3.Controls.Add(this.textBox6);
			this.groupBox3.Location = new System.Drawing.Point(333, 77);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(265, 125);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Параметры :";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(97, 57);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(47, 21);
			this.comboBox1.TabIndex = 17;
			this.comboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBox1KeyUp);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(150, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 17);
			this.label6.TabIndex = 16;
			this.label6.Text = "Y";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(18, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "X";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(74, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "Cистема Cчисления";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(189, 96);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(70, 20);
			this.textBox8.TabIndex = 13;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBox7);
			this.groupBox4.Location = new System.Drawing.Point(333, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(265, 59);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Ответ:";
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.textBox7.Location = new System.Drawing.Point(6, 27);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(253, 20);
			this.textBox7.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.ClientSize = new System.Drawing.Size(638, 241);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Calcutron";
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}
		}
		}
