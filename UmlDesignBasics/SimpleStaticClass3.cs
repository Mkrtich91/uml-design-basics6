#pragma warning disable S3400 // Methods should not return constants
#pragma warning disable S1144 // Unused private types or members should be removed
#pragma warning disable IDE0051 // Remove unused private members

using System.Diagnostics.CodeAnalysis;

namespace UmlDesignBasics
{
    [SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1202:ElementsMustBeOrderedByAccess", Justification = "Reviewed.")]
    public static class SimpleStaticClass3
    {
        private static int GetInteger()
        {
            return -101;
        }

        public static long GetLongInteger()
        {
            return 101;
        }

        private static float GetFloat()
        {
            return 1.01f;
        }

        public static double GetDouble()
        {
            return 0.101d;
        }

        public static char GetChar()
        {
            return 'a';
        }

        public static string GetString()
        {
            return "abc";
        }

        private static bool GetBoolean()
        {
            return true;
        }

        private static object GetObject()
        {
            return null;
        }
    }
}
