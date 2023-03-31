using System;
using System.Net;
using System.Security.Policy;
using System.IO;
using System.IO.Compression;

namespace URLDownloader
{
    public partial class MainWindow : Form
    {
        string _outputPath = "";
        string _url = "";
        string _urlListPath = "";
        string _zipName = "";
        HttpClient _httpClient;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _httpClient = new HttpClient();
            _outputPath = Directory.GetCurrentDirectory();
            tb_OutputPath.Text = _outputPath;
            _zipName = "images.zip";
        }

        private void btn_OutputPath_Click(object sender, EventArgs e)
        {
            if (fbd_OutputPath.ShowDialog() == DialogResult.OK)
                tb_OutputPath.Text = fbd_OutputPath.SelectedPath;
        }

        private void btn_Save_ClickAsync(object sender, EventArgs e)
        {
            _outputPath = tb_OutputPath.Text;
            _url = tb_URL.Text;
            DownloadImageAsync(_url);
        }

        private void btn_UrlList_Click(object sender, EventArgs e)
        {
            if (ofd_UrlList.ShowDialog() == DialogResult.OK)
                tb_UrlList.Text = ofd_UrlList.FileName;
        }

        private async void btn_SaveAll_Click(object sender, EventArgs e)
        {
            _outputPath = tb_OutputPath.Text;
            _urlListPath = tb_UrlList.Text;
            var zipPath = _outputPath + "\\" + _zipName;
            var counter = 0;

            using StreamReader reader = new StreamReader(_urlListPath);
            while ((_url = reader.ReadLine()) != null)
            {
                await DownloadToZipImagesAsync(_url, zipPath);
                counter++;
                lbl_FileCounter.Text = counter.ToString();
            }

            MessageBox.Show("Completed");
        }

        private async void DownloadImageAsync(string url)
        {
            using var responseStream = await _httpClient.GetStreamAsync(url);
            var fileName = url.Substring(url.LastIndexOf('/') + 1);
            using var fileStream = new FileStream((_outputPath + "\\" + fileName), FileMode.Create);
            responseStream.CopyTo(fileStream);
        }

        private async Task DownloadToZipImagesAsync(string url, string zipPath)
        {
            var fileName = url.Substring(url.LastIndexOf('/') + 1);

            using var responseStream = await _httpClient.GetStreamAsync(url);
            using var zipStream = new FileStream(zipPath, FileMode.OpenOrCreate);
            using var zip = new ZipArchive(zipStream, ZipArchiveMode.Update);
            var file = zip.CreateEntry(fileName);
            using var fileStream = file.Open();
            responseStream.CopyTo(fileStream);
        }

    }
}