using Newtonsoft.Json;

namespace BWSSDK.API.Estimate.Model
{
    public class EstimateEventHandlerResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }
    }
}