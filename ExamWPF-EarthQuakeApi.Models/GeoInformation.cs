using System;

namespace ExamWPF_EarthQuakeApi.Models
{
    public class GeoInformation
    {
        public double? Magnitude { get; set; }
        public int EpicenterDepth { get; set; }
        public string Place { get; set; }
        public DateTime Time { get; set; }
    }
}
