#pragma warning disable SA1401
#pragma warning disable CA2211
#pragma warning disable S2223
#pragma warning disable S1104
#pragma warning disable CS0169
#pragma warning disable S1144
#pragma warning disable IDE0051
#pragma warning disable IDE0044

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
using System.Diagnostics.CodeAnalysis;

namespace UmlDesignBasics
{
    [SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1202:ElementsMustBeOrderedByAccess", Justification = "Reviewed.")]
    public static class SimpleStaticClass2
    {
        private static int intField;
        private static long longField;
        private static float floatField;
        private static double doubleField;
        public static char CharField;
        public static bool BooleanField;
        public static string StringField;
        public static object ObjectField;
    }
}
