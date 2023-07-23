using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;

namespace BWSSDK.API.Call.Model
{
  public class InsertRequestParameters
  {
    [JsonProperty(PropertyName = "key", Required = Required.Always)]
    public string Key { get; set; }

    [JsonProperty(PropertyName = "value", Required = Required.Always)]
    public string Value { get; set; }

  }
}