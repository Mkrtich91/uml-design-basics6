#pragma warning disable SA1401  // Fields should be private
#pragma warning disable CA2211  // Non-constant fields should not be visible
#pragma warning disable S2223   // Non-constant static fields should not be visible
#pragma warning disable S1104   // Fields should not have public accessibility
#pragma warning disable CS0169  // Field is never used
#pragma warning disable S1144   // Unused private types or members should be removed
#pragma warning disable IDE0051 // Remove unused private members
#pragma warning disable IDE0044 // Add readonly modifier

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
