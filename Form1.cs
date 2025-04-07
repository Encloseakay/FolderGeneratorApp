namespace FolderGeneratorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region
        private new AutoAdaptWindowsSize AutoSize;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AutoSize = new AutoAdaptWindowsSize(this);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (AutoSize != null) 
            {
                AutoSize.FormSizeChanged();
            }
        }
        #endregion
#if false ///����
        private void SetDefaultText(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };
            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }
#endif

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int folderCount;
                if (!int.TryParse(txtFolderCount.Text, out folderCount) || folderCount <= 0)
                {
                    MessageBox.Show("��������Ч���ļ���������");
                    return;
                }
                string folderPrefix = txtFolderPrefix.Text.Trim() == "" ? "Genera" : txtFolderPrefix.Text.Trim();
                if (string.IsNullOrEmpty(folderPrefix))
                {
                    MessageBox.Show("�������ļ�������ǰ׺��");
                    return;
                }
                string desktopPath = txtFolderPath.Text.Trim() == "" ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : txtFolderPath.Text.Trim();
                string largeFolderName = "GeneratedFolders";
                string largeFolderPath = Path.Combine(desktopPath, largeFolderName);
                if (Directory.Exists(largeFolderPath))
                {
                    Directory.Delete(largeFolderPath, true);
                }
                Directory.CreateDirectory(largeFolderPath);
                for (int i = 1; i <= folderCount; i++)
                {
                    string newFolderName = folderPrefix + i;
                    string newFolderPath = Path.Combine(largeFolderPath, newFolderName);
                    Directory.CreateDirectory(newFolderPath);
                }
                MessageBox.Show($"{folderCount} ���ļ����ѳɹ������� {largeFolderPath}��");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������{ex.Message}");
            }
        }
    }
}
