using System;

namespace MarbleTest.Net
{
    public interface ISetupTest
    {
        void ToBe(string marble, 
            object values = null, 
            Exception errorValue = null,
            Func<object, object, bool> comparer = null);
    }
}
