using System;
using System.Windows.Forms;
using IronPython.Compiler;
using IronPython.Hosting;
using IronPython.Modules;
using IronPython.Runtime;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
namespace IronPythonStarterTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //MessageBox.Show("hello");
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            var py = "def Test():\n" +
                     "  return 'hello, world'";
            MessageBox.Show(py);
            var code = engine.CreateScriptSourceFromString(py, SourceCodeKind.Statements);
            code.Execute(scope);
            var Test = scope.GetVariable<Func<String>>("Test");
            MessageBox.Show(Test());
        }
    }
}