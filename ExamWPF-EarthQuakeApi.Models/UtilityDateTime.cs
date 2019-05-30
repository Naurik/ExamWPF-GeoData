using System;
using Newtonsoft.Json;

namespace ExamWPF_EarthQuakeApi.Models
{
    public class UtilityDateTime: Newtonsoft.Json.JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            long time;

            if (reader.Value.GetType() != typeof(long))
                time = long.Parse((string)reader.Value);
            else
                time = (long)reader.Value;
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(time);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
