using System;
using IntroMinimalApiBL.Models;
using Newtonsoft.Json;

namespace IntroMinimalApiBL.Mappers;

public static class BaseMapper<TInputClass, TOutputClass>
where TInputClass : class
where TOutputClass : class
{
    public static TOutputClass MapToModel(TInputClass inputValue)
    {
        if (inputValue is not { }) return default(TOutputClass);

        var jsonString = JsonConvert.SerializeObject(inputValue);

        var newInstance = JsonConvert.DeserializeObject<TOutputClass>(jsonString);

        return newInstance;
    }
}
