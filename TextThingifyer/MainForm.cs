using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Web;

namespace TextThingifyer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InputText.KeyDown += SelectAll;
            OutputText.KeyDown += SelectAll;
        }

        private void SelectAll(object sender, KeyEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox != null && txtBox.Multiline == true && e.Control == true && e.KeyCode == Keys.A)
                txtBox.SelectAll();
        }

        private void Base64Decode_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = System.Convert.FromBase64String(InputText.Text);
                OutputText.Text = System.Text.ASCIIEncoding.ASCII.GetString(data);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Decoding Base64. " + ex.ToString());
            }
        }

        private void Base64Encode_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(InputText.Text);
                OutputText.Text = System.Convert.ToBase64String(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encoding Base64. " + ex.ToString());
            }
        }

        private void JSONPretty_Click(object sender, EventArgs e)
        {
            try
            {
                OutputText.Text = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(InputText.Text), Formatting.Indented);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error JSON Pretty Printing. " + ex.ToString());
            }
        }

        private void XMLPretty_Click(object sender, EventArgs e)
        {
            try
            {
                OutputText.Text = XDocument.Parse(InputText.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error XML PRETTY Printing. " + ex.ToString());
            }
        }

        private void URLDecode_Click(object sender, EventArgs e)
        {
            try
            {
                OutputText.Text = HttpUtility.UrlDecode(InputText.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error URL Decoding " + ex.ToString());
            }
        }

        private void URLEncode_Click(object sender, EventArgs e)
        {
            try
            {
                OutputText.Text = HttpUtility.UrlEncode(InputText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error URL Encoding " + ex.ToString());
            }
        }

        private void HTMLDecode_Click(object sender, EventArgs e)
        {
            try
            {
                OutputText.Text = HttpUtility.HtmlDecode(InputText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error HTML Encoding " + ex.ToString());
            }
        }

        private void HTMLEncode_Click(object sender, EventArgs e)
        {
            try
            {
                OutputText.Text = HttpUtility.HtmlEncode(InputText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error HTML Encoding " + ex.ToString());
            }
        }

        private void QuoteDecode_Click(object sender, EventArgs e)
        {
            OutputText.Text = InputText.Text.Replace("\\\"", "\"").Replace("\\'", "'");
        }

        private void QuoteEncode_Click(object sender, EventArgs e)
        {
            OutputText.Text = InputText.Text.Replace("\"", "\\\"").Replace("'", "\\'");
        }
    }
}
