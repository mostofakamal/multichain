﻿/*=====================================================================
Authors: Lucid Ocean PTY (LTD)
Copyright © 2017 Lucid Ocean PTY (LTD). All Rights Reserved.

License: Dual MIT / Lucid Ocean Wave Business License v1.0
Please refer to http://www.lucidocean.co.za/wbl-license.html for restrictions and freedoms.
The full license will also be found on the root of the main source-code directory.
=====================================================================*/
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LucidOcean.MultiChain.Response
{
    public class GetServerInfoResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("availableMethods")]
        public List<string> AvailableMethods { get; set; } = new List<string>();

       
    }
}
