using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
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
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckedListBox CharSetList;
		private System.Windows.Forms.TextBox TheText;
        private System.Windows.Forms.ListView TextView;
		private System.Windows.Forms.TextBox CharSetInputText;
        private System.Windows.Forms.Button AddCharSetBtn;
        private Button TreeBuildBtn;
        private TreeView ResultTV;
        private ContextMenuStrip TreeAppendMenu;
        private ToolStripMenuItem CopyContentMi;
        private ToolStripSeparator CharSetMi;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem DeleteNodeMi;
        private ToolStripMenuItem LookPathMi;
        private TabControl ResultTabControl;
        private TabPage TreeTabPage;
        private TabPage ListTabPage;
        private Label label4;
        private CheckBox PercentSignChk;
        private CheckBox Base64Chk;
        private IContainer components;

		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
            AppendCharSet("UTF-8", true);
            AppendCharSet("Unicode", false);
            AppendCharSet("gb2312", true);
            AppendCharSet("big5", false);
            AppendCharSet("iso8859-1", false);

            //CharSetMi;
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
            this.components = new System.ComponentModel.Container();
            this.TheText = new System.Windows.Forms.TextBox();
            this.CharSetList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextView = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.CharSetInputText = new System.Windows.Forms.TextBox();
            this.AddCharSetBtn = new System.Windows.Forms.Button();
            this.TreeBuildBtn = new System.Windows.Forms.Button();
            this.ResultTV = new System.Windows.Forms.TreeView();
            this.TreeAppendMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyContentMi = new System.Windows.Forms.ToolStripMenuItem();
            this.LookPathMi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteNodeMi = new System.Windows.Forms.ToolStripMenuItem();
            this.CharSetMi = new System.Windows.Forms.ToolStripSeparator();
            this.ResultTabControl = new System.Windows.Forms.TabControl();
            this.TreeTabPage = new System.Windows.Forms.TabPage();
            this.ListTabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.PercentSignChk = new System.Windows.Forms.CheckBox();
            this.Base64Chk = new System.Windows.Forms.CheckBox();
            this.TreeAppendMenu.SuspendLayout();
            this.ResultTabControl.SuspendLayout();
            this.TreeTabPage.SuspendLayout();
            this.ListTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TheText
            // 
            this.TheText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TheText.Location = new System.Drawing.Point(165, 28);
            this.TheText.Multiline = true;
            this.TheText.Name = "TheText";
            this.TheText.Size = new System.Drawing.Size(535, 37);
            this.TheText.TabIndex = 0;
            this.TheText.Text = "在这里输入要转换的文字";
            // 
            // CharSetList
            // 
            this.CharSetList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.CharSetList.CheckOnClick = true;
            this.CharSetList.IntegralHeight = false;
            this.CharSetList.Location = new System.Drawing.Point(12, 28);
            this.CharSetList.Name = "CharSetList";
            this.CharSetList.Size = new System.Drawing.Size(147, 264);
            this.CharSetList.TabIndex = 1;
            this.CharSetList.ThreeDCheckBoxes = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "编码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(163, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "文字";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextView
            // 
            this.TextView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.TextView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextView.GridLines = true;
            this.TextView.Location = new System.Drawing.Point(3, 3);
            this.TextView.MultiSelect = false;
            this.TextView.Name = "TextView";
            this.TextView.Size = new System.Drawing.Size(521, 190);
            this.TextView.TabIndex = 4;
            this.TextView.UseCompatibleStateImageBehavior = false;
            this.TextView.View = System.Windows.Forms.View.Details;
            this.TextView.ItemActivate += new System.EventHandler(this.TextView_ItemActivate);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "文字";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "路径";
            this.columnHeader3.Width = 200;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(163, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "转换结果";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CharSetInputText
            // 
            this.CharSetInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CharSetInputText.Location = new System.Drawing.Point(42, 300);
            this.CharSetInputText.Name = "CharSetInputText";
            this.CharSetInputText.Size = new System.Drawing.Size(117, 21);
            this.CharSetInputText.TabIndex = 6;
            this.CharSetInputText.Text = "GBK";
            // 
            // AddCharSetBtn
            // 
            this.AddCharSetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddCharSetBtn.Location = new System.Drawing.Point(12, 298);
            this.AddCharSetBtn.Name = "AddCharSetBtn";
            this.AddCharSetBtn.Size = new System.Drawing.Size(24, 23);
            this.AddCharSetBtn.TabIndex = 7;
            this.AddCharSetBtn.Text = "+";
            this.AddCharSetBtn.Click += new System.EventHandler(this.AddCharSetBtn_Click);
            // 
            // TreeBuildBtn
            // 
            this.TreeBuildBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeBuildBtn.Location = new System.Drawing.Point(576, 71);
            this.TreeBuildBtn.Name = "TreeBuildBtn";
            this.TreeBuildBtn.Size = new System.Drawing.Size(124, 23);
            this.TreeBuildBtn.TabIndex = 9;
            this.TreeBuildBtn.Text = "自动构造转换树";
            this.TreeBuildBtn.UseVisualStyleBackColor = true;
            this.TreeBuildBtn.Click += new System.EventHandler(this.TreeBuildBtn_Click);
            // 
            // ResultTV
            // 
            this.ResultTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTV.Location = new System.Drawing.Point(3, 3);
            this.ResultTV.Name = "ResultTV";
            this.ResultTV.PathSeparator = "/";
            this.ResultTV.Size = new System.Drawing.Size(521, 190);
            this.ResultTV.TabIndex = 10;
            this.ResultTV.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ResultTV_NodeMouseClick);
            // 
            // TreeAppendMenu
            // 
            this.TreeAppendMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyContentMi,
            this.LookPathMi,
            this.toolStripMenuItem1,
            this.DeleteNodeMi,
            this.CharSetMi});
            this.TreeAppendMenu.Name = "TreeAppendMenu";
            this.TreeAppendMenu.Size = new System.Drawing.Size(119, 82);
            // 
            // CopyContentMi
            // 
            this.CopyContentMi.Name = "CopyContentMi";
            this.CopyContentMi.Size = new System.Drawing.Size(118, 22);
            this.CopyContentMi.Text = "复制内容";
            this.CopyContentMi.Click += new System.EventHandler(this.CopyContentMi_Click);
            // 
            // LookPathMi
            // 
            this.LookPathMi.Name = "LookPathMi";
            this.LookPathMi.Size = new System.Drawing.Size(118, 22);
            this.LookPathMi.Text = "查看路径";
            this.LookPathMi.Click += new System.EventHandler(this.LookPathMi_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
            // 
            // DeleteNodeMi
            // 
            this.DeleteNodeMi.Name = "DeleteNodeMi";
            this.DeleteNodeMi.Size = new System.Drawing.Size(118, 22);
            this.DeleteNodeMi.Text = "删除结点";
            this.DeleteNodeMi.Click += new System.EventHandler(this.DeleteNodeMi_Click);
            // 
            // CharSetMi
            // 
            this.CharSetMi.Name = "CharSetMi";
            this.CharSetMi.Size = new System.Drawing.Size(115, 6);
            // 
            // ResultTabControl
            // 
            this.ResultTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTabControl.Controls.Add(this.TreeTabPage);
            this.ResultTabControl.Controls.Add(this.ListTabPage);
            this.ResultTabControl.Location = new System.Drawing.Point(165, 100);
            this.ResultTabControl.Name = "ResultTabControl";
            this.ResultTabControl.SelectedIndex = 0;
            this.ResultTabControl.Size = new System.Drawing.Size(535, 221);
            this.ResultTabControl.TabIndex = 11;
            // 
            // TreeTabPage
            // 
            this.TreeTabPage.Controls.Add(this.ResultTV);
            this.TreeTabPage.Location = new System.Drawing.Point(4, 21);
            this.TreeTabPage.Name = "TreeTabPage";
            this.TreeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TreeTabPage.Size = new System.Drawing.Size(527, 196);
            this.TreeTabPage.TabIndex = 0;
            this.TreeTabPage.Text = "树型转换";
            this.TreeTabPage.UseVisualStyleBackColor = true;
            // 
            // ListTabPage
            // 
            this.ListTabPage.Controls.Add(this.TextView);
            this.ListTabPage.Location = new System.Drawing.Point(4, 21);
            this.ListTabPage.Name = "ListTabPage";
            this.ListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ListTabPage.Size = new System.Drawing.Size(527, 196);
            this.ListTabPage.TabIndex = 1;
            this.ListTabPage.Text = "列表查看";
            this.ListTabPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(243, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(457, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "输入文字(或“%xx”表示的字节序列)后，点击“自动构造转换树”可开始转换。";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PercentSignChk
            // 
            this.PercentSignChk.AutoSize = true;
            this.PercentSignChk.Location = new System.Drawing.Point(468, 75);
            this.PercentSignChk.Name = "PercentSignChk";
            this.PercentSignChk.Size = new System.Drawing.Size(102, 16);
            this.PercentSignChk.TabIndex = 12;
            this.PercentSignChk.Text = "取消 %xx 转换";
            this.PercentSignChk.UseVisualStyleBackColor = true;
            // 
            // Base64Chk
            // 
            this.Base64Chk.AutoSize = true;
            this.Base64Chk.Location = new System.Drawing.Point(402, 75);
            this.Base64Chk.Name = "Base64Chk";
            this.Base64Chk.Size = new System.Drawing.Size(60, 16);
            this.Base64Chk.TabIndex = 13;
            this.Base64Chk.Text = "BASE64";
            this.Base64Chk.UseVisualStyleBackColor = true;
            this.Base64Chk.CheckedChanged += new System.EventHandler(this.Base64Chk_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(712, 333);
            this.Controls.Add(this.ResultTabControl);
            this.Controls.Add(this.Base64Chk);
            this.Controls.Add(this.AddCharSetBtn);
            this.Controls.Add(this.PercentSignChk);
            this.Controls.Add(this.TreeBuildBtn);
            this.Controls.Add(this.CharSetInputText);
            this.Controls.Add(this.CharSetList);
            this.Controls.Add(this.TheText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "Form1";
            this.Text = "文字编码转换器";
            this.TreeAppendMenu.ResumeLayout(false);
            this.ResultTabControl.ResumeLayout(false);
            this.TreeTabPage.ResumeLayout(false);
            this.ListTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

        #region 十六进制字符操作
        /// <summary>
        /// 判断一个字符是否是十六进制字符
        /// </summary>
        private static bool IsHexDigit(char ch)
        {
            return Char.IsLetterOrDigit(ch) && (Char.ToUpper(ch) <= 'F');
        }

        /// <summary>
        /// 返回十六进制字符的实际数值
        /// </summary>
        /// <param name="ch">十六进制字符</param>
        /// <returns>实际数值</returns>
        /// <exception cref="ArgumentException">非十六进制字符时抛出</exception>
        private static int HexToDigit(char ch)
        {
            if (!IsHexDigit(ch))
                throw new ArgumentException("char 不是有效的十六进制字符", "ch");

            if (Char.IsDigit(ch))
                return ch - '0';
            else
                return Char.ToUpper(ch) - 'A' + 10;
        }

        /// <summary>
        /// 数值到十六进制转换的字符数组
        /// </summary>
        private static readonly char[] hex = { '0', '1', '2', '3', 
                                               '4', '5', '6', '7', 
                                               '8', '9', 'A', 'B', 
                                               'C', 'D', 'E', 'F' };
        /// <summary>
        /// 将数值转换成十六进制字符
        /// </summary>
        /// <param name="digit">数值</param>
        /// <returns>十六进制字符</returns>
        private static char DigitToHex(int digit)
        {
            return hex[digit & 0xF];
        }
        #endregion

        #region 字节序列与 %xx 字符串的转换及相关操作
        /// <summary>
        /// 将字节序列转换成 %xx 形式的字符串
        /// </summary>
        /// <param name="bytes">字节序列</param>
        /// <returns>%xx 字符串</returns>
		public static string ByteArrayToString(byte[] bytes)
		{
			StringBuilder str = new StringBuilder(bytes.Length * 3);
            for (int i = 0; i < bytes.Length; ++i)
            {
                str.Append('%');
                str.Append(DigitToHex(bytes[i] >> 4));
                str.Append(DigitToHex(bytes[i]));
            }
			return str.ToString();
		}

        /// <summary>
        /// 将 %xx 形式的字符串转换成
        /// </summary>
        /// <param name="str">%xx 形式的字符串</param>
        /// <returns>处理后的字节序列</returns>
		public static byte[] StringToByteArray(string str)
		{
            return StringToByteArray(str, Encoding.ASCII);
		}

        /// <summary>
        /// 从字符序列 str 的 index 开始的位置，提取一个字符或 %xx 字节，
        /// 返回经由 charset 编码的字节序列，并调整 index
        /// 
        /// 结果返回后 index 会指向被提取的字符序列的最后一个字符
        /// </summary>
        /// <typeparam name="T">支持 char Item[] 操作的字符序列</typeparam>
        /// <param name="chs">字符序列</param>
        /// <param name="charset">编码</param>
        /// <param name="index">下标</param>
        /// <returns>字节序列</returns>
        private static byte[] MyGetBytes<T>(T chs, Encoding charset, 
                                            ref int index)
            where T:IList<char>
        {
            if (chs[index] != '%')
            {
                // 非 % 字符
                return charset.GetBytes(new char[] { chs[index] });
            }
            else if ((index + 1 < chs.Count) && (chs[index + 1] == '%'))
            {
                // %% 形式
                ++index;
                return charset.GetBytes(new char[] { '%' });
            }
            else if ((index + 2 < chs.Count)
                && IsHexDigit(chs[index + 1])
                && IsHexDigit(chs[index + 2]))
            {
                // 合法的 %xx 形式
                byte b = (byte)((HexToDigit(chs[index + 1]) << 4) + HexToDigit(chs[index + 2]));
                index += 2;
                return new byte[] { b };
            }
            else
            {
                // 非 %% 和 %xx 的 %，直接返回
                return charset.GetBytes(new char[] { '%' });
            }
        }

        /// <summary>
        /// 将带有十六进制 %xx 字节的字符串按特定编码转换成 byte 序列
        /// </summary>
        /// <param name="str">带有十六进制 %xx 字节的字符串</param>
        /// <param name="charset">编码</param>
        /// <returns>处理后的字节序列</returns>
        public static byte[] StringToByteArray(string str, Encoding charset)
        {
            try
            {
                char[] chs = str.ToCharArray();
                List<byte> bytes = new List<byte>(str.Length * 3);
                for (int i = 0; i < chs.Length; ++i)
                    bytes.AddRange(MyGetBytes(chs, charset, ref i));
                return bytes.ToArray();
            }
            catch (Exception)
            {
                return new byte[0];
            }
        }

        /// <summary>
        /// 比较两个字节序列是否相等
        /// </summary>
        /// <param name="a">字节序列一</param>
        /// <param name="b">字节序列二</param>
        /// <returns>相等为真，否则为假</returns>
        private static bool CompareByteArray(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;

            for (int j = 0; j < b.Length; ++j)
                if (a[j] != b[j])
                    return false;
            return true;
        }
        #endregion

        #region 字符集（编码）相关操作
        /// <summary>
        /// 按用户输入的名字添加一种编码
        /// </summary>
        private void AddCharSetBtn_Click(object sender, System.EventArgs e)
		{
			if (CharSetInputText.Text.Length == 0)
			{
				MessageBox.Show("请输入编码的名字");
				return;
			}
            AppendCharSet(CharSetInputText.Text, true);
			//CharSetList.Items.Add(CharSetInputText.Text, true);
		}

        /// <summary>
        /// 在编码列表里添加一个编码
        /// </summary>
        /// <param name="Name">编码名字</param>
        /// <param name="Checked">指示是否选中</param>
        private void AppendCharSet(string Name, bool Checked)
        {
            // 获取 encoding，判断是否是有效的编码名
            Encoding encoding;
            try
            {
                encoding = Encoding.GetEncoding(Name);
            }
            catch
            {
                MessageBox.Show(Name + " 不是有效的编码名字");
                return;
            }

            // 加入字符集列表以显示
            CharSetList.Items.Add(Name, Checked);

            // 加入右键弹出菜单
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Name = Name;
            item.Size = new System.Drawing.Size(152, 22);
            item.Text = "按<" + encoding.EncodingName + ">转换";
            item.Click += new System.EventHandler(this.AppendCharSetConvert);
            this.TreeAppendMenu.Items.Add(item);
        }

        /// <summary>
        /// 获取选中的编码表
        /// </summary>
        private Encoding[] SelectedEncoding
        {
            get
            {
                Encoding[] codes = new Encoding[CharSetList.CheckedItems.Count];
                for (int i = 0; i < CharSetList.CheckedItems.Count; ++i)
                    codes[i] = Encoding.GetEncoding((string)CharSetList.CheckedItems[i]);

                return codes;
            }
        }
        #endregion

        /// <summary>
        /// 按编码转换一个字符串（也有可能是 %xx 字节序列）
        /// </summary>
        private void AppendCharSetConvert(object sender, System.EventArgs e)
        {
            if (curTreeNode == null)
                return;

            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            Encoding encoding = Encoding.GetEncoding(item.Name);

            // 获取字符串
            string text = curTreeNode.Text;
            int pos1 = text.IndexOf('<');
            int pos2 = text.IndexOf('>');
            if ((pos1 == -1) || (pos2 == -1) || (pos1 > pos2))
                return;

            text = text.Substring(pos2 + 1);
            if (text.Length == 0)
            {
                MessageBox.Show("已经是空字符串，不能再转换");
                return;
            }

            string new_text;

            // 判断是 %xx 字节序列还是普通字符串
            if ((text[0] == '%') && (text.Length % 3 == 0))
            {
                // %xx 字节序列到字符串
                byte[] b = StringToByteArray(text);
                new_text = encoding.GetString(b);
                string back_text = ByteArrayToString(encoding.GetBytes(new_text));
                if (back_text != text)
                    if (MessageBox.Show(text + " -> " + new_text + " -> " + back_text + " 不是一个有效的转换\r\n\r\n"
                                        + "是否添加？", "无效的转换", MessageBoxButtons.YesNo)
                        == DialogResult.No)
                        return;
            }
            else
            {
                // 字符串到 %xx 字节序列
                byte[] b = encoding.GetBytes(text);
                new_text = ByteArrayToString(b);
            }

            // 添加结点
            curTreeNode.Nodes.Add("<" + encoding.EncodingName + ">" + new_text);
        }

        /// <summary>
        /// 复制双击的行里的“结果”字符串到粘贴板
        /// </summary>
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

        /// <summary>
        /// 默认转换树的深度
        /// </summary>
        private const int DefaultTreeDeep = 4;

        /// <summary>
        /// 用选中的编码将原始字符串（或字节序列）构造一个转换树
        /// </summary>
        private void TreeBuildBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ResultTabControl.SelectedTab = TreeTabPage;

                ResultTV.Nodes.Clear();

                string text = TheText.Text;
                if (text.Length == 0)
                    throw new ArgumentNullException("文字", "要处理的文字不能为空");

                // 已经扩展过的字符串（或 %xx 字节序列）
                Dictionary<string, object> used = new Dictionary<string, object>();

                if (Base64Chk.Checked)
                {
                    // 处理 BASE64 编码
                    byte[] base64 = Convert.FromBase64String(text);
                    string percent = ByteArrayToString(base64);
                    NodeAppend(ResultTV.Nodes.Add("<原始字节序列>" + percent), used, DefaultTreeDeep);
                }
                else if (PercentSignChk.Checked)
                {
                    // 加入到已经扩展的字符串列表
                    used[text] = null;

                    // 按混合字符串编码
                    TreeNode node = ResultTV.Nodes.Add("<原始混合字符串>" + text);
                    Encoding[] codes = this.SelectedEncoding;

                    // 先将混合字符串按不同的编码构造成字节序列，然后追加子树
                    for (int i = 0; i < codes.Length; ++i)
                    {
                        byte[] bytes = StringToByteArray(text, codes[i]);
                        string str = ByteArrayToString(bytes);

                        TreeNode sub = node.Nodes.Add("<" + codes[i].EncodingName + ">" + str);

                        if (!used.ContainsKey(str))
                        {
                            // 添加子树
                            NodeAppend(sub, used, DefaultTreeDeep - 1);
                        }
                    }
                }
                else if (text[0] != '%')
                {
                    // 按普通字符串编码
                    NodeAppend(ResultTV.Nodes.Add("<原始字符串>" + text), used, DefaultTreeDeep);
                }
                else
                {
                    // 按 %xx 字节序列编码
                    NodeAppend(ResultTV.Nodes.Add("<原始字节序列>" + text), used, DefaultTreeDeep);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "异常");
            }
        }

        /// <summary>
        /// 将结点扩展成具有指定深度的编码转换子树
        /// </summary>
        /// <param name="node">根结点</param>
        /// <param name="used">已经扩展过的字符串列表</param>
        /// <param name="deep">深度</param>
        private void NodeAppend(TreeNode node, Dictionary<string, object> used, int deep)
        {
            string text = node.Text.Substring(node.Text.IndexOf('>') + 1);
            if (text.Length == 0)
                return;

            // 加入到已经扩展的字符串列表
            used[text] = null;

            Encoding[] codes = this.SelectedEncoding;

            if (text[0] != '%')
            {
                // 处理 %xx 字节序列
                for (int i = 0; i < codes.Length; ++i)
                {
                    string conv = ByteArrayToString(codes[i].GetBytes(text));
                    TreeNode app = node.Nodes.Add("<" + codes[i].EncodingName + ">" + conv);

                    // 在深度允许且字符串没有被扩展过的情况下，才对字符串进行扩展
                    if ((deep > 1) && !used.ContainsKey(conv))
                    {
                        NodeAppend(app, used, deep - 1);
                    }
                }
            }
            else
            {
                // 处理普通字符串
                byte[] bytes = StringToByteArray(text);
                for (int i = 0; i < codes.Length; ++i)
                {
                    string conv = codes[i].GetString(bytes);
                    TreeNode app = node.Nodes.Add("<" + codes[i].EncodingName + ">" + conv);

                    // 在深度允许且字符串没有被扩展过的情况下，才对字符串进行扩展
                    if ((deep > 1) && !used.ContainsKey(conv))
                    {
                        // 比较转换后的字符串是否能还原成原来的字节序列，
                        // 如果不能，则表示转换是错误的，拒绝扩展。
                        byte[] ret = codes[i].GetBytes(conv);
                        if (CompareByteArray(bytes, ret))
                                NodeAppend(app, used, deep - 1);
                    }
                }
            }
        }

        /// <summary>
        /// 当前结点。用于右键菜单处理结点时
        /// </summary>
        TreeNode curTreeNode = null;

        /// <summary>
        /// 弹出右键菜单
        /// </summary>
        private void ResultTV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Button != MouseButtons.Right)
                    return;

                curTreeNode = e.Node;

                TreeAppendMenu.Show(ResultTV, e.Location);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常");
            }
        }

        /// <summary>
        /// 复制结点内容的菜单项
        /// </summary>
        private void CopyContentMi_Click(object sender, EventArgs e)
        {
            if (curTreeNode == null)
                return;

            try
            {
                TreeNode node = curTreeNode;
                string text = node.Text;
                int pos1 = text.IndexOf('<');
                int pos2 = text.IndexOf('>');
                if ((pos1 == -1) || (pos2 == -1))
                    return;

                Clipboard.SetDataObject(text.Substring(pos2 + 1), true);
            }
            catch
            {
            }
            finally
            {
                curTreeNode = null;
            }
        }

        /// <summary>
        /// 删除结点的菜单项
        /// </summary>
        private void DeleteNodeMi_Click(object sender, EventArgs e)
        {
            if (curTreeNode == null)
                return;

            curTreeNode.Remove();
        }

        /// <summary>
        /// 查看结点到根结点的路径的菜单顶
        /// </summary>
        private void LookPathMi_Click(object sender, EventArgs e)
        {
            if (curTreeNode == null)
                return;

            // 收集路径
            List<string> path = new List<string>();
            for (TreeNode node = curTreeNode; node != null; node = node.Parent)
                path.Add(node.Text);

            // 反转，以方便后面的显示
            path.Reverse();

            // 从根结点到目的结点依次显示出来
            TextView.Items.Clear();
            foreach (string s in path)
            {
                int c = s.IndexOf('>') + 1;
                TextView.Items.Add(s.Substring(0, c)).SubItems.Add(s.Substring(c));
            }

            ResultTabControl.SelectedTab = ListTabPage;
        }

        private void Base64Chk_CheckedChanged(object sender, EventArgs e)
        {
            if (Base64Chk.Checked)
                PercentSignChk.Enabled = false;
            else
                PercentSignChk.Enabled = true;
        }
    }
}
