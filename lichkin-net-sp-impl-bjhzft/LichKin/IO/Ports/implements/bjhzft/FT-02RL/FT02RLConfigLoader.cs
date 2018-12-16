using System;

namespace LichKin.IO.Ports
{
    /// <summary>
    ///     开关控制器配置文件加载器
    /// </summary>
    public class FT02RLConfigLoader : SerialPortConfigLoader
    {
        // 配置文件名
        private static String CONFIG_FILE_NAME = "/opt/security/serial-port/bjhzft/FT-02RL.json";

        /// <summary>
        ///     构造方法
        /// </summary>
        private FT02RLConfigLoader()
        {
        }

        /// <summary>
        ///     单例模式
        /// </summary>
        public static readonly FT02RLConfigLoader instance = new FT02RLConfigLoader();
        public static FT02RLConfigLoader Instance
        {
            get { return instance; }
        }

        /// <summary>
        ///     获取配置文件名
        /// </summary>
        protected override String GetConfigFileName()
        {
            return CONFIG_FILE_NAME;
        }
    }
}
