using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Thslating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Translate Text using Google Translate API's
        /// Google URL - http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="languagePair">2 letter Language Pair, delimited by "|".
        /// E.g. "ar|en" language pair means to translate from Arabic to English</param>
        /// <returns>Translated to String</returns>
        public string TranslateGoogleText(
            string input,
            string languagePair)
        {
            string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
            WebClient webClient = new WebClient();
            webClient.Encoding = System.Text.Encoding.UTF8;
   
            string result = webClient.DownloadString(url);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(result);
            string innerText1 = doc.DocumentNode.SelectSingleNode("//body").SelectNodes("//span").Single(n => n.Attributes.Any(a => a.Name == "id" && a.Value == "result_box")).InnerText;

            result = innerText1;
           
           // result = result.Substring(result.IndexOf("id=result_box") + 22, result.IndexOf("id=result_box") + 500);
          //  result = result.Substring(0, result.IndexOf("</div"));
            return result;
        }
        public string TranslateYandexText(
         string input,
         string language)
        {
            string userKey = "trnsl.1.1.20141017T075601Z.8466c9109acea7a9.43d3aaa48f8730c642fb563b8676aefcb3536aba";
            string url = String.Format("https://translate.yandex.net/api/v1.5/tr/translate?key={0}&text={1}&lang={2}", userKey, input,language);

            WebClient webClient = new WebClient();
            webClient.Encoding = System.Text.Encoding.UTF8;

            string result = webClient.DownloadString(url);
            string output = "";
            using (XmlReader reader = XmlReader.Create(new StringReader(result)))
            {
                reader.ReadToFollowing("text");
                output = reader.ReadElementContentAsString();
            }

            return output;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = TranslateGoogleText(this.textBox1.Text, "ru|en");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = TranslateYandexText(this.textBox1.Text, "ru-en");
        }
    }
}
