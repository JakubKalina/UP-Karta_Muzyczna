using SharpDX.Multimedia;
using SharpDX.XAudio2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace KartaMuzyczna
{
    public partial class Form1 : Form
    {
        SoundPlayer soundPlayer;
        private string filePath = "";
        private string fileRecordPath = "";
        bool mciP = false;
        string Pcom;
        WindowsMediaPlayer wmp;
        int chosenOption;
        SoundStream stream;
        SourceVoice sourceVoice;
        private XAudio2 device;
        MasteringVoice masteringVoice;
        NAudio.Wave.WaveIn sourceStream = null;
        NAudio.Wave.DirectSoundOut soundOut = null;
        NAudio.Wave.WaveFileWriter waveFileWriter = null;
        private bool wasPlayed, wasRecored = false;

        /// <summary>
        /// Konstruktor formy
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            wmp = new WMPLib.WindowsMediaPlayer();
            chosenOption = 0;
            radioButtonNoEffect.Checked = true;
            device = new XAudio2();
            device.StartEngine();
            masteringVoice = new MasteringVoice(device);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Wczytanie pliku WAV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadWavFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Audio files (.wav)|*.wav";
            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath = file.FileName;
                displayFileInfo();
            }
        }

        private void displayFileInfo()
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(fileStream);
                    // Odczytanie nagłówka
                    byte[] wave = reader.ReadBytes(36);
                    fileStream.Position = 0;
                    int chunkID = reader.ReadInt32();
                    int chunkSize = reader.ReadInt32();
                    var fileFormat = Encoding.Default.GetString(wave);
                    string format = fileFormat.Substring(8, 4);
                    string subchunk1ID = fileFormat.Substring(12, 4);
                    string chunkIDString = fileFormat.Substring(0, 4);
                    int formatInt = reader.ReadInt32();
                    int subchunkInt = reader.ReadInt32();
                    int subchunk1Size = reader.ReadInt32();
                    int audioFormat = reader.ReadInt16();
                    int numChannels = reader.ReadInt16();
                    int sampleRate = reader.ReadInt32();
                    int byteRate = reader.ReadInt32();
                    int blockAlign = reader.ReadInt16();
                    int bitsPerSample = reader.ReadInt16();

                    reader.Close();

                    // Wyczyszczenie pola do wyświetlania informacji
                    textBoxFIleInfo.Text = "";

                    // Wyswietlenie danych pliku
                    textBoxFIleInfo.Text += "Chunk ID:" + chunkIDString;
                    textBoxFIleInfo.Text += "\r\nChunk size:" + chunkSize;
                    textBoxFIleInfo.Text += "\r\nFormat: " + format;
                    textBoxFIleInfo.Text += "\r\nSubchunk1 ID: " + subchunk1ID;
                    textBoxFIleInfo.Text += "\r\nSubchunk1 Size: " + subchunk1Size;
                    textBoxFIleInfo.Text += "\r\nAudio Format: " + audioFormat;
                    textBoxFIleInfo.Text += "\r\nNum Channels: " + numChannels;
                    textBoxFIleInfo.Text += "\r\nSample Rate: " + sampleRate;
                    textBoxFIleInfo.Text += "\r\nByte Rate: " + byteRate;
                    textBoxFIleInfo.Text += "\r\nBlock Align: " + blockAlign;
                    textBoxFIleInfo.Text += "\r\nBitsPerSample: " + bitsPerSample;
                }
                catch(Exception)
                {
                    MessageBox.Show("Podano nieprawidłowy format pliku"); 
                }
            }
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        [DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
        private static extern bool PlaySound(string szSound, System.IntPtr hMod, PlaySoundFlags flags);

        [System.Flags]
        public enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }

        /// <summary>
        /// Rozpoczęcie odtwarzania SoundPlayer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartSoundPlayer_Click(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(filePath);
            soundPlayer.Play();
        }

        /// <summary>
        /// Zatrzymanie odtwarzania SoundPlayer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopSoundPlayer_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }

        /// <summary>
        /// Rozpoczęcie odtwarzania WMP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartWmp_Click(object sender, EventArgs e)
        {
            try
            {
                wmp.controls.stop();
            }
            catch (Exception) { }

            wmp.URL = filePath;
            wmp.settings.setMode("loop", true);
            wmp.controls.play();
        }

        /// <summary>
        /// Zatrzymanie odtwarzania WMP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopWmp_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
        }

        /// <summary>
        /// Rozpoczęcie odtwarzania WaveOutFile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartWaveOutFile_Click(object sender, EventArgs e)
        {
            PlaySound(filePath, new System.IntPtr(), PlaySoundFlags.SND_ASYNC);
        }

        /// <summary>
        /// Zatrzymanie odtwarzania WaveOutFile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopWaveOutFile_Click(object sender, EventArgs e)
        {
            PlaySound(null, new System.IntPtr(), PlaySoundFlags.SND_ASYNC);
        }

        /// <summary>
        /// Rozpoczęcie odtwarzania MCI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartMci_Click(object sender, EventArgs e)
        {
            int error = 0;
            if (!mciP)
            {
                Pcom = "close MediaFile";
                error = mciSendString(Pcom, null, 0, IntPtr.Zero);

                Pcom = "open \"" + filePath + "\" type mpegvideo alias MediaFile";
                error = mciSendString(Pcom, null, 0, IntPtr.Zero);
                mciP = false;
            }
            Pcom = "play MediaFile";
            error = mciSendString(Pcom, null, 0, IntPtr.Zero);
        }

        /// <summary>
        /// Zatrzymanie odtwarzania MCI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopMci_Click(object sender, EventArgs e)
        {
            Pcom = "close MediaFile";
            int error = mciSendString(Pcom, null, 0, IntPtr.Zero);
            mciP = false;
        }

        /// <summary>
        /// Rozpoczęcie odtwarzania DirectSound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartDirectSound_Click(object sender, EventArgs e)
        {
            stream = new SoundStream(File.OpenRead(filePath));
            var waveFormat = stream.Format;
            var buffer = new AudioBuffer
            {
                Stream = stream.ToDataStream(),
                AudioBytes = (int)stream.Length,
                Flags = SharpDX.XAudio2.BufferFlags.EndOfStream
            };
            stream.Close();
            sourceVoice = new SourceVoice(device, waveFormat, true);

            sourceVoice.SubmitSourceBuffer(buffer, stream.DecodedPacketsInfo);
            sourceVoice.Start();

            switch (chosenOption)
            {
                case 1:
                    SharpDX.XAPO.Fx.Echo echo = new SharpDX.XAPO.Fx.Echo(device);
                    EffectDescriptor effectDescriptorEcho = new EffectDescriptor(echo);
                    sourceVoice.SetEffectChain(effectDescriptorEcho);
                    sourceVoice.EnableEffect(0);
                    break;
                case 2:
                    SharpDX.XAPO.Fx.Reverb reverb = new SharpDX.XAPO.Fx.Reverb(device);
                    EffectDescriptor effectDescriptorReverb = new EffectDescriptor(reverb);
                    sourceVoice.SetEffectChain(effectDescriptorReverb);
                    sourceVoice.EnableEffect(0);
                    break;
            }
        }

        /// <summary>
        /// Zatrzymanie odtwarzania DirectSound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopDirectSound_Click(object sender, EventArgs e)
        {
            sourceVoice.Stop();
        }

        /// <summary>
        /// Wybranie opcji bez efektu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonNoEffect_CheckedChanged(object sender, EventArgs e)
        {
            chosenOption = 0;
        }

        /// <summary>
        /// Wybranie opcji echo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonEcho_CheckedChanged(object sender, EventArgs e)
        {
            chosenOption = 1;
        }

        /// <summary>
        /// Wybranie opcji reverb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonReverb_CheckedChanged(object sender, EventArgs e)
        {
            chosenOption = 2;
        }

        /// <summary>
        /// Wyszukiwanie dostępnych mikrofonów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchForMicrophones_Click(object sender, EventArgs e)
        {
            label1.Visible = true;

            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));

            listBoxAvailableDevices.Items.Clear(); 

            int counter = 0;
            foreach (var source in sources)
            {
                string item = source.ProductName;
                listBoxAvailableDevices.Items.Add("Mikrofon " + counter + "->" + item);
                counter++;
            }
        }

        /// <summary>
        /// Rozpoczęcie i zakończenie nagrywania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartStopRecording_Click(object sender, EventArgs e)
        {
            if (wasRecored == false)
            {
                if (listBoxAvailableDevices.SelectedItems.Count == 0)
                    return;

                if (fileRecordPath == "")
                {
                    MessageBox.Show("Wybierz miejsce w którym chcesz zapisać plik!");
                }
                else
                {

                    int deviceNumber = listBoxAvailableDevices.SelectedIndex;

                    sourceStream = new NAudio.Wave.WaveIn();
                    sourceStream.DeviceNumber = deviceNumber;
                    sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels); // nadanie czestotliwosci nagrywania, i standardu mono czy stereo wynikającego z urządzenia

                    sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(sourceStream_DataAvailable);
                    waveFileWriter = new NAudio.Wave.WaveFileWriter(fileRecordPath, sourceStream.WaveFormat);

                    sourceStream.StartRecording();

                    buttonStartStopRecording.Text = "W trakcie nagrywania";
                    wasRecored = true;
                }
            }
            else if (wasRecored == true)
            {
                if (soundOut != null)
                {
                    soundOut.Stop();
                    soundOut.Dispose();
                    soundOut = null;
                    buttonStartStopRecording.Text = "Nagraj";
                }
                if (sourceStream != null)
                {
                    sourceStream.StopRecording();
                    sourceStream.Dispose();
                    sourceStream = null;
                    buttonStartStopRecording.Text = "Nagraj";
                }
                if (waveFileWriter != null)
                {
                    waveFileWriter.Dispose();
                    waveFileWriter = null;
                    buttonStartStopRecording.Text = "Nagraj";
                }

            }
        }

        /// <summary>
        /// Wybranie pliku do zapisu nagrania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectFileToSaveAudio_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Wave File (*.wav)|*.wav;";
            if (save.ShowDialog() != DialogResult.OK) return;
            else
                fileRecordPath = save.FileName;
        }

        /// <summary>
        /// Zapis z bufora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sourceStream_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            if (waveFileWriter == null)
                return;

            waveFileWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveFileWriter.Flush();
        }
    }
}
