using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image2Base64
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private string fileName = "";
        private string fileExt = "";
        private string imageBytesText = "";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ドロップされたファイルをbase64形式に変換する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropPanel_DragDrop(object sender, DragEventArgs e)
        {
            Bitmap image = null;

            try
            {
                // ドロップされたファイルの1枚のみ取得
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                if (files.Length > 1) { MessageBox.Show("画像は最初の1枚だけ選択されます．", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

                // ファイルの情報(名前と拡張子)を抜き出す
                string file = files[0];
                fileName = System.IO.Path.GetFileName(file);    // 例：sample.jpeg
                fileExt = System.IO.Path.GetExtension(file);    // 例：.jpeg

                // イメージに落とし込み，メモリストリームからbase64に変換
                image = new Bitmap(file);
                var memoryStream = new System.IO.MemoryStream();
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = memoryStream.ToArray();
                imageBytesText = Convert.ToBase64String(imageBytes);

                // テキストボックスに出力
                OutputText();
            }
            catch
            {
                MessageBox.Show("エラーが発生しました．アプリケーションを終了します．", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                // リソースの解放
                if (image != null) { image.Dispose(); }
            }
        }

        /// <summary>
        /// テキストを指定された形式でテキストボックスに書き込む
        /// </summary>
        private void OutputText()
        {
            var sb = new StringBuilder();

            sb.Append(preTextBox.Text);
            if (urlCheckBox.Checked)
            {
                sb.Append("[");
                sb.Append(fileName);
                sb.Append("](data:image/");
                sb.Append(fileExt.Substring(1));    // 先頭のピリオド(.)を取る
                sb.Append(";base64,");
            }
            sb.Append(imageBytesText);
            if (urlCheckBox.Checked) { sb.Append(")"); }
            sb.Append(postTextBox.Text);

            base64TextBox.Text = sb.ToString();
        }

        /// <summary>
        /// ファイルをドロップしようとした時のみ，カーソルアイコンを変更する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// テキストボックスのテキストをクリップボードにコピーする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(base64TextBox.Text);
        }

        /// <summary>
        /// URLや接頭・接尾テキストなどの設定を基に，テキストを再構成する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReloadButton_Click(object sender, EventArgs e)
        {
            OutputText();
        }
    }
}
