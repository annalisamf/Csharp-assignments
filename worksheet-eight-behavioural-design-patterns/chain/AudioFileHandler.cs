using System;

namespace worksheet_eight_behavioural_design_patterns
{
    public class AudioFileHandler : IHandler
    {
        public string _handler { get; }

        public AudioFileHandler(string textHandler) => _handler = textHandler;

        public IHandler Handler { get; set; }

        public void Process(object file)
        {
            if (file is File f && f.Type == "audio")
            {
                Console.WriteLine($"Process and saving {f.Type} file... by {_handler}");
            }


            else if (Handler != null)
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