using System;
using System.Windows.Forms;
using IronPython.Compiler;
using IronPython.Hosting;
using IronPython.Modules;
using IronPython.Runtime;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;  
namespace IronPythonStarterTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            ScriptRuntime pyRuntime = Python.CreateRuntime();
            dynamic scriptScope = pyRuntime.UseFile("main.py");
            try
            {
                scriptScope.main(args);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ZPyFrame启动器：Python代码执行抛出未处理的异常！\n错误类型：\n" + ex.GetType().ToString() +
                "\n详细信息：\n" + ex.Message, "ZPyWFrame启动器", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}