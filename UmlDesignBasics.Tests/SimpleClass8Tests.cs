using System.Reflection;
using NUnit.Framework;

// ReSharper disable InconsistentNaming
namespace UmlDesignBasics.Tests
{
    [TestFixture]
    public class SimpleClass8Tests
    {
        private Type classType;

        [SetUp]
        public void SetUp()
        {
            var assembly = typeof(CreatingSimpleClass2).Assembly;
            this.classType = assembly.GetType("UmlDesignBasics.SimpleClass8");
        }

        [Test]
        public void IsClass()
        {
            Assert.IsTrue(this.classType.IsClass);
        }

        [Test]
        public void IsNotStaticClass()
        {
            Assert.IsFalse(this.classType.IsAbstract);
            Assert.IsFalse(this.classType.IsSealed);
        }

        [Test]
        public void InheritsObject()
        {
            Assert.AreEqual(typeof(object), this.classType.BaseType);
        }

        [Test]
        public void HasRequiredMembers()
        {
            Assert.AreEqual(0, this.classType.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length);
            Assert.AreEqual(0, this.classType.GetFields(BindingFlags.Instance | BindingFlags.Public).Length);
            Assert.AreEqual(8, this.classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Length);

            Assert.AreEqual(0, this.classType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length);
            Assert.AreEqual(16, this.classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Length);
            Assert.AreEqual(0, this.classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Length);

            Assert.AreEqual(0, this.classType.GetConstructors(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length);
            Assert.AreEqual(1, this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.Public).Length);
            Assert.AreEqual(0, this.classType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).Length);

            Assert.AreEqual(0, this.classType.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Length);
            Assert.AreEqual(8, this.classType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Length);
            Assert.AreEqual(0, this.classType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic).Length);

            var flags = BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            Assert.AreEqual(0, this.classType.GetEvents(flags).Length);
        }

        [TestCase("intField", typeof(int))]
        [TestCase("longField", typeof(long))]
        [TestCase("floatField", typeof(float))]
        [TestCase("doubleField", typeof(double))]
        [TestCase("charField", typeof(char))]
        [TestCase("booleanField", typeof(bool))]
        [TestCase("stringField", typeof(string))]
        [TestCase("objectField", typeof(object))]
        public void HasRequiredField(string fieldName, Type expectedType)
        {
            var fieldInfo = this.classType.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);

            Assert.NotNull(fieldInfo);
            Assert.AreEqual(expectedType, fieldInfo.FieldType);
            Assert.IsTrue(fieldInfo.FieldType == expectedType);
        }

        [TestCase("IntValue", typeof(int), 754)]
        [TestCase("LongValue", typeof(long), 721)]
        [TestCase("FloatValue", typeof(float), -76.67F)]
        [TestCase("DoubleValue", typeof(double), 372.127)]
        [TestCase("CharValue", typeof(char), 'e')]
        [TestCase("BooleanValue", typeof(bool), true)]
        [TestCase("StringValue", typeof(string), "ghi")]
        [TestCase("ObjectValue", typeof(object), typeof(SimpleClass8Tests))]
        public void HasProperty(string propertyName, Type expectedPropertyType, object value)
        {
            var propertyInfo = this.classType.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public);

            Assert.NotNull(propertyInfo);
            Assert.AreEqual(expectedPropertyType, propertyInfo.PropertyType);

            var instance = Activator.CreateInstance(this.classType);
            propertyInfo.SetValue(instance, value);

            var actualValue = propertyInfo.GetValue(instance);

            Assert.NotNull(actualValue);
            Assert.AreEqual(value, actualValue);
        }
    }
}
