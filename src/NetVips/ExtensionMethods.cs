using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NetVips.Internal;

namespace NetVips
{
    internal static class ExtensionMethods
    {
        /// <summary>
        /// Removes the element with the specified key from the <see cref="VOption" />
        /// and retrieves the value to <paramref name="target" />.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="key">>The key of the element to remove.</param>
        /// <param name="target">The target to retrieve the value to.</param>
        /// <returns><see langword="true" /> if the element is successfully removed; otherwise, <see langword="false" /></returns>
        public static bool Remove(this VOption self, string key, out object target)
        {
            self.TryGetValue(key, out target);
            return self.Remove(key);
        }

        /// <summary>
        /// Merges 2 <see cref="VOption" />s
        /// </summary>
        /// <param name="self"></param>
        /// <param name="merge"></param>
        public static void Merge(this VOption self, VOption merge)
        {
            foreach (var item in merge)
            {
                self[item.Key] = item.Value;
            }
        }

        /// <summary>
        /// Test for rectangular array of something
        /// </summary>
        /// <param name="array">Input array</param>
        /// <returns><see langword="true" /> if the object is a rectangular array; otherwise, <see langword="false" /></returns>
        public static bool Is2D(this Array array)
        {
            return array.Length > 0 &&
                   (array.Rank == 2 || array.GetValue(0) is Array jaggedArray &&
                    jaggedArray.Length == array.Length);
        }

        /// <summary>
        /// Dereferences data from an unmanaged block of memory 
        /// to a newly allocated managed object of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of object to be created. This object
        /// must represent a formatted class or a structure.</typeparam>
        /// <param name="ptr">A pointer to an unmanaged block of memory.</param>
        /// <returns>A newly allocated managed object of the specified type.</returns>
        public static T Dereference<T>(this IntPtr ptr)
        {
            return (T)Marshal.PtrToStructure(ptr, typeof(T));
        }

        /// <summary>
        /// Creates a new pointer to an unmanaged block of memory 
        /// from an structure of the specified type.
        /// </summary>
        /// <remarks>
        /// The returned pointer should be freed by calling <see cref="GLib.GFree"/>.
        /// </remarks>
        /// <typeparam name="T">The type of structure to be created.</typeparam>
        /// <param name="structure">A managed object that holds the data to be marshaled. 
        /// This object must be a structure or an instance of a formatted class.</param>
        /// <returns>A pointer to an pre-allocated block of memory of the specified type.</returns>
        public static IntPtr ToIntPtr<T>(this object structure) where T : struct
        {
            // Initialize unmanaged memory to hold the struct.
            var unmanagedPointer = GLib.GMalloc(new UIntPtr((ulong)Marshal.SizeOf(typeof(T))));

            // Copy the struct to unmanaged memory.
            Marshal.StructureToPtr(structure, unmanagedPointer, false);

            return unmanagedPointer;
        }

        /// <summary>
        /// Call a libvips operation.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="operationName"></param>
        /// <returns></returns>
        public static object Call(this Image image, string operationName) =>
            Operation.Call(operationName, null, image);

        /// <summary>
        /// Call a libvips operation.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="operationName"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static object Call(this Image image, string operationName, params object[] args) =>
            Operation.Call(operationName, kwargs: null, matchImage: image, args: args);

        /// <summary>
        /// Call a libvips operation.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="operationName"></param>
        /// <param name="kwargs"></param>
        /// <returns></returns>
        public static object Call(this Image image, string operationName, VOption kwargs) =>
            Operation.Call(operationName, kwargs: kwargs, matchImage: image);

        /// <summary>
        /// Call a libvips operation.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="operationName"></param>
        /// <param name="kwargs"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static object Call(this Image image, string operationName, VOption kwargs, params object[] args) =>
            Operation.Call(operationName, kwargs: kwargs, matchImage: image, args: args);

        /// <summary>
        /// Make first letter of a string upper case
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FirstLetterToUpper(this string str)
        {
            if (str == null)
            {
                return null;
            }

            if (str.Length > 1)
            {
                return char.ToUpper(str[0]) + str.Substring(1);
            }

            return str.ToUpper();
        }

        /// <summary>
        /// Make first letter of a string lower case
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FirstLetterToLower(this string str)
        {
            if (str == null)
            {
                return null;
            }

            if (str.Length > 1)
            {
                return char.ToLower(str[0]) + str.Substring(1);
            }

            return str.ToLower();
        }

        /// <summary>
        /// Convert snake case (my_string) to camel case (MyString).
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToPascalCase(this string str)
        {
            return str.Split(new[] { "_" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => char.ToUpperInvariant(s[0]) + s.Substring(1, s.Length - 1))
                .Aggregate(string.Empty, (s1, s2) => s1 + s2);
        }

        /// <summary>
        /// Prepends <paramref name="image" /> to <paramref name="args" />.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="image"></param>
        /// <returns>A new object array.</returns>
        public static object[] PrependImage(this Image[] args, Image image)
        {
            if (args == null)
            {
                return new object[] { image };
            }

            var newValues = new object[args.Length + 1];
            newValues[0] = image;
            Array.Copy(args, 0, newValues, 1, args.Length);
            return newValues;
        }

        /// <summary>
        /// Marshals a GLib UTF8 char* to a managed string.
        /// </summary>
        /// <param name="ptr">Pointer to the GLib string.</param>
        /// <param name="freePtr">If set to <see langword="true" />, free the GLib string.</param>
        /// <param name="size">Size of the GLib string, use 0 to read until the null character.</param>
        /// <returns>The managed string.</returns>
        public static string ToUtf8String(this IntPtr ptr, bool freePtr = false, int size = 0)
        {
            return ptr == IntPtr.Zero ? null : Encoding.UTF8.GetString(ptr.ToByteString(freePtr, size));
        }

        /// <summary>
        /// Marshals a C string pointer to a byte array.
        /// </summary>
        /// <remarks>
        /// Since encoding is not specified, the string is returned as a byte array.
        /// The byte array does not include the null terminator.
        /// </remarks>
        /// <param name="ptr">Pointer to the unmanaged string.</param>
        /// <param name="freePtr">If set to <see langword="true" /> free the unmanaged memory.</param>
        /// <param name="size">Size of the C string, use 0 to read until the null character.</param>
        /// <returns>The string as a byte array.</returns>
        public static byte[] ToByteString(this IntPtr ptr, bool freePtr = false, int size = 0)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            byte[] managedArray;
            if (size > 0)
            {
                managedArray = new byte[size];
                Marshal.Copy(ptr, managedArray, 0, size);
            }
            else
            {
                var bytes = new List<byte>();
                var offset = 0;

                byte b;
                while ((b = Marshal.ReadByte(ptr, offset++)) != 0)
                {
                    bytes.Add(b);
                }

                managedArray = bytes.ToArray();
            }

            if (freePtr)
            {
                GLib.GFree(ptr);
            }

            return managedArray;
        }

        /// <summary>
        /// Convert bytes to human readable format.
        /// </summary>
        /// <param name="value">The number of bytes.</param>
        /// <returns>The readable format of the bytes.</returns>
        internal static string ToReadableBytes(this ulong value)
        {
            string[] sizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

            var i = 0;
            decimal dValue = value;
            while (Math.Round(dValue, 2) >= 1000)
            {
                dValue /= 1024;
                i++;
            }

            return $"{dValue:n2} {sizeSuffixes[i]}";
        }
    }
}