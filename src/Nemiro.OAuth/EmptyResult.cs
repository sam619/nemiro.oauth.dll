﻿// ----------------------------------------------------------------------------
// Copyright (c) Aleksey Nemiro, 2014-2015. All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;

namespace Nemiro.OAuth
{

  /// <summary>
  /// Represents the empty results of the query.
  /// </summary>
  /// <remarks>
  /// <para>The class is used to determine sends a request to the remote server or not.</para>
  /// </remarks>
  [Serializable]
  public class EmptyResult : RequestResult
  {

    /// <summary>
    /// Gets a value indicating whether the current request result is successful or not.
    /// </summary>
    /// <remarks>Always has the value <b>false</b>.</remarks>
    public new bool IsSuccessfully
    {
      get
      {
        return false;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EmptyResult"/> class.
    /// </summary>
    public EmptyResult() : base(source: new byte[]{0}) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="EmptyResult"/>.
    /// </summary>
    /// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo"/> with data.</param>
    /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for this serialization.</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected EmptyResult(SerializationInfo info, StreamingContext context) : base(info, context) { }

    /// <summary>
    /// Populates a <see cref="System.Runtime.Serialization.SerializationInfo"/> with the data needed to serialize the target object.
    /// </summary>
    /// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo"/> to populate with data.</param>
    /// <param name="context">The destination (see <see cref="System.Runtime.Serialization.StreamingContext"/>) for this serialization.</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      base.GetObjectData(info, context);
    }

  }

}