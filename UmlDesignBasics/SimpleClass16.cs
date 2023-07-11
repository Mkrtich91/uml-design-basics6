#pragma warning disable IDE0032 // Use auto-property

// Methods should not have too many parameters
// ReSharper disable ConvertToAutoProperty
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
using System.Diagnostics.CodeAnalysis;

namespace UmlDesignBasics
{
    [SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:ElementsMustAppearInTheCorrectOrder", Justification = "Reviewed.")]
    public class SimpleClass16
    {
        private readonly int intField;
        private readonly long longField;
        private readonly float floatField;
        private readonly double doubleField;
        private readonly char charField;
        private readonly bool booleanField;
        private readonly string stringField;
        private readonly object objectField;

        public int IntValue { get => this.intField; }

        public long LongValue { get => this.longField; }

        public float FloatValue { get => this.floatField; }

        public double DoubleValue { get => this.doubleField; }

        public char CharValue { get => this.charField; }

        public bool BooleanValue { get => this.booleanField; }

        public string StringValue { get => this.stringField; }

        public object ObjectValue { get => this.objectField; }

        public const int DefaultIntValue = -135914;
        public const long DefaultLongValue = 138672;
        public const float DefaultFloatValue = 130124.58123f;
        public const double DefaultDoubleValue = -130521.71531;
        public const char DefaultCharValue = 'k';
        public const bool DefaultBoolValue = false;
        public const string DefaultStringValue = "stuvwx";
        public const object DefaultObjectValue = null;

        public SimpleClass16(int intValue = DefaultIntValue, long longValue = DefaultLongValue, float floatValue = DefaultFloatValue, double doubleValue = DefaultDoubleValue, char charValue = DefaultCharValue, bool boolValue = DefaultBoolValue, string stringValue = DefaultStringValue, object objectValue = DefaultObjectValue)
        {
            this.intField = intValue;
            this.longField = longValue;
            this.floatField = floatValue;
            this.doubleField = doubleValue;
            this.charField = charValue;
            this.booleanField = boolValue;
            this.stringField = stringValue;
            this.objectField = objectValue;
        }
    }
}
