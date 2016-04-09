﻿using Newtonsoft.Json;

namespace Discord.API
{
    public class Role
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }
        [JsonProperty("permissions")]
        public uint? Permissions { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("position")]
        public int? Position { get; set; }
        [JsonProperty("hoist")]
        public bool? Hoist { get; set; }
        [JsonProperty("color")]
        public uint? Color { get; set; }
        [JsonProperty("managed")]
        public bool? Managed { get; set; }
    }
}