// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
using System.Diagnostics.CodeAnalysis;

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


        public SimpleClass10(SimpleClass10Params parameters)
        {
            this.IntValue = parameters.IntValue;
            this.LongValue = parameters.LongValue;
            this.FloatValue = parameters.FloatValue;
            this.DoubleValue = parameters.DoubleValue;
            this.CharValue = parameters.CharValue;
            this.BooleanValue = parameters.BooleanValue;
            this.ObjectValue = parameters.ObjectValue;
            this.StringValue = parameters.StringValue;
        }
    }

#pragma warning disable SA1402 // File may only contain a single type
    public class SimpleClass10Params
#pragma warning restore SA1402 // File may only contain a single type
    {
        public int IntValue { get; set; }

        public long LongValue { get; set; }

        public float FloatValue { get; set; }

        public double DoubleValue { get; set; }

        public char CharValue { get; set; }

        public bool BooleanValue { get; set; }

        public object ObjectValue { get; set; }

        public string StringValue { get; set; }
    }
}
