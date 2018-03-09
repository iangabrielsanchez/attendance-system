using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ZKFPEngXControl;

namespace Biometric_Attendance_System
{
    class Biometrics
    {
        
        public const int LIGHT_GREEN = 11;
        public const int LIGHT_RED = 12;
        public const int BEEP = 13;
        public const int SENSOR_OFF = 0;
        public const int SENSOR_ON = 1;

        public enum EngineMode
        {
            ENROL,
            ATTENDANCE
        };

        public enum EngineStatus
        {
            INIT_SUCCESS = 0,
            DRIVER_LOAD_FAILED = 1,
            NOT_CONNECTED = 2,
            NULL_SENSOR_INDEX = 3
        };

        public ZKFPEngX engine;
        public EngineMode Mode { get; set; }

        public EngineStatus Status { get; set; }

        public Biometrics()
        {
            engine = new ZKFPEngX();
            engine.SensorIndex = 0;
            Status = (EngineStatus) engine.InitEngine();
            AddActions();
        }

        private void AddActions()
        {
            //engine.OnImageReceived += new IZKFPEngXEvents_OnImageReceivedEventHandler(OnImageReceive);
            //engine.OnEnroll += Engine_OnEnroll;
            
        }

        public Image GetImage()
        {
            object image = new object();
            bool valid = engine.GetFingerImage(ref image);
            byte[] data = (byte[])image;
            MemoryStream ms = new MemoryStream(data);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public bool Verify(ref object template, object verTemplate)
        {
            return engine.VerFinger(ref template, verTemplate, true, true);
        }

        public void BeginEroll()
        {
            MessageBox.Show("Begin enrolling");
            engine.BeginEnroll();
            Mode = EngineMode.ENROL;
        }

        public void Shutdown()
        {
            engine.EndEngine();
        }

        public void Success()
        {
            new Thread(()=>
            {
                engine.ControlSensor(LIGHT_GREEN, SENSOR_ON);
                engine.ControlSensor(LIGHT_GREEN, SENSOR_OFF);
            }).Start();
            
        }

        public void Fail()
        {
            new Thread(() =>
            {
                engine.ControlSensor(LIGHT_RED, SENSOR_ON);
                engine.ControlSensor(LIGHT_RED, SENSOR_OFF);
            }).Start();
        }

        public void Beep()
        {
            engine.ControlSensor(BEEP, SENSOR_ON);
            engine.ControlSensor(BEEP, SENSOR_OFF);
        }

        
    }
}
