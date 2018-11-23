using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LoginApp
{
	/// <summary>
	/// Form2 的摘要说明。
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.TextBox txtUserName;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(169, 134);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(72, 24);
			this.btnOk.TabIndex = 11;
			this.btnOk.Text = "OK";
			this.btnOk.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(32, 134);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(72, 24);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(104, 80);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = '*';
			this.txtPwd.Size = new System.Drawing.Size(152, 21);
			this.txtPwd.TabIndex = 1;
			this.txtPwd.Text = "";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(104, 24);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(152, 21);
			this.txtUserName.TabIndex = 0;
			this.txtUserName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 28);
			this.label2.TabIndex = 7;
			this.label2.Text = "密码：";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 28);
			this.label1.TabIndex = 6;
			this.label1.Text = "用户名：";
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(282, 183);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnOk,
																		  this.btnCancel,
																		  this.txtPwd,
																		  this.txtUserName,
																		  this.label2,
																		  this.label1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.ShowInTaskbar = false;
			this.Text = "登录";
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			Form1 theOwner = (Form1)this.Owner ;	//获得对主窗口的引用
			if (txtUserName.Text != theOwner.strUserName )
			{
				MessageBox.Show ("错误的用户名！请重试","登录");
				txtUserName.Focus ();
				txtUserName.Text = "";
			}
			else if (txtPwd.Text != theOwner.strPassWord )
			{
				MessageBox.Show ("错误密码！请重试","登录");
				txtPwd.Focus ();
				txtPwd.Text = "";
			}
			else	//用户名和密码正确，关闭模式对话框
			{
				this.DialogResult = DialogResult.OK ;
			}			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Application.Exit ();
		}
	}
}
