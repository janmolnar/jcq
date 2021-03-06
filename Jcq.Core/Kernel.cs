// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Kernel.cs" company="Jan-Cornelius Molnar">
// The MIT License (MIT)
// 
// Copyright (c) 2015 Jan-Cornelius Molnar
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Jcq.Core.Contracts;
using Jcq.Core.Contracts.Exceptions;

namespace Jcq.Core
{
    public static class Kernel
    {
        static Kernel()
        {
            // order of initialization is important since Services.GetService depends on Kernel.Mapper.
            Mapper = new Mapper();
            Services = new ServiceProvider<IService>();
            Exceptions = Services.GetService<IExceptionService>();
            Logger = Services.GetService<ILoggingService>();
        }

        /// <summary>
        ///     Gets the default IServiceProvider implementation.
        /// </summary>
        public static IServiceProvider<IService> Services { get; }

        /// <summary>
        ///     Gets the default IExceptionService implementation.
        /// </summary>
        public static IExceptionService Exceptions { get; }

        /// <summary>
        ///     Gets the default ILoggingService implementation.
        /// </summary>
        public static ILoggingService Logger { get; }

        /// <summary>
        ///     Gets the default IMapper implementation.
        /// </summary>
        public static IMapper Mapper { get; }
    }
}