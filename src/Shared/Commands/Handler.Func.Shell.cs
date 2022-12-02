using System;
using System.Collections.Generic;
using System.CommandLine.Binding;
using System.CommandLine.Invocation;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.Shared.Enums;

namespace System.CommandLine
{

    /// <summary>
    /// Provides methods for creating and working with command handlers.
    /// </summary>
    public static partial class Handler
    {
        /// <summary>
        /// Sets a command's handler based on a <see cref="Func{Task}"/>.
        /// </summary>
        public static void SetHandler(
            this Command command,
            Func<Task> handle,
            UserRank requiredRank)
        {

            var h = new MyAnonymousCommandHandler(_ => handle());
            h.RequiredRank = requiredRank;

            command.Handler = h;
        }

        /// <summary>
        /// Sets a command's handler based on a <see cref="Func{Task,InvocationContext}"/>.
        /// </summary>
        public static void SetHandler(
            this Command command,
            Func<IConsole, Task> handle,
            UserRank requiredRank
            )
        {

            var h = new MyAnonymousCommandHandler(context =>
            {
                return handle(context.Console);
            });
            h.RequiredRank = requiredRank;

            command.Handler = h;
        }

        /// <summary>
        /// Sets a command's handler based on a <see cref="Func{T,Task}"/>.
        /// </summary>
        public static void SetHandler<T>(
            this Command command,
            Func<IConsole, T, Task> handle,
            UserRank requiredRank,
            IValueDescriptor<T> symbol)
        {

            var h = new MyAnonymousCommandHandler(
                context =>
                {
                    var value1 = GetValueForHandlerParameter(symbol, context);
                    return handle(context.Console, value1!);
                });
            h.RequiredRank = requiredRank;

            command.Handler = h;
            
        }

        /// <summary>
        /// Sets a command's handler based on a <see cref="Func{T1,T2,Task}"/>.
        /// </summary>
        public static void SetHandler<T1, T2>(
            this Command command,
            Func<IConsole, T1, T2, Task> handle,
            UserRank requiredRank,
            IValueDescriptor<T1> symbol1,
            IValueDescriptor<T2> symbol2)
        {

            var h = new MyAnonymousCommandHandler(
                context =>
                {
                    var value1 = GetValueForHandlerParameter(symbol1, context);
                    var value2 = GetValueForHandlerParameter(symbol2, context);

                    return handle(context.Console, value1!, value2!);
                });
            h.RequiredRank = requiredRank;

            command.Handler = h;
        }

        /// <summary>
        /// Sets a command's handler based on a <see cref="Func{T1,T2,T3,Task}"/>.
        /// </summary>
        public static void SetHandler<T1, T2, T3>(
            this Command command,
            Func<IConsole, T1, T2, T3, Task> handle,
            UserRank requiredRank,
            IValueDescriptor<T1> symbol1,
            IValueDescriptor<T2> symbol2,
            IValueDescriptor<T3> symbol3)
        {

            var h = new MyAnonymousCommandHandler(
                context =>
                {
                    var value1 = GetValueForHandlerParameter(symbol1, context);
                    var value2 = GetValueForHandlerParameter(symbol2, context);
                    var value3 = GetValueForHandlerParameter(symbol3, context);

                    return handle(context.Console, value1!, value2!, value3!);
                });
            h.RequiredRank = requiredRank;

            command.Handler = h;
        }

        /// <summary>
        /// Sets a command's handler based on a <see cref="Func{T1,T2,T3,T4,Task}"/>.
        /// </summary>
        public static void SetHandler<T1, T2, T3, T4>(
            this Command command,
            Func<IConsole, T1, T2, T3, T4, Task> handle,
            UserRank requiredRank,
            IValueDescriptor<T1> symbol1,
            IValueDescriptor<T2> symbol2,
            IValueDescriptor<T3> symbol3,
            IValueDescriptor<T4> symbol4)
        {

            var h = new MyAnonymousCommandHandler(
                context =>
                {
                    var value1 = GetValueForHandlerParameter(symbol1, context);
                    var value2 = GetValueForHandlerParameter(symbol2, context);
                    var value3 = GetValueForHandlerParameter(symbol3, context);
                    var value4 = GetValueForHandlerParameter(symbol4, context);

                    return handle(context.Console, value1!, value2!, value3!, value4!);
                });
            h.RequiredRank = requiredRank;

            command.Handler = h;
        }



        

