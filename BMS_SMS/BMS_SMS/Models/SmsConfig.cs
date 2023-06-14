using System;

namespace BMS_SMS.Models
{
    public class SmsBaseConfig
    { 
        public static SmsBaseConfig Instance { get; set; }
        /// <summary>
        /// 密钥Id
        /// </summary>
        public string AccessKeyId { get; set; } = String.Empty;
        /// <summary>
        /// 密钥 Secret
        /// </summary>
        public string AccessKeySecret { get; set; } = String.Empty;
        /// <summary>
        /// 访问域名
        /// </summary>
        public string Endpoint { get; set; } = "dysmsapi.aliyuncs.com";


    }
    public class SmsSendConfig
    {
        public static SmsSendConfig Instance { get; set; }
        /// <summary>
        /// 密钥Id
        /// </summary>
        public string SignName { get; set; } = String.Empty;
        /// <summary>
        /// 密钥 Secret
        /// </summary>
        public string TemplateCode { get; set; } = String.Empty;
    }
}
