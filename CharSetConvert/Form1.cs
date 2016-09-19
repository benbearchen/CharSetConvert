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
	/// Form1 ��ժҪ˵����
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
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
            AppendCharSet("UTF-8", true);
            AppendCharSet("Unicode", false);
            AppendCharSet("gb2312", true);
            AppendCharSet("big5", false);
            AppendCharSet("iso8859-1", false);

            //CharSetMi;
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
            this.TheText.Text = "����������Ҫת��������";
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
            this.label1.Text = "����";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(163, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "����";
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
            this.columnHeader2.Text = "����";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "·��";
            this.columnHeader3.Width = 200;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(163, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ת�����";
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
            this.TreeBuildBtn.Text = "�Զ�����ת����";
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
            this.CopyContentMi.Text = "��������";
            this.CopyContentMi.Click += new System.EventHandler(this.CopyContentMi_Click);
            // 
            // LookPathMi
            // 
            this.LookPathMi.Name = "LookPathMi";
            this.LookPathMi.Size = new System.Drawing.Size(118, 22);
            this.LookPathMi.Text = "�鿴·��";
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
            this.DeleteNodeMi.Text = "ɾ�����";
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
            this.TreeTabPage.Text = "����ת��";
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
            this.ListTabPage.Text = "�б�鿴";
            this.ListTabPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(243, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(457, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "��������(��%xx����ʾ���ֽ�����)�󣬵�����Զ�����ת�������ɿ�ʼת����";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PercentSignChk
            // 
            this.PercentSignChk.AutoSize = true;
            this.PercentSignChk.Location = new System.Drawing.Point(468, 75);
            this.PercentSignChk.Name = "PercentSignChk";
            this.PercentSignChk.Size = new System.Drawing.Size(102, 16);
            this.PercentSignChk.TabIndex = 12;
            this.PercentSignChk.Text = "ȡ�� %xx ת��";
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
            this.Text = "���ֱ���ת����";
            this.TreeAppendMenu.ResumeLayout(false);
            this.ResultTabControl.ResumeLayout(false);
            this.TreeTabPage.ResumeLayout(false);
            this.ListTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
        }

        #region ʮ�������ַ�����
        /// <summary>
        /// �ж�һ���ַ��Ƿ���ʮ�������ַ�
        /// </summary>
        private static bool IsHexDigit(char ch)
        {
            return Char.IsLetterOrDigit(ch) && (Char.ToUpper(ch) <= 'F');
        }

        /// <summary>
        /// ����ʮ�������ַ���ʵ����ֵ
        /// </summary>
        /// <param name="ch">ʮ�������ַ�</param>
        /// <returns>ʵ����ֵ</returns>
        /// <exception cref="ArgumentException">��ʮ�������ַ�ʱ�׳�</exception>
        private static int HexToDigit(char ch)
        {
            if (!IsHexDigit(ch))
                throw new ArgumentException("char ������Ч��ʮ�������ַ�", "ch");

            if (Char.IsDigit(ch))
                return ch - '0';
            else
                return Char.ToUpper(ch) - 'A' + 10;
        }

        /// <summary>
        /// ��ֵ��ʮ������ת�����ַ�����
        /// </summary>
        private static readonly char[] hex = { '0', '1', '2', '3', 
                                               '4', '5', '6', '7', 
                                               '8', '9', 'A', 'B', 
                                               'C', 'D', 'E', 'F' };
        /// <summary>
        /// ����ֵת����ʮ�������ַ�
        /// </summary>
        /// <param name="digit">��ֵ</param>
        /// <returns>ʮ�������ַ�</returns>
        private static char DigitToHex(int digit)
        {
            return hex[digit & 0xF];
        }
        #endregion

        #region �ֽ������� %xx �ַ�����ת������ز���
        /// <summary>
        /// ���ֽ�����ת���� %xx ��ʽ���ַ���
        /// </summary>
        /// <param name="bytes">�ֽ�����</param>
        /// <returns>%xx �ַ���</returns>
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
        /// �� %xx ��ʽ���ַ���ת����
        /// </summary>
        /// <param name="str">%xx ��ʽ���ַ���</param>
        /// <returns>�������ֽ�����</returns>
		public static byte[] StringToByteArray(string str)
		{
            return StringToByteArray(str, Encoding.ASCII);
		}

        /// <summary>
        /// ���ַ����� str �� index ��ʼ��λ�ã���ȡһ���ַ��� %xx �ֽڣ�
        /// ���ؾ��� charset ������ֽ����У������� index
        /// 
        /// ������غ� index ��ָ����ȡ���ַ����е����һ���ַ�
        /// </summary>
        /// <typeparam name="T">֧�� char Item[] �������ַ�����</typeparam>
        /// <param name="chs">�ַ�����</param>
        /// <param name="charset">����</param>
        /// <param name="index">�±�</param>
        /// <returns>�ֽ�����</returns>
        private static byte[] MyGetBytes<T>(T chs, Encoding charset, 
                                            ref int index)
            where T:IList<char>
        {
            if (chs[index] != '%')
            {
                // �� % �ַ�
                return charset.GetBytes(new char[] { chs[index] });
            }
            else if ((index + 1 < chs.Count) && (chs[index + 1] == '%'))
            {
                // %% ��ʽ
                ++index;
                return charset.GetBytes(new char[] { '%' });
            }
            else if ((index + 2 < chs.Count)
                && IsHexDigit(chs[index + 1])
                && IsHexDigit(chs[index + 2]))
            {
                // �Ϸ��� %xx ��ʽ
                byte b = (byte)((HexToDigit(chs[index + 1]) << 4) + HexToDigit(chs[index + 2]));
                index += 2;
                return new byte[] { b };
            }
            else
            {
                // �� %% �� %xx �� %��ֱ�ӷ���
                return charset.GetBytes(new char[] { '%' });
            }
        }

        /// <summary>
        /// ������ʮ������ %xx �ֽڵ��ַ������ض�����ת���� byte ����
        /// </summary>
        /// <param name="str">����ʮ������ %xx �ֽڵ��ַ���</param>
        /// <param name="charset">����</param>
        /// <returns>�������ֽ�����</returns>
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
        /// �Ƚ������ֽ������Ƿ����
        /// </summary>
        /// <param name="a">�ֽ�����һ</param>
        /// <param name="b">�ֽ����ж�</param>
        /// <returns>���Ϊ�棬����Ϊ��</returns>
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

        #region �ַ��������룩��ز���
        /// <summary>
        /// ���û�������������һ�ֱ���
        /// </summary>
        private void AddCharSetBtn_Click(object sender, System.EventArgs e)
		{
			if (CharSetInputText.Text.Length == 0)
			{
				MessageBox.Show("��������������");
				return;
			}
            AppendCharSet(CharSetInputText.Text, true);
			//CharSetList.Items.Add(CharSetInputText.Text, true);
		}

        /// <summary>
        /// �ڱ����б������һ������
        /// </summary>
        /// <param name="Name">��������</param>
        /// <param name="Checked">ָʾ�Ƿ�ѡ��</param>
        private void AppendCharSet(string Name, bool Checked)
        {
            // ��ȡ encoding���ж��Ƿ�����Ч�ı�����
            Encoding encoding;
            try
            {
                encoding = Encoding.GetEncoding(Name);
            }
            catch
            {
                MessageBox.Show(Name + " ������Ч�ı�������");
                return;
            }

            // �����ַ����б�����ʾ
            CharSetList.Items.Add(Name, Checked);

            // �����Ҽ������˵�
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Name = Name;
            item.Size = new System.Drawing.Size(152, 22);
            item.Text = "��<" + encoding.EncodingName + ">ת��";
            item.Click += new System.EventHandler(this.AppendCharSetConvert);
            this.TreeAppendMenu.Items.Add(item);
        }

        /// <summary>
        /// ��ȡѡ�еı����
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
        /// ������ת��һ���ַ�����Ҳ�п����� %xx �ֽ����У�
        /// </summary>
        private void AppendCharSetConvert(object sender, System.EventArgs e)
        {
            if (curTreeNode == null)
                return;

            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            Encoding encoding = Encoding.GetEncoding(item.Name);

            // ��ȡ�ַ���
            string text = curTreeNode.Text;
            int pos1 = text.IndexOf('<');
            int pos2 = text.IndexOf('>');
            if ((pos1 == -1) || (pos2 == -1) || (pos1 > pos2))
                return;

            text = text.Substring(pos2 + 1);
            if (text.Length == 0)
            {
                MessageBox.Show("�Ѿ��ǿ��ַ�����������ת��");
                return;
            }

            string new_text;

            // �ж��� %xx �ֽ����л�����ͨ�ַ���
            if ((text[0] == '%') && (text.Length % 3 == 0))
            {
                // %xx �ֽ����е��ַ���
                byte[] b = StringToByteArray(text);
                new_text = encoding.GetString(b);
                string back_text = ByteArrayToString(encoding.GetBytes(new_text));
                if (back_text != text)
                    if (MessageBox.Show(text + " -> " + new_text + " -> " + back_text + " ����һ����Ч��ת��\r\n\r\n"
                                        + "�Ƿ���ӣ�", "��Ч��ת��", MessageBoxButtons.YesNo)
                        == DialogResult.No)
                        return;
            }
            else
            {
                // �ַ����� %xx �ֽ�����
                byte[] b = encoding.GetBytes(text);
                new_text = ByteArrayToString(b);
            }

            // ��ӽ��
            curTreeNode.Nodes.Add("<" + encoding.EncodingName + ">" + new_text);
        }

        /// <summary>
        /// ����˫��������ġ�������ַ�����ճ����
        /// </summary>
		private void TextView_ItemActivate(object sender, System.EventArgs e)
		{
			try
			{
				if (TextView.SelectedItems.Count != 1)
				{
					MessageBox.Show("Ԫ�ؼ����ʱ��ֻӦ��һ��Ԫ�ر�ѡ��");
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
        /// Ĭ��ת���������
        /// </summary>
        private const int DefaultTreeDeep = 4;

        /// <summary>
        /// ��ѡ�еı��뽫ԭʼ�ַ��������ֽ����У�����һ��ת����
        /// </summary>
        private void TreeBuildBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ResultTabControl.SelectedTab = TreeTabPage;

                ResultTV.Nodes.Clear();

                string text = TheText.Text;
                if (text.Length == 0)
                    throw new ArgumentNullException("����", "Ҫ��������ֲ���Ϊ��");

                // �Ѿ���չ�����ַ������� %xx �ֽ����У�
                Dictionary<string, object> used = new Dictionary<string, object>();

                if (Base64Chk.Checked)
                {
                    // ���� BASE64 ����
                    byte[] base64 = Convert.FromBase64String(text);
                    string percent = ByteArrayToString(base64);
                    NodeAppend(ResultTV.Nodes.Add("<ԭʼ�ֽ�����>" + percent), used, DefaultTreeDeep);
                }
                else if (PercentSignChk.Checked)
                {
                    // ���뵽�Ѿ���չ���ַ����б�
                    used[text] = null;

                    // ������ַ�������
                    TreeNode node = ResultTV.Nodes.Add("<ԭʼ����ַ���>" + text);
                    Encoding[] codes = this.SelectedEncoding;

                    // �Ƚ�����ַ�������ͬ�ı��빹����ֽ����У�Ȼ��׷������
                    for (int i = 0; i < codes.Length; ++i)
                    {
                        byte[] bytes = StringToByteArray(text, codes[i]);
                        string str = ByteArrayToString(bytes);

                        TreeNode sub = node.Nodes.Add("<" + codes[i].EncodingName + ">" + str);

                        if (!used.ContainsKey(str))
                        {
                            // �������
                            NodeAppend(sub, used, DefaultTreeDeep - 1);
                        }
                    }
                }
                else if (text[0] != '%')
                {
                    // ����ͨ�ַ�������
                    NodeAppend(ResultTV.Nodes.Add("<ԭʼ�ַ���>" + text), used, DefaultTreeDeep);
                }
                else
                {
                    // �� %xx �ֽ����б���
                    NodeAppend(ResultTV.Nodes.Add("<ԭʼ�ֽ�����>" + text), used, DefaultTreeDeep);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "�쳣");
            }
        }

        /// <summary>
        /// �������չ�ɾ���ָ����ȵı���ת������
        /// </summary>
        /// <param name="node">�����</param>
        /// <param name="used">�Ѿ���չ�����ַ����б�</param>
        /// <param name="deep">���</param>
        private void NodeAppend(TreeNode node, Dictionary<string, object> used, int deep)
        {
            string text = node.Text.Substring(node.Text.IndexOf('>') + 1);
            if (text.Length == 0)
                return;

            // ���뵽�Ѿ���չ���ַ����б�
            used[text] = null;

            Encoding[] codes = this.SelectedEncoding;

            if (text[0] != '%')
            {
                // ���� %xx �ֽ�����
                for (int i = 0; i < codes.Length; ++i)
                {
                    string conv = ByteArrayToString(codes[i].GetBytes(text));
                    TreeNode app = node.Nodes.Add("<" + codes[i].EncodingName + ">" + conv);

                    // ������������ַ���û�б���չ��������£��Ŷ��ַ���������չ
                    if ((deep > 1) && !used.ContainsKey(conv))
                    {
                        NodeAppend(app, used, deep - 1);
                    }
                }
            }
            else
            {
                // ������ͨ�ַ���
                byte[] bytes = StringToByteArray(text);
                for (int i = 0; i < codes.Length; ++i)
                {
                    string conv = codes[i].GetString(bytes);
                    TreeNode app = node.Nodes.Add("<" + codes[i].EncodingName + ">" + conv);

                    // ������������ַ���û�б���չ��������£��Ŷ��ַ���������չ
                    if ((deep > 1) && !used.ContainsKey(conv))
                    {
                        // �Ƚ�ת������ַ����Ƿ��ܻ�ԭ��ԭ�����ֽ����У�
                        // ������ܣ����ʾת���Ǵ���ģ��ܾ���չ��
                        byte[] ret = codes[i].GetBytes(conv);
                        if (CompareByteArray(bytes, ret))
                                NodeAppend(app, used, deep - 1);
                    }
                }
            }
        }

        /// <summary>
        /// ��ǰ��㡣�����Ҽ��˵�������ʱ
        /// </summary>
        TreeNode curTreeNode = null;

        /// <summary>
        /// �����Ҽ��˵�
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
                MessageBox.Show(ex.Message, "�쳣");
            }
        }

        /// <summary>
        /// ���ƽ�����ݵĲ˵���
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
        /// ɾ�����Ĳ˵���
        /// </summary>
        private void DeleteNodeMi_Click(object sender, EventArgs e)
        {
            if (curTreeNode == null)
                return;

            curTreeNode.Remove();
        }

        /// <summary>
        /// �鿴��㵽������·���Ĳ˵���
        /// </summary>
        private void LookPathMi_Click(object sender, EventArgs e)
        {
            if (curTreeNode == null)
                return;

            // �ռ�·��
            List<string> path = new List<string>();
            for (TreeNode node = curTreeNode; node != null; node = node.Parent)
                path.Add(node.Text);

            // ��ת���Է���������ʾ
            path.Reverse();

            // �Ӹ���㵽Ŀ�Ľ��������ʾ����
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
