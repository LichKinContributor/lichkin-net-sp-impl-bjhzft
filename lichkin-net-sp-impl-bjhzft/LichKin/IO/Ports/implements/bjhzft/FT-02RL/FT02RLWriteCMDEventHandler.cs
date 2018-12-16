
namespace LichKin.IO.Ports
{
    /// <summary>
    ///     串口指令事件处理器 - 开关控制器 - 写指令
    /// </summary>
    public class FT02RLWriteCMDEventHandler : SerialPortCMDEventHandlerImpl
    {
        protected override void UnSendedTimeoutDiscard(string sid, string portName)
        {
            // TODO 记录异常日志
        }

        protected override void SendedReciveTimeoutDiscard(string sid, string portName)
        {
            // TODO 记录异常日志
        }

        protected override void Finished(string sid, string portName, string receivedData)
        {
            // 什么都不用做
        }

        protected override void Canceled(string sid, string portName)
        {
            // TODO 记录异常日志
        }
    }
}
