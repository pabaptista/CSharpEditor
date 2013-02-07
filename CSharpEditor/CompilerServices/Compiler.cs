using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace CSharpEditor.CompilerServices
{
    class Compiler
    {
        /// <summary>
        /// Function to compile .Net C#/VB source codes at runtime 
        /// Adapted from:
        /// (http://www.digitalcoding.com/Code-Snippets/C-Sharp/C-Code-Snippet-Compile-C-or-VB-source-code-run-time.html)
        /// </summary>
        /// <param name="codeProvider">Base class for compiler provider</param>
        /// <param name="sourceCode">C# or VB source code as a string</param>
        /// <param name="sourceFile">External file containing C# or VB source code</param>
        /// <param name="exeFile">File path to create external executable file</param>
        /// <param name="assemblyName">File path to create external assembly file</param>
        /// <param name="resourceFiles">Required resource files to compile the code</param>
        /// <param name="errors">String variable to store any errors occurred during the process</param>
        /// <returns>Return TRUE if successfully compiled the code, else return FALSE</returns>
        public static bool CompileCode(CodeDomProvider codeProvider, string sourceCode, string sourceFile, 
                           string exeFile, string assemblyName, string[] resourceFiles, string[] referencedAssemblies,
                           out string errors, out CompilerResults compilerResults)
        {
            // Define parameters to invoke a compiler
            CompilerParameters compilerParameters = new CompilerParameters();

            if (exeFile != null)
            {
                // Set the assembly file name to generate.
                compilerParameters.OutputAssembly = exeFile;
                // Generate an executable instead of a class library.
                compilerParameters.GenerateExecutable = true;
                compilerParameters.GenerateInMemory = false;
            }
            else if (assemblyName != null)
            {
                // Set the assembly file name to generate.
                compilerParameters.OutputAssembly = assemblyName;
                // Generate a class library instead of an executable.
                compilerParameters.GenerateExecutable = false;
                compilerParameters.GenerateInMemory = false;
            }
            else
            {
                // Generate an in-memory class library instead of an executable.
                compilerParameters.GenerateExecutable = false;
                compilerParameters.GenerateInMemory = true;
            }
            // Generate debug information.
            compilerParameters.IncludeDebugInformation = true;
            // Should start displaying warnings.
            compilerParameters.WarningLevel = 2;
            // Set whether to treat all warnings as errors.
            compilerParameters.TreatWarningsAsErrors = false;
            // Set compiler argument to optimize output.
            compilerParameters.CompilerOptions = "/optimize";
            // Add referenced assemblies
            if (referencedAssemblies != null)
                compilerParameters.ReferencedAssemblies.AddRange(referencedAssemblies);
            // Set a temporary files collection.
            // The TempFileCollection stores the temporary files
            // generated during a build in the current directory,
            // and does not delete them after compilation.
            //compilerParameters.TempFiles = new TempFileCollection(".", true);
            compilerParameters.TempFiles = new TempFileCollection(".", false);

            if (resourceFiles != null && resourceFiles.Length > 0)
            {
                foreach (string _ResourceFile in resourceFiles)
                {
                    // Set the embedded resource file of the assembly.
                    compilerParameters.EmbeddedResources.Add(_ResourceFile);
                }
            }
            try
            {
                // Invoke compilation
                if (sourceFile != null && System.IO.File.Exists(sourceFile))
                    // source code in external file
                    compilerResults = codeProvider.CompileAssemblyFromFile(compilerParameters, sourceFile);
                else
                    // source code pass as a string
                    compilerResults = codeProvider.CompileAssemblyFromSource(compilerParameters, sourceCode);

                if (compilerResults.Errors.Count > 0)
                {
                    // Return compilation errors
                    errors = "";
                    foreach (CompilerError compErr in compilerResults.Errors)
                    {
                        errors += "Line number " + compErr.Line +
                                  ", Column number " + compErr.Column +
                                    ", Error Number: " + compErr.ErrorNumber +
                                    ", '" + compErr.ErrorText + ";\r\n\r\n";
                    }
                    // Return the results of compilation - Failed
                    return false;
                }
                else
                {
                    // no compile errors
                    errors = null;
                }
            }
            catch (Exception exception)
            {
                // Error occurred when trying to compile the code
                errors = exception.Message;
                compilerResults = null;
                return false;
            }
            // Return the results of compilation - Success
            return true;
        }


        [DllImport("Kernel32.dll")]
        static extern Boolean AllocConsole();

        public static void Main()
        {
            if (!AllocConsole())
                MessageBox.Show("Failed to alloc console");



            string errors;
            CompilerResults compilerResults;

            // C# source code pass as a string
            string cSharpSourceCode1 = @"
            using System;
            namespace Test
            {
                public class Program
                {
                    static void Main(string[] args)
                    {
                        Console.WriteLine(""Press ENTER key to start ..."");
                        Console.ReadLine();
                        for (int c = 0; c <= 100; c++)
                            Console.WriteLine(c.ToString());
                    }
                }
            }";

            // Compile C-Sharp code
            CSharpCodeProvider cSharpCodeProvider1 = new CSharpCodeProvider();
            if (Compiler.CompileCode(cSharpCodeProvider1, cSharpSourceCode1, null, 
                            "D:\\Temp\\C-Sharp-test.exe", null, null, null, out errors, out compilerResults))
            {
                Console.WriteLine("Code compiled successfully");
                // Invoking Main
                MethodInfo mi = compilerResults.CompiledAssembly.GetType("Test.Program")
                                    .GetMethod("Main", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
                Console.WriteLine("Invoking {0}", mi.Name);
                mi.Invoke(null, new object[1] { null });
            }
            else
                Console.WriteLine("Error occurred during compilation : \r\n" + errors);

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            /// Another Example
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            CSharpCodeProvider cSharpCodeProvider2 = new CSharpCodeProvider();
            string cSharpSourceCode2 = @"
                public class Foo
                {
                    public int MyProperty { get; set; }
                }
                public static class Bar
                {
                    private static Foo myFooValue = new Foo { MyProperty = 42 };
                    public static Foo MyFoo { get { return myFooValue; } }
                }";

            CompilerResults results;
            if (Compiler.CompileCode(cSharpCodeProvider2, cSharpSourceCode2, null, null, 
                            "D:\\Temp\\C-Sharp-test2.dll", null, null, out errors, out results))
            {
                Console.WriteLine("Code compiled successfully");
                PropertyInfo myPropertyPi = results.CompiledAssembly.GetType("Foo").GetProperty("MyProperty");
                PropertyInfo myFooPi = results.CompiledAssembly.GetType("Bar").GetProperty("MyFoo");
                Object PropertyValue = myPropertyPi.GetValue(myFooPi.GetValue(null, null), null);
                Console.WriteLine("Value of Bar.MyFoo.MyProperty: " + PropertyValue.ToString());
            }
            else
                Console.WriteLine("Error occurred during compilation : \r\n" + errors);


            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

    }
}
