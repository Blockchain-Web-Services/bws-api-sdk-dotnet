using System.Collections.Generic;

using Newtonsoft.Json;

namespace BWSSDK.API.Call.Model
{
  public class CallSolutionBase
  {
    [JsonProperty(PropertyName = "solution", Required = Required.Always)]
    public string Solution { get; set; }

    [JsonProperty(PropertyName = "version", Required = Required.Always)]
    public string Version { get; set; }

    [JsonProperty(PropertyName = "network", Required = Required.Always)]
    public string Network { get; set; }

    [JsonProperty(PropertyName = "operation", Required = Required.Always)]
    public string Operation { get; set; }

  }
}