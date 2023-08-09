using System.Collections.Generic;

using Newtonsoft.Json;

namespace BWSSDK.API.Call.Model
{
  public class CallSolutionBase
  {
    [JsonProperty(PropertyName = "solution", Required = Required.Always)]
    public string Solution { get; set; }

    [JsonProperty(PropertyName = "version", Required = Required.Default)]
    public string Version { get; set; }

    [JsonProperty(PropertyName = "network", Required = Required.Default)]
    public string Network { get; set; }

    [JsonProperty(PropertyName = "operation", Required = Required.Always)]
    public string Operation { get; set; }

  }
}