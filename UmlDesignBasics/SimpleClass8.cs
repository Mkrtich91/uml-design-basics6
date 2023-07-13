#pragma warning disable IDE0032
#pragma warning disable S2292

// ReSharper disable ConvertToAutoProperty
namespace UmlDesignBasics
{
    public class SimpleClass8
    {
        private int intField;
        private long longField;
        private float floatField;
        private double doubleField;
        private char charField;
        private bool booleanField;
        private string stringField;
        private object objectField;

        public int IntValue
        {
            get => this.intField;
            set => this.intField = value;
        }

        public long LongValue
        {
            get => this.longField;
            set => this.longField = value;
        }

        public float FloatValue
        {
            get => this.floatField;
            set => this.floatField = value;
        }

        public double DoubleValue
        {
            get => this.doubleField;
            set => this.doubleField = value;
        }

        public char CharValue
        {
            get => this.charField;
            set => this.charField = value;
        }

        public bool BooleanValue
        {
            get => this.booleanField;
            set => this.booleanField = value;
        }

        public object ObjectValue
        {
            get { return this.objectField; }
            set { this.objectField = value; }
        }

        public string StringValue
        {
            get { return this.stringField; }
            set { this.stringField = value; }
        }
    }
}
