#pragma warning disable IDE0017 // Object initialization can be simplified

// ReSharper disable InconsistentNaming
// ReSharper disable UseObjectOrCollectionInitializer
namespace UmlDesignBasics
{
    public static class CreatingSimpleClass2
    {
        public static object CreateSimpleClass2()
        {
            SimpleClass2 simpleClass = new SimpleClass2();

            simpleClass.IntField = -331;
            simpleClass.BooleanField = true;
            simpleClass.DoubleField = -31.31;
            simpleClass.FloatField = 13.13f;

            return simpleClass;
        }

        public static object CreateSimpleClass2ObjectInitializer()
        {
            return new SimpleClass2()
            {
                IntField = 432,
                BooleanField = false,
                DoubleField = 43.12,
                FloatField = -42.31f,
            };
        }
    }
}
