using System.Collections.Generic;

using Newtonsoft.Json;

namespace BWSSDK.API.Call.Model
{
  public class CallSmartContractRequest<T> : CallSolutionBase
  {

    [JsonProperty(PropertyName = "parameters", Required = Required.Always)]
    public T Parameters { get; set; }

  }
}