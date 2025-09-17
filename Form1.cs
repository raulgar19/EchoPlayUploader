using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;

namespace EchoPlayUploader
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string coverFilePath = "";
        private string audioFilePath = "";
        private string url = "http://192.168.1.36:3000/songs/upload";

        public Form1()
        {
            InitializeComponent();
        }

        // Función para normalizar nombres (espacios → guiones, tildes eliminadas, minúsculas)
        private string NormalizeFileName(string input)
        {
            // Quitar tildes
            string normalized = input.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (var c in normalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }
            normalized = sb.ToString();

            // Reemplazar espacios por guiones y pasar a minúsculas
            normalized = Regex.Replace(normalized, @"\s+", "-").ToLower();

            return normalized;
        }

        // Seleccionar carátula (solo JPG)
        private void coverBttn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Imágenes JPG (*.jpg)|*.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    coverFilePath = dialog.FileName;
                    coverTextLabel.Text = Path.GetFileName(coverFilePath);
                }
            }
        }

        // Seleccionar archivo de audio (solo MP3)
        private void audioBttn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Archivos de audio MP3 (*.mp3)|*.mp3";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    audioFilePath = dialog.FileName;
                    audioTextLabel.Text = Path.GetFileName(audioFilePath);
                }
            }
        }

        // Subir canción
        private async void uploadBttn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleTextBox.Text) || string.IsNullOrEmpty(artistTextBox.Text))
            {
                MessageBox.Show("Por favor ingresa título y artista.");
                return;
            }

            if (string.IsNullOrEmpty(coverFilePath) || string.IsNullOrEmpty(audioFilePath))
            {
                MessageBox.Show("Debes seleccionar la carátula (JPG) y el archivo de audio (MP3).");
                return;
            }

            string title = titleTextBox.Text.Trim();
            string artist = artistTextBox.Text.Trim();

            try
            {
                // 1️⃣ Comprobación si la canción ya existe
                var checkContent = new StringContent(
                    $"{{\"title\":\"{title}\",\"artist\":\"{artist}\"}}",
                    Encoding.UTF8,
                    "application/json"
                );

                HttpResponseMessage checkResponse = await client.PostAsync(
                    "http://192.168.1.36:3000/songs/check",
                    checkContent
                );

                string checkResult = await checkResponse.Content.ReadAsStringAsync();
                if (checkResult == "exists")
                {
                    MessageBox.Show("La canción ya existe en la base de datos. No se subirá nada.");
                    return;
                }

                // 2️⃣ Normalizar nombres para los archivos
                string safeTitle = NormalizeFileName(title);
                string safeArtist = NormalizeFileName(artist);

                string coverFileName = $"{safeTitle}-{safeArtist}-cover{Path.GetExtension(coverFilePath)}";
                string audioFileName = $"{safeArtist}-{safeTitle}{Path.GetExtension(audioFilePath)}";

                using (var form = new MultipartFormDataContent())
                {
                    // Datos de texto
                    form.Add(new StringContent(title), "title");
                    form.Add(new StringContent(artist), "artist");

                    // Carátula
                    var coverContent = new ByteArrayContent(File.ReadAllBytes(coverFilePath));
                    coverContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                    form.Add(coverContent, "cover", coverFileName);

                    // Audio
                    var audioContent = new ByteArrayContent(File.ReadAllBytes(audioFilePath));
                    audioContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("audio/mpeg");
                    form.Add(audioContent, "audio", audioFileName);

                    // 3️⃣ Subir archivos
                    HttpResponseMessage uploadResponse = await client.PostAsync(url, form);
                    string uploadResult = await uploadResponse.Content.ReadAsStringAsync();
                    statusTextBox.Text = "Respuesta del servidor: " + uploadResult;
                }
            }
            catch (Exception ex)
            {
                statusTextBox.Text = "Error: " + ex.Message;
            }
        }
    }
}