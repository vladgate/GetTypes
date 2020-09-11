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
         Type[] publicTypes = null;

         try
         {
            publicTypes = assembly.GetTypes().OrderBy(t => t.FullName).ToArray();
         }
         catch (Exception ex)
         {
            throw ex;
         }

         if (publicTypes != null)
         {
            FormatTypes(publicTypes, sb);
         }
         return sb.ToString();
      }
      private void FormatTypes(Type[] types, StringBuilder targetSB)
      {
         foreach (Type t in types)
         {
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
