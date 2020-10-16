using System;
using System.ComponentModel.DataAnnotations;

namespace worksheet_nine_behavioural_design_patterns
{
    public class Originator
    {
        private CareTaker _careTaker;
        private string _lastUndoSavepoint;
        public double X { get; set; }
        public double Y { get; set; }

        public Originator(double x, double y, CareTaker careTaker)
        {
            _careTaker = careTaker;
            X = x;
            Y = y;
            CreateSavePoint("INITIAL");
        }

        public void CreateSavePoint(string savepointName)
        {
            _careTaker.SaveMemento(new Memento(X, Y), savepointName);
            _lastUndoSavepoint = savepointName;
        }

        public void Undo() => OriginatorState(_lastUndoSavepoint);

        public void Undo(string savepointName) => OriginatorState(savepointName);

        public void UndoAll()
        {
            OriginatorState("INITIAL");
            _careTaker.ClearSavePoints();
        }

        private void OriginatorState(string savepointName)
        {
            Memento memento = _careTaker.Memento(savepointName);
            X = memento.X;
            Y = memento.Y;
        }

        public override string ToString() => $"X: {X}, Y: {Y}";

        public void CreateSavepoint(string save1)
        {
            _careTaker.SaveMemento(new Memento(X, Y), save1);
            _lastUndoSavepoint = save1;
        }
    }
}