using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;

namespace BWSSDK.API.Call.Solutions.ESG.Credits.Model
{
  public class BaseParameters
  {
    [JsonProperty(PropertyName = "clientId", Required = Required.Always)]
    public string ClientId { get; set; }

  }
}