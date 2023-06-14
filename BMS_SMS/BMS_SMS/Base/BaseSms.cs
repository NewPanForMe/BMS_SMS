using System;
using System.Threading.Tasks;
using AlibabaCloud.OpenApiClient.Models;
using AlibabaCloud.SDK.Dysmsapi20170525;
using AlibabaCloud.SDK.Dysmsapi20170525.Models;
using BMS_SMS.Models;
using Newtonsoft.Json;

namespace BMS_SMS.Base
{
    public class BaseSms
    {
        public static BaseSms Instance = new BaseSms();
        public async Task<SmsResult> Send(string phoneNumber)
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
                TemplateCode = SmsSendConfig.Instance.TemplateCode,
                TemplateParam = SmsSendConfig.Instance.TemplateParam,
            };
            var sendSmsResponse = await client.SendSmsAsync(sendSms);
            var res = sendSmsResponse.Body;
            return new SmsResult()
            {
                BizId = res.BizId,
                Code = res.Code,
                Message = res.Message,
                RequestId = res.RequestId,
            };
        }
    }
}