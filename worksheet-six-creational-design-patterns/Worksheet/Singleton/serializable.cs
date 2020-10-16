using System;
using System.Runtime.Serialization;

namespace QuestionFive
{
    [Serializable]
    public class SingletonSerial : ISerializable
    {
        private SingletonSerial()
        {
        }

        static SingletonSerial() => Instance = new SingletonSerial();

        public static SingletonSerial Instance { get; }

        public void GetObjectData(SerializationInfo info, StreamingContext context) => info.SetType(typeof(SingletonHelper));

        [Serializable]
        private class SingletonHelper : IObjectReference
        {
            public object GetRealObject(StreamingContext context) => SingletonSerial.Instance;
        }
    }
}