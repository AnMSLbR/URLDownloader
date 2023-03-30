using System;
using System.Net;
using System.Security.Policy;
using System.IO;

namespace URLDownloader
{
    public partial class MainWindow : Form
    {
        string _outputPath = Directory.GetCurrentDirectory();
        string _url = "";
        HttpClient _httpClient;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _httpClient = new HttpClient();
            tb_OutputPath.Text = _outputPath;
        }

        private void btn_OutputPath_Click(object sender, EventArgs e)
        {
            if (fbd_OutputPath.ShowDialog() == DialogResult.OK)
            {
                tb_OutputPath.Text = fbd_OutputPath.SelectedPath;
            }
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            _outputPath = tb_OutputPath.Text;
            _url = tb_URL.Text;
            var responseStream = await _httpClient.GetStreamAsync(_url);
            using var fileStream = new FileStream(_outputPath + _url.Substring(_url.LastIndexOf('/')), FileMode.Create);
            responseStream.CopyTo(fileStream);
        }
    }
}