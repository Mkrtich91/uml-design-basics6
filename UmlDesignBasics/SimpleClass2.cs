#pragma warning disable SA1401  // Fields should be private
#pragma warning disable CA1051  // Do not declare visible instance fields
#pragma warning disable CS0169  // Field is never used
#pragma warning disable S1104   // Fields should not have public accessibility
#pragma warning disable S1144   // Unused private types or members should be removed
#pragma warning disable IDE0044 // Add readonly modifier
#pragma warning disable IDE0051 // Remove unused private members

// ReSharper disable InconsistentNaming
namespace UmlDesignBasics
{
    public class SimpleClass2
    {
        public int IntField;
        private long longField;
#pragma warning disable SA1202
        public float FloatField;
#pragma warning restore SA1202
        public double DoubleField;
        private char charField;
#pragma warning disable SA1202
        public bool BooleanField;
#pragma warning restore SA1202
        private string stringField;
        private object objectField;
    }
}
