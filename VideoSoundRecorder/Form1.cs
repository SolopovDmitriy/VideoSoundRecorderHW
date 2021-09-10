using AForge.Video.DirectShow;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoSoundRecorder
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection _videoDevices;
        private VideoCaptureDevice _vebCamera;
        private NAudio.Wave.WaveInEvent _wvin;
        private int buffersRead = 0;

        public WaveIn waveSource = null; //  обЪект для работы с аудио
        public WaveFileWriter waveFile = null;
        bool buttonIsStart = true; 
       
        public Form1()
        {
            InitializeComponent();
            _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            /*init video Devices*/
            for (int i = 0; i < _videoDevices.Count; i++)
            {
                comboBox_VideoDevices.Items.Add(_videoDevices[i].Name);
            }

            /*init audio Devices*/
            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                comboBox_AudioDevices.Items.Add(NAudio.Wave.WaveIn.GetCapabilities(i).ProductName);
            }
        }
        //hw----------------------------------------------------------- 
        
        private void button_Start_Click(object sender, EventArgs e)
        {
            if (comboBox_VideoDevices.SelectedIndex >= 0)
            {
                try
                {
                    if (_vebCamera != null && _vebCamera.IsRunning == true)
                    {
                        // http://www.aforgenet.com/framework/docs/html/c467086b-99dc-b7b8-cc45-f43247c2674c.htm
                        // Stop(). Since the method aborts background thread, its usage is highly not preferred and should be done only if there are no other options.
                        // The correct way of stopping camera is signaling it stop and then waiting for background thread's completion.
                        // _vebCamera.Stop();
                        //hw----------------------------------------------------------- 
                        _vebCamera.SignalToStop(); // Signals video source to stop its background thread, stop to provide new frames and free resources.
                        _vebCamera.WaitForStop(); // Waits for source stopping after it was signalled to stop using SignalToStop() method.
                        MessageBox.Show("camera is stopped");
                        button_Start.Text = "Start";
                    }
                    else
                    {
                        _vebCamera = new VideoCaptureDevice(_videoDevices[comboBox_VideoDevices.SelectedIndex].MonikerString);
                        _vebCamera.NewFrame += _vebCamera_NewFrame;
                        _vebCamera.Start();
                        button_Start.Text = "Stop";
                    }
                    // Code that is executing when the thread is aborted.  
                }
                catch (PlatformNotSupportedException ex)
                {
                    // Clean-up code can go here.  
                }
            }
        }


        private void _vebCamera_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            var bmp = new Bitmap(eventArgs.Frame, pictureBox_VideoCapture.Width, pictureBox_VideoCapture.Height);

            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Jpeg);
            ms.Close();

            pictureBox_VideoCapture.Image = bmp;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_vebCamera != null && _vebCamera.IsRunning == true)
            {
                MessageBox.Show("Закройте камеру");
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_AudioDevices.SelectedIndex >= 0)
            {
                AudioMonitorInitialize(comboBox_AudioDevices.SelectedIndex);
            }
        }
        
        private void AudioMonitorInitialize(int DeviceIndex, int sampleRate = 8000, int bitRate = 16,
                int channels = 1, int bufferMilliseconds = 20, bool start = true)
        {
            if (_wvin == null)
            {
                _wvin = new NAudio.Wave.WaveInEvent();
                _wvin.DeviceNumber = DeviceIndex;
                _wvin.WaveFormat = new NAudio.Wave.WaveFormat(sampleRate, bitRate, channels);
                _wvin.DataAvailable += _wvin_DataAvailable; ;
                _wvin.BufferMilliseconds = bufferMilliseconds;
                if (start)
                    _wvin.StartRecording();
            }
        }

        private void _wvin_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs eargs)
        {
            int bytesPerSample = _wvin.WaveFormat.BitsPerSample / 8;
            int samplesRecorded = eargs.BytesRecorded / bytesPerSample;
            int buffersToDisplay = 80_000 / samplesRecorded;
            int offset = (buffersRead % buffersToDisplay) * samplesRecorded;

            //eargs.Buffer звук 20 мс
            
            buffersRead += 1;
        }



        // ===================
        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Enabled = false;
            StopBtn.Enabled = true;

            waveSource = new WaveIn();
            waveSource.WaveFormat = new WaveFormat(44100, 1);

            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
            waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);

            waveFile = new WaveFileWriter(@"D:\c#\lesson95\VideoSoundRecorderHW\VideoSoundRecorder\Temp\Test0001.wav", waveSource.WaveFormat);

            waveSource.StartRecording();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            StopBtn.Enabled = false;
            waveSource.StopRecording();
        }


        void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded); //запись звука в буфер (поток - stream)
                waveFile.Flush();// из оперативной памяти - буфера записывается на диск
            }
        }


        void waveSource_RecordingStopped(object sender, StoppedEventArgs e)  // метод, который вызывается, когда происходит событие остановки записи звука.
        {
            if (waveSource != null)
            {
                waveSource.Dispose(); // освобождаем ресурсы, связанные с объектом waveSource
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();// освобождаем ресурсы, связанные с объектом waveFile
                waveFile = null;
            }
            StartBtn.Enabled = true;
        }
        

        private void StartStopBtn_Click(object sender, EventArgs e)
        {
            if (buttonIsStart)
            {
                StartStopBtn.Text = "Stop audio";
                buttonIsStart = false;               

                waveSource = new WaveIn();//создаем обЪект для работы с аудио
                waveSource.WaveFormat = new WaveFormat(44100, 1);//устанавливаем формат звука, 44100 - частота дискредитации, колличество каналов звука = 1 - это моно

                waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);//привязка метода waveSource_DataAvailable к событию waveSource.DataAvailable,
                                                                                                        //когда происходит событие запускается метод
                waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);//привязка метода waveSource_RecordingStopped к событию waveSource.RecordingStopped,
                                                                                                               //когда происходит событие запускается метод

                string fileName = @"D:\c#\lesson95\VideoSoundRecorderHW\VideoSoundRecorder\Temp\Test0001.wav"; // имя файла для записи звука
                waveFile = new WaveFileWriter(fileName, waveSource.WaveFormat); // waveFile -- объект, который будет производить запись в файл

                waveSource.StartRecording();
            }
            else
            {
                StartStopBtn.Text = "Start audio";
                buttonIsStart = true;              

                waveSource.StopRecording();
            }
        }

       
    }
}
