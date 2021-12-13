using System.Collections.Generic;
using CluedIn.Crawling.Sunwater.Core;

namespace CluedIn.Crawling.Sunwater.Integration.Test
{
  public static class SunwaterConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { SunwaterConstants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
