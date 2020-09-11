using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectDefinedTypesInAssembly
{
   public class Logic
   {
      public Logic()
      {
         AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += CurrentDomain_ReflectionOnlyAssemblyResolve;
      }
      public string GetDeclaringTypesInAssembly(string filePath)
      {
         Assembly assembly = null;
         StringBuilder sb = new StringBuilder();

         try
         {
            assembly = Assembly.ReflectionOnlyLoadFrom(filePath);
            if (assembly == null)
            {
               throw new Exception("Bad file!");
            }
         }
         catch (Exception ex)
         {
            throw ex;
         }
         Type[] interfaces = null;
         Type[] classes = null;
         Type[] structs = null;
         Type[] enums = null;
         try
         {
            interfaces = assembly.GetTypes().Where(t => t.IsInterface).OrderBy(t => t.FullName).ToArray();
            classes = assembly.GetTypes().Where(t => t.IsClass).OrderBy(t => t.FullName).ToArray();
            structs = assembly.GetTypes().Where(t => t.IsValueType && !t.IsEnum).OrderBy(t => t.FullName).ToArray();
            enums = assembly.GetTypes().Where(t => t.IsEnum).OrderBy(t => t.FullName).ToArray();
         }
         catch (Exception ex)
         {
            throw ex;
         }

         if (interfaces != null)
         {
            FormatTypes(interfaces, sb, "Interfaces:");
         }
         if (classes != null)
         {
            FormatTypes(classes, sb, "Classes:");
         }
         if (structs != null)
         {
            FormatTypes(structs, sb, "Structs:");
         }
         if (enums != null)
         {
            FormatTypes(enums, sb, "Enums:");
         }

         return sb.ToString();
      }
      private void FormatTypes(Type[] types, StringBuilder targetSB, string header)
      {
         if (types.Count() == 0)
         {
            return;
         }
         targetSB.AppendLine(header);
         foreach (Type t in types)
         {
            targetSB.Append('\t');
            targetSB.AppendLine(t.ToString());
         }
      }
      private Assembly CurrentDomain_ReflectionOnlyAssemblyResolve(object sender, ResolveEventArgs args)
      {
         Assembly assembly = null;
         try
         {
            assembly = Assembly.ReflectionOnlyLoad(args.Name);
         }
         catch (FileNotFoundException)
         {
            string targetAssemblyLocation = args.RequestingAssembly.Location;
            string directory = Path.GetDirectoryName(targetAssemblyLocation);
            AssemblyName an = new AssemblyName(args.Name);
            string assemblyPath = directory + "\\" + an.Name + ".dll";
            try
            {
               assembly = Assembly.ReflectionOnlyLoadFrom(assemblyPath);
            }
            catch (FileNotFoundException f)
            {
               throw f;
            }
         }
         catch (Exception ex)
         {
            throw ex;
         }
         return assembly;
      }
   }
}
