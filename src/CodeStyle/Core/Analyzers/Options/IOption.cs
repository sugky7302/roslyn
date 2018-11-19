﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Options
{
    internal interface IOption
    {
        string Feature { get; }
        string Name { get; }
        Type Type { get; }
        object DefaultValue { get; }

        ImmutableArray<OptionStorageLocation> StorageLocations { get; }
    }
}
