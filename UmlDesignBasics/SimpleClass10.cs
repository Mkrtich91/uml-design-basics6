// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
using System.Diagnostics.CodeAnalysis;

#pragma warning disable S107

namespace UmlDesignBasics
{
    [SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:ElementsMustAppearInTheCorrectOrder", Justification = "Reviewed.")]
    public class SimpleClass10
    {
        public int IntValue { get; private set; }

        public long LongValue { get; private set; }

        public float FloatValue { get; private set; }

        public double DoubleValue { get; private set; }

        public char CharValue { get; private set; }

        public bool BooleanValue { get; private set; }

        public object ObjectValue { get; private set; }

        public string StringValue { get; private set; }

        public SimpleClass10(int intValue, long longValue, float floatValue, double doubleValue, char charValue, bool booleanValue, object objectValue, string stringValue)
        {
            this.IntValue = intValue;
            this.LongValue = longValue;
            this.FloatValue = floatValue;
            this.DoubleValue = doubleValue;
            this.CharValue = charValue;
            this.BooleanValue = booleanValue;
            this.ObjectValue = objectValue;
            this.StringValue = stringValue;
        }
    }
}

#pragma warning restore S107
