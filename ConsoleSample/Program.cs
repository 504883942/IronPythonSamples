using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IronPython.Hosting;
using System.Reflection;
using System.IO;

namespace ConsoleSample {
    class Program {
        static void Main(string[] args) {
            var engine = Python.CreateEngine();
            engine.SetSearchPaths(new[] { "FlippingGame" });
            var scope = engine.ExecuteFile("ConsoleGame.py");
            dynamic begin = scope.GetVariable("GetBeginDate");
            dynamic main = scope.GetVariable("main");
            dynamic dt = scope.GetVariable("EndDate");
            main();

        }

    }
}
