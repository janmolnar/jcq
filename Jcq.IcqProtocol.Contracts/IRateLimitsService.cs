﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRateLimitsService.cs" company="Jan-Cornelius Molnar">
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

using System;
using System.ComponentModel;
using Jcq.Core.Contracts.Collections;

namespace Jcq.IcqProtocol.Contracts
{
    public interface IRateLimitsService : IContextService
    {
        IReadOnlyNotifyingCollection<IRateLimitsClass> RateLimits { get; }

        event EventHandler RateLimitsReceived;

        int Calculate(int serviceTypeId, int subTypeId);
        void EmergencyThrottle();
    }

    public interface IRateLimitsClass : INotifyPropertyChanged
    {
        string Families { get; }

        long ClassId { get; }
        long WindowSize { get; }
        long ClearLevel { get; }
        long AlertLevel { get; }
        long LimitLevel { get; }
        long DisconnectLevel { get; }
        long CurrentLevel { get; }
        long MaxLevel { get; }
        long LastTime { get; }
        byte CurrentState { get; }

        long Computed { get; }
        long LocalLastTime { get; }
    }
}