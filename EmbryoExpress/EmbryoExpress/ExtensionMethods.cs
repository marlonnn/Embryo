using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EmbryoExpress
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Provides a resource type to use for localized enumeration.
        /// </summary>
        [AttributeUsage(AttributeTargets.Enum, AllowMultiple = false)]
        public sealed class LocalizedResourceAttribute : Attribute
        {
            #region Class members

            /// <summary>
            /// The resource type.
            /// </summary>
            private Type m_type;

            #endregion

            #region Class constructors

            /// <summary>
            /// Initializes a new instance of the <see cref="LocalizedResourceAttribute"/> class.
            /// </summary>
            /// <param name="type">The description to store in this attribute.
            /// </param>
            public LocalizedResourceAttribute(Type type)
                : base()
            {
                this.m_type = type;
            }

            #endregion

            #region Class properties

            /// <summary>
            /// Gets the resource type stored in this attribute.
            /// </summary>
            /// <value>The resource type stored in the attribute.</value>
            public Type Type
            {
                get
                {
                    return this.m_type;
                }
            }

            #endregion
        }

        /// <summary>
        /// Provides enum's value localized resource description key.
        /// </summary>
        [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
        public class LocalizedDescriptionAttribute : Attribute
        {
            #region Class members

            /// <summary>
            /// The localized description key.
            /// </summary>
            private String m_description;

            #endregion

            #region Class constructors

            /// <summary>
            /// Initializes a new instance of the <see cref="LocalizedDescriptionAttribute"/> class.
            /// </summary>
            /// <param name="description">The localized description key to store in this attribute.
            /// </param>
            public LocalizedDescriptionAttribute(String description)
                : base()
            {
                this.m_description = description;
            }

            #endregion

            #region Class properties

            /// <summary>
            /// Gets the localized desciption key stored in this attribute.
            /// </summary>
            /// <value>The localized description key stored in the attribute.</value>
            public String Description
            {
                get
                {
                    return this.m_description;
                }
            }

            #endregion
        }

        /// <summary>
        /// Get the description for the input value.
        /// </summary>
        /// <param name="input">The input value.</param>
        /// <returns>The corresponding description is fuccessful, an empty string otherwise.</returns>
        public static String ToDescription(this Enum en)
        {
            // initialize result       
            String result = RetrieveDescription(en);
            if (null == result)
            {
                // try to retrieve localized description if any
                result = RetrieveLocalizedDescription(en);
                if (null == result)
                {
                    // set enum's string representation
                    result = en.ToString();

                }
            }

            // return result
            return result;
        }

        /// <summary>
        /// Retrieve the enum value's description if any, null otherwise.
        /// </summary>
        /// <param name="input">The input value.</param>
        /// <returns>The enum value's description if any, null otherwise.</returns>
        private static String RetrieveDescription(Enum en)
        {
            // get the type
            Type type = en.GetType();

            // get the member info
            MemberInfo[] mi = type.GetMember(en.ToString());
            if ((null != mi) && (0 < mi.Length))
            {
                // retrieve all description attributes
                Object[] attributes = mi[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                // get the description info
                if ((null != attributes) && (0 < attributes.Length))
                {
                    // return the corresponding description
                    return ((DescriptionAttribute)attributes[0]).Description;
                }
            }

            // return no description
            return null;
        }

        /// <summary>
        /// Get the description for the input value.
        /// </summary>
        /// <param name="input">The input value.</param>
        /// <returns>The corresponding description is fuccessful, an empty string otherwise.</returns>
        public static String RetrieveLocalizedDescription(Enum en)
        {
            // get the input type
            Type type = en.GetType();

            // retrieve all resource attributes; should be only one
            Object[] attributesLocalizedResource = type.GetCustomAttributes(typeof(LocalizedResourceAttribute), false);
            // get the description info
            if ((null != attributesLocalizedResource) && (0 < attributesLocalizedResource.Length))
            {
                // retrieve resource type
                Type resourceType = ((LocalizedResourceAttribute)attributesLocalizedResource[0]).Type;

                // initialize property name with enum's value
                String propertyName = en.ToString();
                // check for a localized description attribute
                MemberInfo[] mi = type.GetMember(en.ToString());
                if ((null != mi) && (0 < mi.Length))
                {
                    // retrieve all localized description attributes
                    Object[] attributesLocalizedDescription = mi[0].GetCustomAttributes(typeof(LocalizedDescriptionAttribute), false);
                    // get the localized description info
                    if ((null != attributesLocalizedDescription) && (0 < attributesLocalizedDescription.Length))
                    {
                        // set property name to the corresponding description
                        propertyName = ((LocalizedDescriptionAttribute)attributesLocalizedDescription[0]).Description;
                    }
                }

                // retrieve the corresponding property
                PropertyInfo propertyInfo = resourceType.GetProperty(propertyName, BindingFlags.Static | BindingFlags.NonPublic);
                if (null != propertyInfo)
                {
                    // return the corresponding value
                    string result = (String)propertyInfo.GetValue(null, null);

                    return result;
                }
            }

            // return no description
            return null;
        }

        /// <summary>
        /// Deserialize object from file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T SerializeFromFile<T>(this T source, string fileName)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", "source");
            }

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return (T)formatter.Deserialize(stream);
            }
        }

        /// <summary>
        /// serialize object to file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static void SerializeToFile<T>(this T source, string fileName)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", "source");
            }

            if (Object.ReferenceEquals(source, null))
            {
                return;
            }
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, source);
            }
        }

        /// <summary>
        /// get serialize bytes array
        /// </summary>
        /// <returns></returns>
        public static byte[] Serialize<T>(this T source)
        {
            if (source == null) return new byte[] { };

            IFormatter formatter = new BinaryFormatter();

            using (MemoryStream stream = new MemoryStream())
            {
                try
                {
                    formatter.Serialize(stream, source);
                    return stream.ToArray();
                }
                catch (System.Exception)
                {

                }
                return new byte[] { };
            }
        }

        public static bool SerializeEqual<T>(this T source, T target)
        {
            return source.Serialize().SequenceEqual(target.Serialize());
        }
    }
}
