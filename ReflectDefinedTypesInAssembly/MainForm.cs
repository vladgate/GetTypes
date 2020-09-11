using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectDefinedTypesInAssembly
{
   public partial class MainForm : Form, IView
   {
      public MainForm()
      {
         InitializeComponent();
         this.btnSelectFile.Click += BtnSelectFile_Click;
      }

      private void BtnSelectFile_Click(object sender, EventArgs e)
      {
         SelectFileClick?.Invoke(sender, e);
      }

      #region IView
      public event EventHandler SelectFileClick;
      public string FilePath { get => txtFilePath.Text; set => txtFilePath.Text = value; }
      public string Result { get => txtResult.Text; set => txtResult.Text = value; }

      #endregion

   }
}
