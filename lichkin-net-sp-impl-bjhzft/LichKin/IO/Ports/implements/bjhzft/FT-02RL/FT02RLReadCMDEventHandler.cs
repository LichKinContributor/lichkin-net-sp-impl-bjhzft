using LichKin.Utils;
using System;

namespace LichKin.IO.Ports
{
    /// <summary>
    ///     串口指令事件处理器 - 开关控制器 - 读指令
    /// </summary>
    public class FT02RLReadCMDEventHandler : SerialPortCMDEventHandlerImpl
    {
        // 结果处理代理定义
        public delegate void HandleResult(String sid, String portName, int result);

        // 结果处理委托实现
        private HandleResult handleResult;

        /// <summary>
        ///     构造方法
        /// </summary>
        /// <param name="handleResult">结果处理委托实现</param>
        public FT02RLReadCMDEventHandler(HandleResult handleResult)
        {
            this.handleResult = handleResult;
        }

        protected override void UnSendedTimeoutDiscard(string sid, string portName)
        {
            // 什么都不用做
        }

        protected override void SendedReciveTimeoutDiscard(string sid, string portName)
        {
            // 什么都不用做
        }

        protected override void Finished(string sid, string portName, string receivedData)
        {
            if (ModbusUtils.CRC("01", "02", "01 00").Equals(receivedData))
            {
                this.handleResult(sid, portName, 0);
                return;
            }

            if (ModbusUtils.CRC("01", "02", "01 01").Equals(receivedData))
            {
                this.handleResult(sid, portName, 1);
                return;
            }

            if (ModbusUtils.CRC("01", "02", "01 02").Equals(receivedData))
            {
                this.handleResult(sid, portName, 2);
                return;
            }

            if (ModbusUtils.CRC("01", "02", "01 03").Equals(receivedData))
            {
                this.handleResult(sid, portName, 3);
                return;
            }

            // TODO 记录异常日志
            this.handleResult(sid, portName, -1);
        }

        protected override void Canceled(string sid, string portName)
        {
        }
    }
}
