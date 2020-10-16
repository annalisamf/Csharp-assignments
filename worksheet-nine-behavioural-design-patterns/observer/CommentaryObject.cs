using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace observer
{
    public class CommentaryObject : ISubject, ICommentary
    {
        private string _description;
        private List<IObserver> Observers { get; set; }
        private string S { get; set; }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                NotifyObservers();
            }
        }

        public CommentaryObject(List<IObserver> observers, string s)
        {
            Observers = observers;
            S = s;
        }

        public void SubscribeObserver(IObserver observer) => Observers.Add(observer);

        public void UnSubscribeObserver(IObserver observer) => Observers.RemoveAt(Observers.IndexOf(observer));

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update(Description);
            }
        }

        public string SubjectDetails() => S;
    }
}