using System.Collections.Generic;

using Newtonsoft.Json;

namespace BWSSDK.API.Fetch.Model
{
  public class FetchSolutionRequest
  {
    [JsonProperty(PropertyName = "jobId", Required = Required.Always)]
    public string JobId { get; set; }

  }
}