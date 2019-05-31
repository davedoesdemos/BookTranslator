using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net.Http;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
using System.Web.Script.Serialization;



namespace XMLTranslator
{


    public partial class FormTranslator : Form
    {
        private String fromLanguageCode = "en";
        private String toLanguageCode = "zh-Hant";
        public FormTranslator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //initialise the progress bar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 0;
            progressBar1.Value = 0;
            //StatusBar
            toolStripStatusLabel1.Text = "Ready";
            //Load the source document
            XmlDocument doc = new XmlDocument();
            doc.Load(textBoxOpenFile.Text);
            //StatusBar
            toolStripStatusLabel1.Text = "Document Loaded";
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("book-body"); // You can also use XPath here
            if (doc != null)
            {
                foreach (XmlNode node in doc.ChildNodes)
                {
                    doIterateNodeInit(node, progressBar1);
                }
            }

            toolStripStatusLabel1.Text = "Translating";
            if (doc != null)
            {
                foreach (XmlNode node in doc.ChildNodes)
                {
                    doIterateNode(node, progressBar1, richTextBoxFrom, richTextBoxTo, fromLanguageCode, toLanguageCode, textBoxSubKey.Text);
                }
            }
            //StatusBar
            toolStripStatusLabel1.Text = "Complete";
            doc.Save(textBoxSaveFile.Text);
        }

