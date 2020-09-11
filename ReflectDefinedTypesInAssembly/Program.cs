using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectDefinedTypesInAssembly
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Logic logic = new Logic();
         IView mainView = new MainForm();
         IMessageService messageService = new MessageService();
         Presenter presenter = new Presenter(logic, mainView, messageService);

         Application.Run(mainView as MainForm);
      }

   }
}
