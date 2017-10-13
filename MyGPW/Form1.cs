using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGPW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateCompanysDataAsync();
        }

        private Match FindTag(string source,string tag)
        {
            string regex = @"(?<=<"+tag+@"[^>]*>\s*)(?s).*?(?-s)(?=\s*</"+tag+@">)";
            return Regex.Match(source, regex);
        }
        private async void UpdateCompanysDataAsync()
        {
            ts_progres.Visible = true;
            companyBindingSource.Clear();
            var webclient = new WebClient();
            webclient.DownloadProgressChanged += (sender, args) => ts_progres.Value = args.ProgressPercentage;
            string webpage=await webclient.DownloadStringTaskAsync("https://www.bankier.pl/gielda/notowania/akcje");

            //ts_progres.Style = ProgressBarStyle.Marquee;

            string dataSection=FindTag(webpage, "tbody").ToString();
            Match match = FindTag(dataSection, "tr");
            while(match.Success)
            {
                Company com = new Company(match.ToString());
                companyBindingSource.Add(com);
                match=match.NextMatch();
            }
            ts_progres.Visible = false;
            ts_date.Text = DateTime.Now.ToString();
        }

        private void ts_update_Click(object sender, EventArgs e)
        {
            UpdateCompanysDataAsync();
        }
    }
}