        private static void doIterateNode(XmlNode node, ProgressBar progressBar1, RichTextBox FromBox, RichTextBox ToBox, String from, String to, String subKey)
        {
            if (node.HasChildNodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    doIterateNode(childNode, progressBar1, FromBox, ToBox, from, to, subKey);
                }
            } else
            {
                if (node.NodeType == XmlNodeType.Text)
                {
                    string tempText = node.InnerText;
                    node.Value = TranslateText(node.InnerText, from, to, subKey);
                    FromBox.Text = tempText;
                    ToBox.Text = node.InnerText;
                    progressBar1.Value++;
                }
            }
        }

        private static void doIterateNodeInit(XmlNode node, ProgressBar progressBar1)
        {
            if (node.HasChildNodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    doIterateNodeInit(childNode, progressBar1);
                }
            }
            else
            {
                if (node.NodeType == XmlNodeType.Text)
                {
                    progressBar1.Maximum++;
                }
            }
        }

        static String TranslateText(String text, String from, String to, String subscriptionKey)
        {
           

        string host = "https://api.cognitive.microsofttranslator.com";
            string route = "/translate?api-version=3.0&from=" + from + "&to=" + to;

            System.Object[] body = new System.Object[] { new { Text = text } };
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Set the method to POST
                request.Method = HttpMethod.Post;

                // Construct the full URI
                request.RequestUri = new Uri(host + route);

                // Add the serialized JSON object to your request
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                // Add the authorization header
                request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

                // Send request, get response
                var response = client.SendAsync(request).Result;
                var jsonResponse = response.Content.ReadAsStringAsync().Result;

                // Deserializing json data to object  
                JavaScriptSerializer js = new JavaScriptSerializer();
                List<TranslatorResponse> translations = JsonConvert.DeserializeObject<List<TranslatorResponse>>(jsonResponse);

                return (translations[0].translations[0].text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxOpenFile.Text = openFileDialog1.FileName;
            }
        }

        private void comboBoxFromLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFromLanguage.Text)
            {
                case "Afrikaans af":
                    fromLanguageCode = "af";
                    break;
                case "Arabic ar":
                    fromLanguageCode = "ar";
                    break;
                case "Bangla bn":
                    fromLanguageCode = "bn";
                    break;
                case "Bosnian(Latin) bs":
                    fromLanguageCode = "bs";
                    break;
                case "Bulgarian bg":
                    fromLanguageCode = "bg";
                    break;
                case "Cantonese(Traditional) yue":
                    fromLanguageCode = "yue";
                    break;
                case "Catalan ca":
                    fromLanguageCode = "ca";
                    break;
                case "Chinese Simplified zh-Hans":
                    fromLanguageCode = "zh-Hans";
                    break;
                case "Chinese Traditional zh-Hant":
                    fromLanguageCode = "zh-Hant";
                    break;
                case "Croatian hr":
                    fromLanguageCode = "hr";
                    break;
                case "Czech cs":
                    fromLanguageCode = "cs";
                    break;
                case "Danish da":
                    fromLanguageCode = "da";
                    break;
                case "Dutch nl":
                    fromLanguageCode = "nl";
                    break;
                case "English en":
                    fromLanguageCode = "en";
                    break;
                case "Estonian et":
                    fromLanguageCode = "et";
                    break;
                case "Fijian fj":
                    fromLanguageCode = "fj";
                    break;
                case "Filipino fil":
                    fromLanguageCode = "fil";
                    break;
                case "Finnish fi":
                    fromLanguageCode = "fi";
                    break;
                case "French fr":
                    fromLanguageCode = "fr";
                    break;
                case "German de":
                    fromLanguageCode = "de";
                    break;
                case "Greek el":
                    fromLanguageCode = "el";
                    break;
                case "Haitian Creole ht":
                    fromLanguageCode = "ht";
                    break;
                case "Hebrew he":
                    fromLanguageCode = "he";
                    break;
                case "Hindi hi":
                    fromLanguageCode = "hi";
                    break;
                case "Hmong Daw mww":
                    fromLanguageCode = "mww";
                    break;
                case "Hungarian hu":
                    fromLanguageCode = "hu";
                    break;
                case "Icelandic is":
                    fromLanguageCode = "is";
                    break;
                case "Indonesian id":
                    fromLanguageCode = "id";
                    break;
                case "Italian it":
                    fromLanguageCode = "it";
                    break;
                case "Japanese ja":
                    fromLanguageCode = "ja";
                    break;
                case "Kiswahili sw":
                    fromLanguageCode = "sw";
                    break;
                case "Klingon tlh":
                    fromLanguageCode = "tlh";
                    break;
                case "Klingon(plqaD) tlh-Qaak":
                    fromLanguageCode = "tlh-Qaak";
                    break;
                case "Korean ko":
                    fromLanguageCode = "ko";
                    break;
                case "Latvian lv":
                    fromLanguageCode = "lv";
                    break;
                case "Lithuanian lt":
                    fromLanguageCode = "lt";
                    break;
                case "Malagasy mg":
                    fromLanguageCode = "mg";
                    break;
                case "Malay ms":
                    fromLanguageCode = "ms";
                    break;
                case "Maltese mt":
                    fromLanguageCode = "mt";
                    break;
                case "Norwegian nb":
                    fromLanguageCode = "nb";
                    break;
                case "Persian fa":
                    fromLanguageCode = "fa";
                    break;
                case "Polish pl":
                    fromLanguageCode = "pl";
                    break;
                case "Portuguese pt":
                    fromLanguageCode = "pt";
                    break;
                case "Queretaro Otomi otq":
                    fromLanguageCode = "otq";
                    break;
                case "Romanian ro":
                    fromLanguageCode = "ro";
                    break;
                case "Russian ru":
                    fromLanguageCode = "ru";
                    break;
                case "Samoan sm":
                    fromLanguageCode = "sm";
                    break;
                case "Serbian(Cyrillic) sr-Cyrl":
                    fromLanguageCode = "sr-Cyrl";
                    break;
                case "Serbian(Latin) sr-Latn":
                    fromLanguageCode = "sr-Latn";
                    break;
                case "Slovak sk":
                    fromLanguageCode = "sk";
                    break;
                case "Slovenian sl":
                    fromLanguageCode = "sl";
                    break;
                case "Spanish es":
                    fromLanguageCode = "es";
                    break;
                case "Swedish sv":
                    fromLanguageCode = "sv";
                    break;
                case "Tahitian ty":
                    fromLanguageCode = "ty";
                    break;
                case "Tamil ta":
                    fromLanguageCode = "ta";
                    break;
                case "Telugu te":
                    fromLanguageCode = "te";
                    break;
                case "Thai th":
                    fromLanguageCode = "th";
                    break;
                case "Tongan to":
                    fromLanguageCode = "to";
                    break;
                case "Turkish tr":
                    fromLanguageCode = "tr";
                    break;
                case "Ukrainian uk":
                    fromLanguageCode = "uk";
                    break;
                case "Urdu ur":
                    fromLanguageCode = "ur";
                    break;
                case "Vietnamese vi":
                    fromLanguageCode = "vi";
                    break;
                case "Welsh cy":
                    fromLanguageCode = "cy";
                    break;
                case "Yucatec Maya yua":
                    fromLanguageCode = "yua";
                    break;
                default:
                    fromLanguageCode = "en";
                    break;
            }
        }

        private void comboBoxToLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxToLanguage.Text)
            {
                case "Afrikaans af":
                    toLanguageCode = "af";
                    break;
                case "Arabic ar":
                    toLanguageCode = "ar";
                    break;
                case "Bangla bn":
                    toLanguageCode = "bn";
                    break;
                case "Bosnian(Latin) bs":
                    toLanguageCode = "bs";
                    break;
                case "Bulgarian bg":
                    toLanguageCode = "bg";
                    break;
                case "Cantonese(Traditional) yue":
                    toLanguageCode = "yue";
                    break;
                case "Catalan ca":
                    toLanguageCode = "ca";
                    break;
                case "Chinese Simplified zh-Hans":
                    toLanguageCode = "zh-Hans";
                    break;
                case "Chinese Traditional zh-Hant":
                    toLanguageCode = "zh-Hant";
                    break;
                case "Croatian hr":
                    toLanguageCode = "hr";
                    break;
                case "Czech cs":
                    toLanguageCode = "cs";
                    break;
                case "Danish da":
                    toLanguageCode = "da";
                    break;
                case "Dutch nl":
                    toLanguageCode = "nl";
                    break;
                case "English en":
                    toLanguageCode = "en";
                    break;
                case "Estonian et":
                    toLanguageCode = "et";
                    break;
                case "Fijian fj":
                    toLanguageCode = "fj";
                    break;
                case "Filipino fil":
                    toLanguageCode = "fil";
                    break;
                case "Finnish fi":
                    toLanguageCode = "fi";
                    break;
                case "French fr":
                    toLanguageCode = "fr";
                    break;
                case "German de":
                    toLanguageCode = "de";
                    break;
                case "Greek el":
                    toLanguageCode = "el";
                    break;
                case "Haitian Creole ht":
                    toLanguageCode = "ht";
                    break;
                case "Hebrew he":
                    toLanguageCode = "he";
                    break;
                case "Hindi hi":
                    toLanguageCode = "hi";
                    break;
                case "Hmong Daw mww":
                    toLanguageCode = "mww";
                    break;
                case "Hungarian hu":
                    toLanguageCode = "hu";
                    break;
                case "Icelandic is":
                    toLanguageCode = "is";
                    break;
                case "Indonesian id":
                    toLanguageCode = "id";
                    break;
                case "Italian it":
                    toLanguageCode = "it";
                    break;
                case "Japanese ja":
                    toLanguageCode = "ja";
                    break;
                case "Kiswahili sw":
                    toLanguageCode = "sw";
                    break;
                case "Klingon tlh":
                    toLanguageCode = "tlh";
                    break;
                case "Klingon(plqaD) tlh-Qaak":
                    toLanguageCode = "tlh-Qaak";
                    break;
                case "Korean ko":
                    toLanguageCode = "ko";
                    break;
                case "Latvian lv":
                    toLanguageCode = "lv";
                    break;
                case "Lithuanian lt":
                    toLanguageCode = "lt";
                    break;
                case "Malagasy mg":
                    toLanguageCode = "mg";
                    break;
                case "Malay ms":
                    toLanguageCode = "ms";
                    break;
                case "Maltese mt":
                    toLanguageCode = "mt";
                    break;
                case "Norwegian nb":
                    toLanguageCode = "nb";
                    break;
                case "Persian fa":
                    toLanguageCode = "fa";
                    break;
                case "Polish pl":
                    toLanguageCode = "pl";
                    break;
                case "Portuguese pt":
                    toLanguageCode = "pt";
                    break;
                case "Queretaro Otomi otq":
                    toLanguageCode = "otq";
                    break;
                case "Romanian ro":
                    toLanguageCode = "ro";
                    break;
                case "Russian ru":
                    toLanguageCode = "ru";
                    break;
                case "Samoan sm":
                    toLanguageCode = "sm";
                    break;
                case "Serbian(Cyrillic) sr-Cyrl":
                    toLanguageCode = "sr-Cyrl";
                    break;
                case "Serbian(Latin) sr-Latn":
                    toLanguageCode = "sr-Latn";
                    break;
                case "Slovak sk":
                    toLanguageCode = "sk";
                    break;
                case "Slovenian sl":
                    toLanguageCode = "sl";
                    break;
                case "Spanish es":
                    toLanguageCode = "es";
                    break;
                case "Swedish sv":
                    toLanguageCode = "sv";
                    break;
                case "Tahitian ty":
                    toLanguageCode = "ty";
                    break;
                case "Tamil ta":
                    toLanguageCode = "ta";
                    break;
                case "Telugu te":
                    toLanguageCode = "te";
                    break;
                case "Thai th":
                    toLanguageCode = "th";
                    break;
                case "Tongan to":
                    toLanguageCode = "to";
                    break;
                case "Turkish tr":
                    toLanguageCode = "tr";
                    break;
                case "Ukrainian uk":
                    toLanguageCode = "uk";
                    break;
                case "Urdu ur":
                    toLanguageCode = "ur";
                    break;
                case "Vietnamese vi":
                    toLanguageCode = "vi";
                    break;
                case "Welsh cy":
                    toLanguageCode = "cy";
                    break;
                case "Yucatec Maya yua":
                    toLanguageCode = "yua";
                    break;
                default:
                    toLanguageCode = "en";
                    break;
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSaveFile.Text = saveFileDialog1.FileName;
            }
        }
    }
    class Translation
    {
        public string text;
        public string to;
    }
    class TranslatorResponse
    {
        public List<Translation> translations;
    }
}
