namespace BMS_SMS.Models
{
    public record SmsResult
    {
        /// <summary>
        /// 
        /// </summary>
        public string BizId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RequestId { get; set; }
    }

}