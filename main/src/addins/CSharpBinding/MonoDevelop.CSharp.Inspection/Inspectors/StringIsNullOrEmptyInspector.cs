// 
// StringIsNullOrEmptyInspector.cs
//  
// Author:
//       Mike Krüger <mkrueger@novell.com>
// 
// Copyright (c) 2011 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using ICSharpCode.NRefactory.CSharp;
using ICSharpCode.NRefactory.PatternMatching;
using MonoDevelop.Core;
using MonoDevelop.AnalysisCore;
using MonoDevelop.CSharp.ContextAction;
using ICSharpCode.NRefactory.TypeSystem;
using MonoDevelop.Inspection;

namespace MonoDevelop.CSharp.Inspection
{
	public class StringIsNullOrEmptyInspector : NRefactoryInspectorWrapper<ICSharpCode.NRefactory.CSharp.Refactoring.StringIsNullOrEmptyInspector>
	{
		public override string Category {
			get {
				return DefaultInspectionCategories.Improvements;
			}
		}

		public override string Title {
			get {
				return GettextCatalog.GetString ("Use string.IsNullOrEmpty");
			}
		}

		public override string Description {
			get {
				return GettextCatalog.GetString ("Uses shorter string.IsNullOrEmpty call instead of a longer condition.");
			}
		}

		public StringIsNullOrEmptyInspector ()
		{
			inspector.Title = GettextCatalog.GetString ("Use string.IsNullOrEmpty");
		}

	}
}

