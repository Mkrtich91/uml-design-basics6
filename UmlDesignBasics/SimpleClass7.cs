#pragma warning disable S2933   // Fields that are only assigned in the constructor should be "readonly"
#pragma warning disable IDE0044 // Add readonly modifier

// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Local
using System.Diagnostics.CodeAnalysis;

namespace UmlDesignBasics
{
    [SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:ElementsMustAppearInTheCorrectOrder", Justification = "Reviewed.")]
    public class SimpleClass7
    {
        private int intField;
        private long longField;
        private float floatField;
        private double doubleField;
        private char charField;
        private bool booleanField;
        private string stringField;
        private object objectField;

        public int GetInteger()
        {
            return this.intField;
        }

        public long GetLong()
        {
            return this.longField;
        }

        public float GetFloat()
        {
            return this.floatField;
        }

        public double GetDouble()
        {
            return this.doubleField;
        }

        public char GetChar()
        {
            return this.charField;
        }

        public bool GetBoolean()
        {
            return this.booleanField;
        }

        public string GetString()
        {
            return this.stringField;
        }

        public object GetObject()
        {
            return this.objectField;
        }

        public SimpleClass7(int intValue, long longValue, float floatValue, double doubleValue, char chareValue, bool boolValue, string stringValue, object objectValue)
        {
            this.intField = intValue;
            this.longField = longValue;
            this.floatField = floatValue;
            this.doubleField = doubleValue;
            this.charField = chareValue;
            this.booleanField = boolValue;
            this.stringField = stringValue;
            this.objectField = objectValue;
        }
    }
}
