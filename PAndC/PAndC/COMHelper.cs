using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAndC
{
    public class COMHelper
    {
        private SerialPort comDevice;

        public COMHelper(string portName)
        {
            comDevice = new SerialPort();
            comDevice.PortName = portName;
            comDevice.BaudRate = 9600;
            comDevice.Parity = Parity.None;
            comDevice.DataBits = 8;
            comDevice.StopBits = StopBits.One;
        }

        public COMResult OpenCom()
        {
            COMResult result = new COMResult();
            try
            {
                comDevice.Open();
                comDevice.DataReceived += Com_DataReceived;
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Msg = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        public COMResult SendData(byte[] data)
        {
            COMResult result = new COMResult();
            if (comDevice.IsOpen)
            {
                try
                {
                    comDevice.Write(data, 0, data.Length);//发送数据
                    result.Success = true;
                }
                catch (Exception ex)
                {
                    result.Msg = ex.Message;
                }
            }
            else
            {
                result.Msg = "串口未打开";
            }
            return result;
        }

        /// <summary>
        /// 接收数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[comDevice.BytesToRead];
            comDevice.Read(ReDatas, 0, ReDatas.Length);//读取数据            
        }
    }

    public class COMResult
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
    }
}
