using System;

namespace BMS_SMS.Models
{
 
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
        /// <summary>
        /// 需要替换的模板
        /// </summary>
        public string TemplateParam { get; set; } = String.Empty;
    }
}