// <auto-generated>
// Code generated by LUISGen CognitiveModels\kkbox.luis.json -cs DemoBotApp.KKBoxRecognizerConvert -o CognitiveModels
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;

namespace DemoBotApp
{
    public class KKBoxRecognizerConvert: IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent 
        {
            chart, 
            None, 
            search
        };
        public Dictionary<Intent, IntentScore> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] artist;
            public string[] chart_type;
            public string[] keyword;
            public string[] lang;

            // Instance
            public class _Instance
            {
                public InstanceData[] artist;
                public InstanceData[] chart_type;
                public InstanceData[] keyword;
                public InstanceData[] lang;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<KKBoxRecognizerConvert>(JsonConvert.SerializeObject(result));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = entry.Value.Score.Value;
                }
            }
            return (maxIntent, max);
        }
    }
}