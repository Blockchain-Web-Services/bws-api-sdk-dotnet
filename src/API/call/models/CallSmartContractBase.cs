using System.Collections.Generic;

using Newtonsoft.Json;

namespace BWSSDK.API.Call.Model
{
  public class CallSmartContractBase
  {
    [JsonProperty(PropertyName = "contract", Required = Required.Always)]
    public string Contract { get; set; }

    [JsonProperty(PropertyName = "version", Required = Required.Always)]
    public string version { get; set; }

    [JsonProperty(PropertyName = "network", Required = Required.Always)]
    public string Network { get; set; }

    [JsonProperty(PropertyName = "operation", Required = Required.Always)]
    public string Operation { get; set; }

  }
}