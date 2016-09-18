﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="LateStartStudio">
//   Copyright (C) LateStartStudio
//   This file is subject to the terms and conditions of the MIT license specified
//   in the file 'LICENSE.CODE.md', which is a part of this source code package.
// </copyright>
// <summary>
//   Defines the Node type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LateStartStudio.Collections.Tests.Generic
{
    using Priority_Queue;

    /// <summary>
    /// A simple Node class to use for generic tests.
    /// </summary>
    public partial class Node
    {
        private readonly int id;

        public Node(int id)
        {
            this.id = id;
        }

        public int ID
        {
            get { return this.id; }
        }
    }

    /// <summary>
    /// Hack extension. The Optimized Priority Queue framework requires any node to extend from
    /// FastPrioirtyQueueNode. The extensions is separated to itself here to make it easy to remove
    /// if we ever need to.
    /// </summary>
    public partial class Node : FastPriorityQueueNode
    {
    }
}