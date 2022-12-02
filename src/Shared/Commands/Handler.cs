using System;
using System.Collections.Generic;
using System.CommandLine.Binding;
using System.CommandLine.Invocation;
using System.CommandLine.Parsing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.CommandLine;

public static partial class Handler
{
    private static T? GetValueForHandlerParameter<T>(IValueDescriptor<T> symbol, InvocationContext context)
    {
        IValueSource valueSource = symbol as IValueSource;
        object obj;
        if (valueSource != null && valueSource.TryGetValue(symbol, context.BindingContext, out obj) && obj is T)
        {
            return (T)((object)obj);
        }
        return context.ParseResult.GetValueFor<T>(symbol);
    }

}


public static class ParseResultExt
{

    public static T? GetValueFor<T>(this ParseResult result ,IValueDescriptor<T> symbol)
    {
        switch (symbol)
        {
            case Argument<T>: return result.GetValueForArgument<T>(symbol as Argument<T>);
            case Option<T>: return result.GetValueForOption<T>(symbol as Option<T>);
        }
        throw new ArgumentOutOfRangeException();
    }


}