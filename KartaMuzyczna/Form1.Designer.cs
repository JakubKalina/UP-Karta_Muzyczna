namespace KartaMuzyczna
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFIleInfo = new System.Windows.Forms.TextBox();
            this.buttonLoadWavFile = new System.Windows.Forms.Button();
            this.buttonStartSoundPlayer = new System.Windows.Forms.Button();
            this.buttonStopSoundPlayer = new System.Windows.Forms.Button();
            this.buttonStopWmp = new System.Windows.Forms.Button();
            this.buttonStartWmp = new System.Windows.Forms.Button();
            this.buttonStopWaveOutFile = new System.Windows.Forms.Button();
            this.buttonStartWaveOutFile = new System.Windows.Forms.Button();
            this.buttonStopMci = new System.Windows.Forms.Button();
            this.buttonStartMci = new System.Windows.Forms.Button();
            this.buttonStopDirectSound = new System.Windows.Forms.Button();
            this.buttonStartDirectSound = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonNoEffect = new System.Windows.Forms.RadioButton();
            this.radioButtonEcho = new System.Windows.Forms.RadioButton();
            this.radioButtonReverb = new System.Windows.Forms.RadioButton();
            this.buttonSearchForMicrophones = new System.Windows.Forms.Button();
            this.buttonSelectFileToSaveAudio = new System.Windows.Forms.Button();
            this.buttonStartStopRecording = new System.Windows.Forms.Button();
            this.listBoxAvailableDevices = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxFIleInfo
            // 
            this.textBoxFIleInfo.Location = new System.Drawing.Point(12, 52);
            this.textBoxFIleInfo.Multiline = true;
            this.textBoxFIleInfo.Name = "textBoxFIleInfo";
            this.textBoxFIleInfo.Size = new System.Drawing.Size(288, 136);
            this.textBoxFIleInfo.TabIndex = 0;
            // 
            // buttonLoadWavFile
            // 
            this.buttonLoadWavFile.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadWavFile.Name = "buttonLoadWavFile";
            this.buttonLoadWavFile.Size = new System.Drawing.Size(288, 34);
            this.buttonLoadWavFile.TabIndex = 1;
            this.buttonLoadWavFile.Text = "Wczytaj plik WAV";
            this.buttonLoadWavFile.UseVisualStyleBackColor = true;
            this.buttonLoadWavFile.Click += new System.EventHandler(this.buttonLoadWavFile_Click);
            // 
            // buttonStartSoundPlayer
            // 
            this.buttonStartSoundPlayer.Location = new System.Drawing.Point(32, 221);
            this.buttonStartSoundPlayer.Name = "buttonStartSoundPlayer";
            this.buttonStartSoundPlayer.Size = new System.Drawing.Size(75, 32);
            this.buttonStartSoundPlayer.TabIndex = 2;
            this.buttonStartSoundPlayer.Text = "Start";
            this.buttonStartSoundPlayer.UseVisualStyleBackColor = true;
            this.buttonStartSoundPlayer.Click += new System.EventHandler(this.buttonStartSoundPlayer_Click);
            // 
            // buttonStopSoundPlayer
            // 
            this.buttonStopSoundPlayer.Location = new System.Drawing.Point(113, 221);
            this.buttonStopSoundPlayer.Name = "buttonStopSoundPlayer";
            this.buttonStopSoundPlayer.Size = new System.Drawing.Size(75, 32);
            this.buttonStopSoundPlayer.TabIndex = 3;
            this.buttonStopSoundPlayer.Text = "Stop";
            this.buttonStopSoundPlayer.UseVisualStyleBackColor = true;
            this.buttonStopSoundPlayer.Click += new System.EventHandler(this.buttonStopSoundPlayer_Click);
            // 
            // buttonStopWmp
            // 
            this.buttonStopWmp.Location = new System.Drawing.Point(113, 289);
            this.buttonStopWmp.Name = "buttonStopWmp";
            this.buttonStopWmp.Size = new System.Drawing.Size(75, 29);
            this.buttonStopWmp.TabIndex = 5;
            this.buttonStopWmp.Text = "Stop";
            this.buttonStopWmp.UseVisualStyleBackColor = true;
            this.buttonStopWmp.Click += new System.EventHandler(this.buttonStopWmp_Click);
            // 
            // buttonStartWmp
            // 
            this.buttonStartWmp.Location = new System.Drawing.Point(32, 289);
            this.buttonStartWmp.Name = "buttonStartWmp";
            this.buttonStartWmp.Size = new System.Drawing.Size(75, 29);
            this.buttonStartWmp.TabIndex = 4;
            this.buttonStartWmp.Text = "Start";
            this.buttonStartWmp.UseVisualStyleBackColor = true;
            this.buttonStartWmp.Click += new System.EventHandler(this.buttonStartWmp_Click);
            // 
            // buttonStopWaveOutFile
            // 
            this.buttonStopWaveOutFile.Location = new System.Drawing.Point(113, 358);
            this.buttonStopWaveOutFile.Name = "buttonStopWaveOutFile";
            this.buttonStopWaveOutFile.Size = new System.Drawing.Size(75, 34);
            this.buttonStopWaveOutFile.TabIndex = 7;
            this.buttonStopWaveOutFile.Text = "Stop";
            this.buttonStopWaveOutFile.UseVisualStyleBackColor = true;
            this.buttonStopWaveOutFile.Click += new System.EventHandler(this.buttonStopWaveOutFile_Click);
            // 
            // buttonStartWaveOutFile
            // 
            this.buttonStartWaveOutFile.Location = new System.Drawing.Point(32, 358);
            this.buttonStartWaveOutFile.Name = "buttonStartWaveOutFile";
            this.buttonStartWaveOutFile.Size = new System.Drawing.Size(75, 34);
            this.buttonStartWaveOutFile.TabIndex = 6;
            this.buttonStartWaveOutFile.Text = "Start";
            this.buttonStartWaveOutFile.UseVisualStyleBackColor = true;
            this.buttonStartWaveOutFile.Click += new System.EventHandler(this.buttonStartWaveOutFile_Click);
            // 
            // buttonStopMci
            // 
            this.buttonStopMci.Location = new System.Drawing.Point(113, 435);
            this.buttonStopMci.Name = "buttonStopMci";
            this.buttonStopMci.Size = new System.Drawing.Size(75, 34);
            this.buttonStopMci.TabIndex = 9;
            this.buttonStopMci.Text = "Stop";
            this.buttonStopMci.UseVisualStyleBackColor = true;
            this.buttonStopMci.Click += new System.EventHandler(this.buttonStopMci_Click);
            // 
            // buttonStartMci
            // 
            this.buttonStartMci.Location = new System.Drawing.Point(32, 435);
            this.buttonStartMci.Name = "buttonStartMci";
            this.buttonStartMci.Size = new System.Drawing.Size(75, 34);
            this.buttonStartMci.TabIndex = 8;
            this.buttonStartMci.Text = "Start";
            this.buttonStartMci.UseVisualStyleBackColor = true;
            this.buttonStartMci.Click += new System.EventHandler(this.buttonStartMci_Click);
            // 
            // buttonStopDirectSound
            // 
            this.buttonStopDirectSound.Location = new System.Drawing.Point(113, 504);
            this.buttonStopDirectSound.Name = "buttonStopDirectSound";
            this.buttonStopDirectSound.Size = new System.Drawing.Size(75, 78);
            this.buttonStopDirectSound.TabIndex = 11;
            this.buttonStopDirectSound.Text = "Stop";
            this.buttonStopDirectSound.UseVisualStyleBackColor = true;
            this.buttonStopDirectSound.Click += new System.EventHandler(this.buttonStopDirectSound_Click);
            // 
            // buttonStartDirectSound
            // 
            this.buttonStartDirectSound.Location = new System.Drawing.Point(32, 504);
            this.buttonStartDirectSound.Name = "buttonStartDirectSound";
            this.buttonStartDirectSound.Size = new System.Drawing.Size(75, 78);
            this.buttonStartDirectSound.TabIndex = 10;
            this.buttonStartDirectSound.Text = "Start";
            this.buttonStartDirectSound.UseVisualStyleBackColor = true;
            this.buttonStartDirectSound.Click += new System.EventHandler(this.buttonStartDirectSound_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "SoundPlayer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "WMP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "WaveOutFile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "MCI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "DirectSound";
            // 
            // radioButtonNoEffect
            // 
            this.radioButtonNoEffect.AutoSize = true;
            this.radioButtonNoEffect.Location = new System.Drawing.Point(212, 504);
            this.radioButtonNoEffect.Name = "radioButtonNoEffect";
            this.radioButtonNoEffect.Size = new System.Drawing.Size(96, 21);
            this.radioButtonNoEffect.TabIndex = 17;
            this.radioButtonNoEffect.TabStop = true;
            this.radioButtonNoEffect.Text = "Bez efektu";
            this.radioButtonNoEffect.UseVisualStyleBackColor = true;
            this.radioButtonNoEffect.CheckedChanged += new System.EventHandler(this.radioButtonNoEffect_CheckedChanged);
            // 
            // radioButtonEcho
            // 
            this.radioButtonEcho.AutoSize = true;
            this.radioButtonEcho.Location = new System.Drawing.Point(212, 532);
            this.radioButtonEcho.Name = "radioButtonEcho";
            this.radioButtonEcho.Size = new System.Drawing.Size(61, 21);
            this.radioButtonEcho.TabIndex = 18;
            this.radioButtonEcho.TabStop = true;
            this.radioButtonEcho.Text = "Echo";
            this.radioButtonEcho.UseVisualStyleBackColor = true;
            this.radioButtonEcho.CheckedChanged += new System.EventHandler(this.radioButtonEcho_CheckedChanged);
            // 
            // radioButtonReverb
            // 
            this.radioButtonReverb.AutoSize = true;
            this.radioButtonReverb.Location = new System.Drawing.Point(212, 561);
            this.radioButtonReverb.Name = "radioButtonReverb";
            this.radioButtonReverb.Size = new System.Drawing.Size(75, 21);
            this.radioButtonReverb.TabIndex = 19;
            this.radioButtonReverb.TabStop = true;
            this.radioButtonReverb.Text = "Reverb";
            this.radioButtonReverb.UseVisualStyleBackColor = true;
            this.radioButtonReverb.CheckedChanged += new System.EventHandler(this.radioButtonReverb_CheckedChanged);
            // 
            // buttonSearchForMicrophones
            // 
            this.buttonSearchForMicrophones.Location = new System.Drawing.Point(523, 12);
            this.buttonSearchForMicrophones.Name = "buttonSearchForMicrophones";
            this.buttonSearchForMicrophones.Size = new System.Drawing.Size(163, 70);
            this.buttonSearchForMicrophones.TabIndex = 20;
            this.buttonSearchForMicrophones.Text = "Znajdź dostępne mikrofony";
            this.buttonSearchForMicrophones.UseVisualStyleBackColor = true;
            this.buttonSearchForMicrophones.Click += new System.EventHandler(this.buttonSearchForMicrophones_Click);
            // 
            // buttonSelectFileToSaveAudio
            // 
            this.buttonSelectFileToSaveAudio.Location = new System.Drawing.Point(523, 235);
            this.buttonSelectFileToSaveAudio.Name = "buttonSelectFileToSaveAudio";
            this.buttonSelectFileToSaveAudio.Size = new System.Drawing.Size(163, 70);
            this.buttonSelectFileToSaveAudio.TabIndex = 21;
            this.buttonSelectFileToSaveAudio.Text = "Wybierz plik do zapisu nagrania";
            this.buttonSelectFileToSaveAudio.UseVisualStyleBackColor = true;
            this.buttonSelectFileToSaveAudio.Click += new System.EventHandler(this.buttonSelectFileToSaveAudio_Click);
            // 
            // buttonStartStopRecording
            // 
            this.buttonStartStopRecording.Location = new System.Drawing.Point(523, 311);
            this.buttonStartStopRecording.Name = "buttonStartStopRecording";
            this.buttonStartStopRecording.Size = new System.Drawing.Size(163, 70);
            this.buttonStartStopRecording.TabIndex = 23;
            this.buttonStartStopRecording.Text = "Rozpocznij nagrywanie";
            this.buttonStartStopRecording.UseVisualStyleBackColor = true;
            this.buttonStartStopRecording.Click += new System.EventHandler(this.buttonStartStopRecording_Click);
            // 
            // listBoxAvailableDevices
            // 
            this.listBoxAvailableDevices.FormattingEnabled = true;
            this.listBoxAvailableDevices.ItemHeight = 16;
            this.listBoxAvailableDevices.Location = new System.Drawing.Point(523, 88);
            this.listBoxAvailableDevices.Name = "listBoxAvailableDevices";
            this.listBoxAvailableDevices.Size = new System.Drawing.Size(163, 68);
            this.listBoxAvailableDevices.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 594);
            this.Controls.Add(this.listBoxAvailableDevices);
            this.Controls.Add(this.buttonStartStopRecording);
            this.Controls.Add(this.buttonSelectFileToSaveAudio);
            this.Controls.Add(this.buttonSearchForMicrophones);
            this.Controls.Add(this.radioButtonReverb);
            this.Controls.Add(this.radioButtonEcho);
            this.Controls.Add(this.radioButtonNoEffect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStopDirectSound);
            this.Controls.Add(this.buttonStartDirectSound);
            this.Controls.Add(this.buttonStopMci);
            this.Controls.Add(this.buttonStartMci);
            this.Controls.Add(this.buttonStopWaveOutFile);
            this.Controls.Add(this.buttonStartWaveOutFile);
            this.Controls.Add(this.buttonStopWmp);
            this.Controls.Add(this.buttonStartWmp);
            this.Controls.Add(this.buttonStopSoundPlayer);
            this.Controls.Add(this.buttonStartSoundPlayer);
            this.Controls.Add(this.buttonLoadWavFile);
            this.Controls.Add(this.textBoxFIleInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFIleInfo;
        private System.Windows.Forms.Button buttonLoadWavFile;
        private System.Windows.Forms.Button buttonStartSoundPlayer;
        private System.Windows.Forms.Button buttonStopSoundPlayer;
        private System.Windows.Forms.Button buttonStopWmp;
        private System.Windows.Forms.Button buttonStartWmp;
        private System.Windows.Forms.Button buttonStopWaveOutFile;
        private System.Windows.Forms.Button buttonStartWaveOutFile;
        private System.Windows.Forms.Button buttonStopMci;
        private System.Windows.Forms.Button buttonStartMci;
        private System.Windows.Forms.Button buttonStopDirectSound;
        private System.Windows.Forms.Button buttonStartDirectSound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonNoEffect;
        private System.Windows.Forms.RadioButton radioButtonEcho;
        private System.Windows.Forms.RadioButton radioButtonReverb;
        private System.Windows.Forms.Button buttonSearchForMicrophones;
        private System.Windows.Forms.Button buttonSelectFileToSaveAudio;
        private System.Windows.Forms.Button buttonStartStopRecording;
        private System.Windows.Forms.ListBox listBoxAvailableDevices;
    }
}

