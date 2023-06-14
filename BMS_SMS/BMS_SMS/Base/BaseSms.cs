using System;
using AlibabaCloud.OpenApiClient.Models;
using AlibabaCloud.SDK.Dysmsapi20170525;
using AlibabaCloud.SDK.Dysmsapi20170525.Models;
using BMS_SMS.Models;
using Newtonsoft.Json;

namespace BMS_SMS.Base
{
    public class BaseSms
    {
        public async void Send(string phoneNumber)
        {
            var config = new Config()
            {
                AccessKeyId = SmsBaseConfig.Instance.AccessKeyId,
                AccessKeySecret = SmsBaseConfig.Instance.AccessKeySecret,
                Endpoint = SmsBaseConfig.Instance.Endpoint
            };
            var client = new Client(config);
            var sendSms = new SendSmsRequest()
            {
                PhoneNumbers = phoneNumber,
                SignName = SmsSendConfig.Instance.SignName,
                TemplateCode = SmsSendConfig.Instance.TemplateCode
            };
            var sendSmsResponse = await client.SendSmsAsync(sendSms);
            Console.WriteLine(JsonConvert.SerializeObject(sendSmsResponse.Body));
        }
    }
}