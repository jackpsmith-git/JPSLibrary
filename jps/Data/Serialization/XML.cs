using System.Xml.Serialization;

namespace Jpsmith.Data.Serialization;

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
        XmlSerializer serializer = new(obj.GetType());
        serializer.Serialize(sw, obj);
        return sw.ToString();
    }

    /// <summary>
    /// Deserializes the given XML string to an object of the given type T
    /// </summary>
    /// <param name="xml">The xml to deserialize.</param>
    /// <returns>Deserialized object.</returns>
    public static T? Deserialize<T>(string xml)
    {
        StringReader sr = new(xml);
        XmlSerializer serializer = new(typeof(T));
        return (T?)serializer.Deserialize(sr);
    }
}