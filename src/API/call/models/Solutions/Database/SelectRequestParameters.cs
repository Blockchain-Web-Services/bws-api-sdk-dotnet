using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;

namespace BWSSDK.API.Call.Solutions.Database.Model
{
  public class SelectRequestParameters
  {
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

  }
}