using System.Xml.Serialization;

namespace JPS.Data.Serialization
{
    /// <summary>
    /// Provides static methods for serializing and deserializing data with the XML format.
    /// </summary>
    public static class XML
    {
        /// <summary>
        /// Serializes the given object to XML.
        /// </summary>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>String containing serialized XML object data.</returns>
        public static string Serialize(object obj)
        {
            StringWriter sw = new();
            XmlSerializer xml = new(obj.GetType());
            xml.Serialize(sw, obj);
            return sw.ToString();
        }

        /// <summary>
        /// Deserializes the given XML string to an Object.
        /// </summary>
        /// <param name="obj">The data to deserialize.</param>
        /// <returns>Deserialized object.</returns>
        public static object? Deserialize(string str)
        {
            StringReader sr = new(str);
            XmlSerializer xml = new(typeof(object));
            return xml.Deserialize(sr);
        }
    }
}
