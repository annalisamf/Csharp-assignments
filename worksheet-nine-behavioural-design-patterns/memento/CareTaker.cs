using System;
using System.Collections.Generic;

namespace worksheet_nine_behavioural_design_patterns
{
    public class CareTaker
    {
        private Dictionary<string, Memento> _savepointStorage = new Dictionary<string, Memento>();

        public void SaveMemento(Memento memento, string savepointName)
        {
            Console.WriteLine($"Saving state {savepointName}");
            _savepointStorage.Add(savepointName, memento);
        }

        public Memento Memento(string savepointName)
        {
            Console.WriteLine($"Undo at... {savepointName}");
            return _savepointStorage[savepointName];
        }

        public void ClearSavePoints()
        {
            Console.WriteLine("Clearing all save points...");
            _savepointStorage.Clear();
        }
    }
}