        /// <summary>
        /// Sets a command's handler based on a <see cref="Func{T1,T2,T3,T4,T5,Task}"/>.
        /// </summary>
        public static void SetHandler<T1, T2, T3, T4, T5>(
            this Command command,
            Func<IConsole, T1, T2, T3, T4, T5, Task> handle,
            UserRank requiredRank,
            IValueDescriptor<T1> symbol1,
            IValueDescriptor<T2> symbol2,
            IValueDescriptor<T3> symbol3,
            IValueDescriptor<T4> symbol4,
            IValueDescriptor<T5> symbol5)
        {

            var h = new MyAnonymousCommandHandler(
                context =>
                {
                    var value1 = GetValueForHandlerParameter(symbol1, context);
                    var value2 = GetValueForHandlerParameter(symbol2, context);
                    var value3 = GetValueForHandlerParameter(symbol3, context);
                    var value4 = GetValueForHandlerParameter(symbol4, context);
                    var value5 = GetValueForHandlerParameter(symbol5, context);

                    return handle(context.Console, value1!, value2!, value3!, value4!, value5!);
                });

            h.RequiredRank = requiredRank;

            command.Handler = h;
        }


        /// <summary>
        /// Sets a command's handler based on a <see cref="Func{T1,T2,T3,T4,T5,T6,Task}"/>.
        /// </summary>
        public static void SetHandler<T1, T2, T3, T4, T5, T6>(
            this Command command,
            Func<IConsole, T1, T2, T3, T4, T5, T6, Task> handle,
            UserRank requiredRank,
            IValueDescriptor<T1> symbol1,
            IValueDescriptor<T2> symbol2,
            IValueDescriptor<T3> symbol3,
            IValueDescriptor<T4> symbol4,
            IValueDescriptor<T5> symbol5,
            IValueDescriptor<T6> symbol6)
        {

            var h = new MyAnonymousCommandHandler(
                context =>
                {
                    var value1 = GetValueForHandlerParameter(symbol1, context);
                    var value2 = GetValueForHandlerParameter(symbol2, context);
                    var value3 = GetValueForHandlerParameter(symbol3, context);
                    var value4 = GetValueForHandlerParameter(symbol4, context);
                    var value5 = GetValueForHandlerParameter(symbol5, context);
                    var value6 = GetValueForHandlerParameter(symbol6, context);

                    return handle(context.Console, value1!, value2!, value3!, value4!, value5!, value6!);
                });
            h.RequiredRank = requiredRank;

            command.Handler = h;
        }

        /// <summary>
        /// Sets a command's handler based on a <see cref="Func{T1,T2,T3,T4,T5,T6,T7,Task}"/>.
        /// </summary>
        public static void SetHandler<T1, T2, T3, T4, T5, T6, T7>(
            this Command command,
            Func<IConsole, T1, T2, T3, T4, T5, T6, T7, Task> handle,
            UserRank requiredRank,
            IValueDescriptor<T1> symbol1,
            IValueDescriptor<T2> symbol2,
            IValueDescriptor<T3> symbol3,
            IValueDescriptor<T4> symbol4,
            IValueDescriptor<T5> symbol5,
            IValueDescriptor<T6> symbol6,
            IValueDescriptor<T7> symbol7)
        {

            var h = new MyAnonymousCommandHandler(
                context =>
                {
                    var value1 = GetValueForHandlerParameter(symbol1, context);
                    var value2 = GetValueForHandlerParameter(symbol2, context);
                    var value3 = GetValueForHandlerParameter(symbol3, context);
                    var value4 = GetValueForHandlerParameter(symbol4, context);
                    var value5 = GetValueForHandlerParameter(symbol5, context);
                    var value6 = GetValueForHandlerParameter(symbol6, context);
                    var value7 = GetValueForHandlerParameter(symbol7, context);

                    return handle(context.Console, value1!, value2!, value3!, value4!, value5!, value6!, value7!);
                });
            h.RequiredRank = requiredRank;

            command.Handler = h;
        }

        /// <summary>
        /// Sets a command's handler based on a <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,Task}"/>.
        /// </summary>
        public static void SetHandler<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Command command,
            Func<IConsole, T1, T2, T3, T4, T5, T6, T7, T8, Task> handle,
            UserRank requiredRank,
            IValueDescriptor<T1> symbol1,
            IValueDescriptor<T2> symbol2,
            IValueDescriptor<T3> symbol3,
            IValueDescriptor<T4> symbol4,
            IValueDescriptor<T5> symbol5,
            IValueDescriptor<T6> symbol6,
            IValueDescriptor<T7> symbol7,
            IValueDescriptor<T8> symbol8)
        {

            var h = new MyAnonymousCommandHandler(
                context =>
                {
                    var value1 = GetValueForHandlerParameter(symbol1, context);
                    var value2 = GetValueForHandlerParameter(symbol2, context);
                    var value3 = GetValueForHandlerParameter(symbol3, context);
                    var value4 = GetValueForHandlerParameter(symbol4, context);
                    var value5 = GetValueForHandlerParameter(symbol5, context);
                    var value6 = GetValueForHandlerParameter(symbol6, context);
                    var value7 = GetValueForHandlerParameter(symbol7, context);
                    var value8 = GetValueForHandlerParameter(symbol8, context);

                    return handle(context.Console, value1!, value2!, value3!, value4!, value5!, value6!, value7!, value8!);
                });
            h.RequiredRank = requiredRank;

            command.Handler= h;
        }
    }
}
