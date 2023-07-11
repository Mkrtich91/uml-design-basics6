// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable IntroduceOptionalParameters.Global
using System.Diagnostics.CodeAnalysis;

namespace UmlDesignBasics
{
    [SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:ElementsMustAppearInTheCorrectOrder", Justification = "Reviewed.")]
    public class SimpleClass14
    {
        public int IntValue { get; private set; }

        public long LongValue { get; private set; }

        public float FloatValue { get; private set; }

        public double DoubleValue { get; private set; }

        public char CharValue { get; private set; }

        public bool BooleanValue { get; private set; }

        public string StringValue { get; private set; }

        public object ObjectValue { get; private set; }

        private SimpleClass14(int intValue, long longValue, float floatValue, double doubleValue, char charValue, bool boolValue, string stringValue, object objectValue)
        {
            this.IntValue = intValue;
            this.LongValue = longValue;
            this.FloatValue = floatValue;
            this.DoubleValue = doubleValue;
            this.CharValue = charValue;
            this.BooleanValue = boolValue;
            this.StringValue = stringValue;
            this.ObjectValue = objectValue;
        }

        public static SimpleClass14 Create()
        {
            return new SimpleClass14(-1132, -11537L, 11369.321f, 11867.3854, 'i', true, "pqr", null);
        }

        public static SimpleClass14 Create(int intValue)
        {
            return new SimpleClass14(intValue, -11537L, 11369.321f, 11867.3854, 'i', true, "pqr", null);
        }

        public static SimpleClass14 Create(int intValue, long longValue)
        {
            return new SimpleClass14(intValue, longValue, 11369.321f, 11867.3854, 'i', true, "pqr", null);
        }

        public static SimpleClass14 Create(int intValue, long longValue, float floatValue)
        {
            return new SimpleClass14(intValue, longValue, floatValue, 11867.3854, 'i', true, "pqr", null);
        }

        public static SimpleClass14 Create(int intValue, long longValue, float floatValue, double doubleValue)
        {
            return new SimpleClass14(intValue, longValue, floatValue, doubleValue, 'i', true, "pqr", null);
        }

        public static SimpleClass14 Create(int intValue, long longValue, float floatValue, double doubleValue, char charValue)
        {
            return new SimpleClass14(intValue, longValue, floatValue, doubleValue, charValue, true, "pqr", null);
        }

        public static SimpleClass14 Create(int intValue, long longValue, float floatValue, double doubleValue, char charValue, bool boolValue)
        {
            return new SimpleClass14(intValue, longValue, floatValue, doubleValue, charValue, boolValue, "pqr", null);
        }

        public static SimpleClass14 Create(int intValue, long longValue, float floatValue, double doubleValue, char charValue, bool boolValue, string stringValue)
        {
            return new SimpleClass14(intValue, longValue, floatValue, doubleValue, charValue, boolValue, stringValue, null);
        }

        public static SimpleClass14 Create(int intValue, long longValue, float floatValue, double doubleValue, char charValue, bool boolValue, string stringValue, object objectValue)
        {
            return new SimpleClass14(intValue, longValue, floatValue, doubleValue, charValue, boolValue, stringValue, objectValue);
        }
    }
}
