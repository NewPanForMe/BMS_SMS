using System;

namespace BMS_SMS.Models
{
    public record SmsBaseConfig
    { 
        public static SmsBaseConfig Instance { get; set; } = new SmsBaseConfig();
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
        public string Endpoint { get;  } = "dysmsapi.aliyuncs.com";


    }
}
