//------------------------------------------------------------------------------
// <copyright file="WindowsFoundationLibrary.cs" 
//  company="Scott Dorman" 
//  library="Cadru">
//    Copyright (C) 2001-2013 Scott Dorman.
// </copyright>
// 
// <license>
//    Licensed under the Microsoft Public License (Ms-PL) (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//    http://opensource.org/licenses/Ms-PL.html
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </license>
//------------------------------------------------------------------------------

namespace Cadru
{
    /// <summary>
    /// Specifies the .NET 3.0 Windows Foundation Library.
    /// </summary>
    public enum WindowsFoundationLibrary
    {
        /// <summary>
        /// Windows Communication Foundation.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "WCF", Justification = "Reviewed.")]
        WCF,

        /// <summary>
        /// Windows Presentation Foundation.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "WPF", Justification = "Reviewed.")]
        WPF,

        /// <summary>
        /// Windows Workflow Foundation.
        /// </summary>
        WF,

        /// <summary>
        /// Windows CardSpace.
        /// </summary>
        CardSpace,
    }
}
