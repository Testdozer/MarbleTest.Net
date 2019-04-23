using System;
using System.Reactive;

namespace MarbleTest.Net
{
    public interface ISetupTest
    {
        void ToBe(string marble, 
            object values = null, 
            Exception errorValue = null,
            Func<Notification<object>, Notification<object>, bool> comparer = null);
    }
}
