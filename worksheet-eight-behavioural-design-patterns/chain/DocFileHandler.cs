using System;

namespace worksheet_eight_behavioural_design_patterns
{
    public class DocFileHandler : IHandler
    {
        public string _handler { get; }

        public DocFileHandler(string textHandler) => _handler = textHandler;

        public IHandler Handler { get; set; }

        public void Process(object file)
        {
            if (file is File f && f.Type == "doc")
            {
                Console.WriteLine($"Process and saving {f.Type} file... by {_handler}");
            }
            else
            {
                if (Handler != null)

                {
                    Console.WriteLine($"{_handler} forwards request to {Handler.GetType().Name}.");
                    Handler.Process(file);
                }
                else
                {
                    Console.WriteLine("File not supported");
                }
            }
        }
    }
}