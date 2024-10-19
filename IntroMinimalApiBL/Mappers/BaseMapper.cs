using System;
using IntroMinimalApiBL.Models;

namespace IntroMinimalApiBL.Mappers;

public static class BaseMapper<TInputClass, TOutputClass>
where TInputClass : class
where TOutputClass : class
{
    public static TOutputClass MapToModel(TInputClass inputValue)
    {
        if (inputValue is { }) return default(TOutputClass);

        var newInstance = Activator.CreateInstance<TOutputClass>();

        var inputProps = inputValue.GetType().GetProperties();
        var outputProps = inputValue.GetType().GetProperties();

        foreach (var inputProp in inputProps)
        {
            var targetProp = outputProps.FirstOrDefault(_ => _.Name == inputProp.Name);
            if (targetProp is null) continue;

            targetProp.SetValue(newInstance, inputProp.GetValue(inputValue));
        }
        return newInstance;
    }
}
