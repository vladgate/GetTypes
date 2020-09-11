using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectDefinedTypesInAssembly
{
   public class Presenter
   {
      private readonly Logic _logic;
      private readonly IView _view;
      private readonly IMessageService _messageService;
      public Presenter(Logic logic, IView view, IMessageService messageService)
      {
         _logic = logic;
         _view = view;
         _view.SelectFileClick += View_SelectFileClick;
         _messageService = messageService;
      }

      private void View_SelectFileClick(object sender, EventArgs e)
      {
         OpenFileDialog ofd = new OpenFileDialog();
         ofd.Filter = "(*.exe)|*.exe|(*.dll)|*.dll";
         if (ofd.ShowDialog() == DialogResult.OK)
         {
            string filePath = ofd.FileName;
            if (String.IsNullOrWhiteSpace(filePath))
            {
               _messageService.ShowMessage("Select file!");
            }
            if (!File.Exists(filePath))
            {
               _messageService.ShowMessage("File not exist!");
               return;
            }

            _view.FilePath = filePath;
            try
            {
               _view.Result = _logic.GetDeclaringTypesInAssembly(filePath);
            }
            catch (Exception ex)
            {
               _messageService.ShowMessage(ex.Message);
            }
         }
      }
   }
}
