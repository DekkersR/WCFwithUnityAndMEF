using System.Diagnostics.CodeAnalysis;

namespace DEMO.Entities
{
    [ExcludeFromCodeCoverage] //only properties
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Finished { get; set; }
    }
}
