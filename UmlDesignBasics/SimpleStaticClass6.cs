#pragma warning disable S3963  // "static" fields should be initialized inline

// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable InconsistentNaming
// ReSharper disable MemberCanBePrivate.Global
namespace UmlDesignBasics
{
    public static class SimpleStaticClass6
    {
        public static readonly object IntType;
        public static readonly object LongType;
        public static readonly object FloatType;
        public static readonly object DoubleType;
        public static readonly object BooleanType;
        public static readonly object StringType;
        public static readonly object CharType;

        static SimpleStaticClass6()
        {
            IntType = typeof(int);
            LongType = typeof(long);
            FloatType = typeof(float);
            DoubleType = typeof(double);
            BooleanType = typeof(bool);
            StringType = typeof(string);
            CharType = typeof(char);
        }
    }
}
