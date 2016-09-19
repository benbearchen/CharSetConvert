using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace CharSetConvert
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckedListBox CharSetList;
		private System.Windows.Forms.TextBox TheText;
		private System.Windows.Forms.ListView TextView;
		private System.Windows.Forms.Button ConvertBtn;
		private System.Windows.Forms.TextBox CharSetInputText;
		private System.Windows.Forms.Button AddCharSetBtn;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.TheText = new System.Windows.Forms.TextBox();
			this.CharSetList = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TextView = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.label3 = new System.Windows.Forms.Label();
			this.ConvertBtn = new System.Windows.Forms.Button();
			this.CharSetInputText = new System.Windows.Forms.TextBox();
			this.AddCharSetBtn = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TheText
			// 
			this.TheText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.TheText.Location = new System.Drawing.Point(56, 8);
			this.TheText.Name = "TheText";
			this.TheText.Size = new System.Drawing.Size(552, 21);
			this.TheText.TabIndex = 0;
			this.TheText.Text = "textBox1";
			// 
			// CharSetList
			// 
			this.CharSetList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.CharSetList.CheckOnClick = true;
			this.CharSetList.IntegralHeight = false;
			this.CharSetList.Items.AddRange(new object[] {
															 "UTF-8",
															 "gb2312",
															 "iso8859-1"});
			this.CharSetList.Location = new System.Drawing.Point(8, 56);
			this.CharSetList.Name = "CharSetList";
			this.CharSetList.Size = new System.Drawing.Size(128, 240);
			this.CharSetList.TabIndex = 1;
			this.CharSetList.ThreeDCheckBoxes = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "编码";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "文字";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TextView
			// 
			this.TextView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.TextView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.columnHeader1,
																					   this.columnHeader2,
																					   this.columnHeader3});
			this.TextView.GridLines = true;
			this.TextView.Location = new System.Drawing.Point(144, 56);
			this.TextView.MultiSelect = false;
			this.TextView.Name = "TextView";
			this.TextView.Size = new System.Drawing.Size(560, 272);
			this.TextView.TabIndex = 4;
			this.TextView.View = System.Windows.Forms.View.Details;
			this.TextView.ItemActivate += new System.EventHandler(this.TextView_ItemActivate);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "步骤";
			this.columnHeader1.Width = 102;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "文字";
			this.columnHeader2.Width = 171;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "二进制";
			this.columnHeader3.Width = 258;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(144, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "转换结果";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// ConvertBtn
			// 
			this.ConvertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ConvertBtn.Location = new System.Drawing.Point(624, 8);
			this.ConvertBtn.Name = "ConvertBtn";
			this.ConvertBtn.TabIndex = 5;
			this.ConvertBtn.Text = "转换";
			this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
			// 
			// CharSetInputText
			// 
			this.CharSetInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CharSetInputText.Location = new System.Drawing.Point(40, 304);
			this.CharSetInputText.Name = "CharSetInputText";
			this.CharSetInputText.Size = new System.Drawing.Size(96, 21);
			this.CharSetInputText.TabIndex = 6;
			this.CharSetInputText.Text = "textBox1";
			// 
			// AddCharSetBtn
			// 
			this.AddCharSetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddCharSetBtn.Location = new System.Drawing.Point(8, 304);
			this.AddCharSetBtn.Name = "AddCharSetBtn";
			this.AddCharSetBtn.Size = new System.Drawing.Size(24, 23);
			this.AddCharSetBtn.TabIndex = 7;
			this.AddCharSetBtn.Text = "+";
			this.AddCharSetBtn.Click += new System.EventHandler(this.AddCharSetBtn_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(688, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(8, 8);
			this.button1.TabIndex = 8;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(712, 333);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.AddCharSetBtn);
			this.Controls.Add(this.CharSetInputText);
			this.Controls.Add(this.ConvertBtn);
			this.Controls.Add(this.TextView);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CharSetList);
			this.Controls.Add(this.TheText);
			this.Controls.Add(this.label3);
			this.Name = "Form1";
			this.Text = "文字编码转换器";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void ConvertBtn_Click(object sender, System.EventArgs e)
		{
			if (TheText.Text.Length == 0)
			{
				MessageBox.Show("请输入字符串");
				return;
			}
			if (CharSetList.CheckedItems.Count == 0)
			{
				MessageBox.Show("请选择编码");
				return;
			}
			
			TextView.Items.Clear();
			Encoding[] codes = new Encoding[CharSetList.CheckedItems.Count];
			for (int i = 0; i < CharSetList.CheckedItems.Count; ++i)
				codes[i] = Encoding.GetEncoding((string)CharSetList.CheckedItems[i]);

			if (TheText.Text[0] != '%')
			{
				Add("不转换", TheText.Text);
				for (int i = 0; i < codes.Length; ++i)
					for (int j = 0; j < codes.Length; ++j)
					{
						if (i == j)
							continue;

						Add(codes[i].EncodingName + "->" + codes[j].EncodingName, Convert(codes[i], codes[j], TheText.Text));
						ConvertAdd(codes[i], codes[j], TheText.Text);
					}
			}
			else
			{
				byte[] bytes = StringToByteArray(TheText.Text);
				for (int i = 0; i < codes.Length; ++i)
				{
					Add(codes[i].EncodingName, codes[i].GetString(bytes));
				}
			}
		}

		public static string Convert(Encoding a, Encoding b, string str)
		{
			return b.GetString(a.GetBytes(str));
		}
		public static byte[] Convert(Encoding a, Encoding b, byte[] bytes)
		{
			return b.GetBytes(a.GetString(bytes));
		}

		private void ConvertAdd(Encoding a, Encoding b, string str)
		{
			byte[] bytes = a.GetBytes(str);
			string str2 = b.GetString(bytes);

			ListViewItem Item = TextView.Items.Add("BIN: " + a.EncodingName + "->" + b.EncodingName);
			Item.SubItems.Add(str2);
			Item.SubItems.Add(ByteArrayToString(bytes));
		}

		private void Add(string Name, string Str)
		{
			ListViewItem Item = TextView.Items.Add(Name);
			Item.SubItems.Add(Str);
			Item.SubItems.Add(ByteArrayToString(Encoding.Unicode.GetBytes(Str)));
		}
		public static string ByteArrayToString(byte[] bytes)
		{
			string str = "";
			for (int i = 0; i < bytes.Length; ++i)
				str += "%" + bytes[i].ToString("X2");
			return str;
		}
		public static byte[] StringToByteArray(string str)
		{
			byte[] bytes = new byte[str.Length];
			int Count = 0;
			for (int i = 0; i < bytes.Length; ++i)
			{
				try
				{
					char ch = str[i];
					if (ch != '%')
						bytes[Count] = (byte)ch;
					else
					{
						char ch2 = str[++i];
						if (ch2 == '%')
							bytes[Count] = (byte)ch2;
						else
						{
							char ch3 = str[++i];
							bytes[Count] = System.Convert.ToByte(new string(new char[2]{ch2, ch3}), 16);
						}
					}
					Count++;
				}
				catch (Exception)
				{
				}
			}
			return bytes;
		}

		private void AddCharSetBtn_Click(object sender, System.EventArgs e)
		{
			if (CharSetInputText.Text.Length == 0)
			{
				MessageBox.Show("请输入编码的名字");
				return;
			}
			CharSetList.Items.Add(CharSetInputText.Text, true);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				char[] chs = TheText.Text.ToCharArray();
				if ((chs.Length > 0) && (chs.Length % 4 == 0) 
					&& (chs[0] == '\\') && (chs[1] == 'x'))
				{
					char[] t = new char[chs.Length / 4];
					for (int i = 0; i < t.Length; ++i)
						t[i] = (char)System.Convert.ToByte(new string(chs, i * 4 + 2, 2), 16);
					TheText.Text = new string(t);
					return;
				}

				for (int i = 0; i < chs.Length; ++i)
				{
					ushort ch = chs[i];
					chs[i] = (char)((ch & 0xE1) | (0x1E - (ch & 0x1E)));
				}
				//MessageBox.Show(new string(chs));
				TheText.Text = new string(chs);
				TextView.Items.Clear();
				string splash = "";
				for (int i = 0; i < chs.Length; ++i)
				{
					splash += "\\x" + ((ushort)chs[i]).ToString("X2");
				}
				TextView.Items.Add(TheText.Text).SubItems.Add(splash);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void TextView_ItemActivate(object sender, System.EventArgs e)
		{
			try
			{
				if (TextView.SelectedItems.Count != 1)
				{
					MessageBox.Show("元素激活的时候只应有一行元素被选中");
					return;
				}
				ListViewItem Item = TextView.SelectedItems[0];
				Clipboard.SetDataObject(Item.SubItems[1].Text, true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
