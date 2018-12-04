using System.Diagnostics.CodeAnalysis;

namespace DEMO.Entities
{
    [ExcludeFromCodeCoverage] //only properties
    public class Config
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ConfigType Type { get; set; }
        public string Value { get; set; }
    }
}
