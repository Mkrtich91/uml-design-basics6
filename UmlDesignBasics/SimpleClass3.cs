#pragma warning disable CA1822
#pragma warning disable S3400

namespace UmlDesignBasics
{
    public class SimpleClass3
    {
        public int GetInteger()
        {
            return int.MaxValue;
        }

        public long GetLong()
        {
            return long.MinValue;
        }

        public double GetDouble()
        {
            return double.NaN;
        }

        public float GetFloat()
        {
            return float.Epsilon;
        }

        public char GetChar()
        {
            return 'c';
        }

        public string GetString()
        {
            return "abcdef";
        }

        public object GetObject()
        {
            return new object();
        }

        public bool GetBoolean()
        {
            return true;
        }
    }
}
