using System;
using System.IO;
using static System.Console;

namespace _06Oct2016.Lib
{
    public class ExceptionsHandling
    {
        #region Variables
        private const string FileFullPath = @".\Data\file.txt";
        #endregion

        #region Methods
        public ExceptionsHandling DisplayErrorDemo2()
        {
            Write("Enter a number between 1 and 255: ");
            var value1 = byte.Parse(ReadLine().Trim());
            Write("Enter another number between 1 and 255: ");
            var value2 = byte.Parse(ReadLine().Trim());

            try
            {
                var answer = value1 / value2;
                WriteLine($"{value1} divided by {value2} is {answer}");
            }
            catch (Exception errorObject)
            {
                WriteLine($"{errorObject.GetType().Name} :: {errorObject.Message}");
            }
            return this;
        }

        public ExceptionsHandling DisplayErrorDemo1()
        {
            const int number = 500;

            checked
            {
                try
                {
                    for (byte iCtr = 0; iCtr < number; iCtr++)
                    {
                        WriteLine(iCtr);
                    }

                }
                catch (Exception errorObject)
                {
                    WriteLine($"{errorObject.GetType()} :: {errorObject.Message}");
                }
            }

            return this;
        }

        public ExceptionsHandling DisplayUsingDemo()
        {
            using (var file2 = File.OpenWrite(FileFullPath))
            {
                using (var writer2 = new StreamWriter(file2))
                {
                    try
                    {
                        writer2.WriteLine($"{DateTime.Now} :: Hello C#!");
                    }
                    catch (Exception ex)
                    {
                        WriteLine($"{ex.GetType()} says {ex.Message}");
                    }
                }
            }

            return this;
        }

        public ExceptionsHandling DisplayTryCatchFinally()
        {
            FileStream file = null;
            StreamWriter writer = null;

            try
            {
                file = File.OpenWrite(FileFullPath);
                writer = new StreamWriter(file);
                writer.WriteLine($"{DateTime.Now} :: Hello C#!");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            finally
            {
                if (writer != null)
                {
                    writer.Dispose();
                    WriteLine("The writer's unmanaged resources have been disposed.");
                }
                if (file != null)
                {
                    file.Dispose();
                    WriteLine("The file's unmanaged resources have been disposed.");
                }
            }
            return this;
        }

        public ExceptionsHandling DisplayTryCatch()
        {
            WriteLine("Before parsing");
            Write("What is you age? ");
            var input = Console.ReadLine();
            try
            {
                var age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch (OverflowException)
            {
                WriteLine("Your age is a valid number format but it is either too big or small.");
            }
            catch (FormatException)
            {
                WriteLine("The age you entered is not a valid number format.");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After parsing");

            return this;
        }
        #endregion
    }
}
