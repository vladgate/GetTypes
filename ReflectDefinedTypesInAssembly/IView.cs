using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectDefinedTypesInAssembly
{
   public interface IView
   {
      event EventHandler SelectFileClick;
      string FilePath { get; set; }
      string Result { get; set; }
   }
}
