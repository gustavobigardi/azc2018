using AForge.Controls;
using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Callcenter.Infra.Webcam
{
    public class WebCamCapture
    {
        private Stopwatch stopWatch = null;
        private Timer timer = null;
        private VideoSourcePlayer videoSourcePlayer = null;
        private Form _form = null;
        private string propFps = "";

        public WebCamCapture(Form f)
        {
            _form = f;
            videoSourcePlayer = new VideoSourcePlayer();
            videoSourcePlayer.NewFrame += this.VideoSourcePlayer_NewFrame;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        public string Fps
        {
            get
            {
                return propFps;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            IVideoSource videoSource = videoSourcePlayer.VideoSource;

            if (videoSource != null)
            {
                // get number of frames since the last timer tick
                int framesReceived = videoSource.FramesReceived;

                if (stopWatch == null)
                {
                    stopWatch = new Stopwatch();
                    stopWatch.Start();
                }
                else
                {
                    stopWatch.Stop();

                    float fps = 1000.0f * framesReceived / stopWatch.ElapsedMilliseconds;
                    propFps = fps.ToString("F2") + " fps";


                    stopWatch.Reset();
                    stopWatch.Start();
                }
            }
        }

        public void Start()
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();

            if (form.ShowDialog(_form) == DialogResult.OK)
            {
                // create video source
                VideoCaptureDevice videoSource = form.VideoDevice;

                // open it
                OpenVideoSource(videoSource);
            }
        }

        public void Stop()
        {
            CloseCurrentVideoSource();
        }

        public Bitmap CaptureFrame()
        {
            return videoSourcePlayer.GetCurrentVideoFrame();
        }

        private void CloseCurrentVideoSource()
        {
            if (videoSourcePlayer.VideoSource != null)
            {
                videoSourcePlayer.SignalToStop();

                // wait ~ 3 seconds
                for (int i = 0; i < 30; i++)
                {
                    if (!videoSourcePlayer.IsRunning)
                        break;
                    System.Threading.Thread.Sleep(100);
                }

                if (videoSourcePlayer.IsRunning)
                {
                    videoSourcePlayer.Stop();
                }

                videoSourcePlayer.VideoSource = null;
            }
        }

        private void OpenVideoSource(IVideoSource source)
        {
            // stop current video source
            CloseCurrentVideoSource();

            // start new video source
            videoSourcePlayer.VideoSource = source;
            videoSourcePlayer.Start();

            // reset stop watch
            stopWatch = null;

            // start timer
            timer.Start();
        }

        private void VideoSourcePlayer_NewFrame(object sender, ref System.Drawing.Bitmap image)
        {
            DateTime now = DateTime.Now;
            Graphics g = Graphics.FromImage(image);

            // paint current time
            SolidBrush brush = new SolidBrush(Color.Red);
            g.DrawString(now.ToString(), Control.DefaultFont, brush, new PointF(5, 5));
            brush.Dispose();

            g.Dispose();
        }
    }
}
