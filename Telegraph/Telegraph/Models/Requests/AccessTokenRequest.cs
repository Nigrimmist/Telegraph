﻿using Newtonsoft.Json;

namespace Kvyk.Telegraph.Models.Requests
{
    internal class AccessTokenRequest
    {
        /// <summary>
        /// Required. Access token of the Telegraph account.
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}
