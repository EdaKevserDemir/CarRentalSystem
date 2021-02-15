using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public interface IDataResult<T>:IResult // IResult içindeki success ve massage a bir de data ekleyebilir artık.
    {
        T Data { get; }
    }
}
