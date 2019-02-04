using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMHC.Website.Shared.ContentManager.Entities
{
    public enum ContentSource { DynamoDb = 0, S3 }

    public class ContentEntity
    {
        public DateTime LastUpdDt { get; set; }
        [JsonProperty("ContentKey")]
        public string ContentKey { get; set; }
        [JsonProperty("Content")]
        public string ContentHtml { get; set; }
        public ContentSource Source { get; set; }

        public ContentEntity() { }
    }
}
