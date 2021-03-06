// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IContactHistoryService.cs" company="Jan-Cornelius Molnar">
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

using System.Collections.Generic;
using Jcq.IcqProtocol.Contracts;

namespace Jcq.Ux.ViewModel.Contracts
{
    /// <summary>
    ///     Defines a service conctract to load, save, and mange the chat history of contacts.
    /// </summary>
    public interface IContactHistoryService : IContextService
    {
        /// <summary>
        ///     Load the chat history from the local storage.
        /// </summary>
        void Load();

        /// <summary>
        ///     Save the chat history to the local storage.
        /// </summary>
        void Save();

        /// <summary>
        ///     Append a message to the chat history of a given contact.
        /// </summary>
        /// <param name="contact">The contact.</param>
        /// <param name="message">The message.</param>
        void AppendMessage(ContactViewModel contact, MessageViewModel message);

        /// <summary>
        ///     Get the chat history for a given contact.
        /// </summary>
        /// <param name="contact">The contact.</param>
        /// <returns></returns>
        List<MessageViewModel> GetHistory(ContactViewModel contact);

        /// <summary>
        ///     Get the chat history for a given contact.
        /// </summary>
        /// <param name="contact">The contact.</param>
        /// <param name="maxItems">The maximum number of items to return.</param>
        /// <returns></returns>
        List<MessageViewModel> GetHistory(ContactViewModel contact, int maxItems);
    }
}