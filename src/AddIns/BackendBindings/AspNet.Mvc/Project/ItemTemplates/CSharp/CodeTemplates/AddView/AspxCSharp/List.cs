﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICSharpCode.AspNet.Mvc.AspxCSharp {
    using ICSharpCode.AspNet.Mvc;
    using System.Collections.Generic;
    using System.Reflection;
    using System;
    
    
    public partial class List : ListBase {
        
        private global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost hostValue;
        
        
        #line 86 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

	MvcTextTemplateHost MvcHost {
		get { return (MvcTextTemplateHost)Host; }
	}
	
	public class ModelProperty
	{
		public string Name { get; set; }
	}
	
	public string GetViewPageType()
	{
		string viewDataTypeName = MvcHost.ViewDataTypeName;
		if (!String.IsNullOrEmpty(viewDataTypeName)) {
			return String.Format("<{0}>", viewDataTypeName);
		}
		return String.Empty;
	}
	
	List<ModelProperty> modelProperties;
	
	List<ModelProperty> ModelProperties {
		get {
			if (modelProperties == null) {
				modelProperties = new List<ModelProperty>(GetModelProperties());
			}
			return modelProperties;
		}
	}
	
	bool ModelHasProperties {
		get { return ModelProperties.Count > 0; }
	}
	
	public IEnumerable<ModelProperty> GetModelProperties()
	{
		var properties = new List<ModelProperty>();
		foreach (PropertyInfo propertyInfo in MvcHost.GetViewDataTypeProperties()) {
			properties.Add(CreateModelProperty(propertyInfo));
		}
		return properties;
	}
	
	ModelProperty CreateModelProperty(PropertyInfo propertyInfo)
	{
		return new ModelProperty() { Name = propertyInfo.Name };
	}

        #line default
        #line hidden
        
        
        public global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost Host {
            get {
                return this.hostValue;
            }
            set {
                this.hostValue = value;
            }
        }
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 5 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
 if (MvcHost.IsPartialView) { 
            
            #line default
            #line hidden
            
            #line 6 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("<%@ Control Language=\"C#\" Inherits=\"System.Web.Mvc.ViewUserControl<IEnumerable");
            
            #line default
            #line hidden
            
            #line 6 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( GetViewPageType() ));
            
            #line default
            #line hidden
            
            #line 6 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(">\" %>\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 8 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
 } else if (MvcHost.IsContentPage) { 
            
            #line default
            #line hidden
            
            #line 9 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("<%@ Page Language=\"C#\" MasterPageFile=\"");
            
            #line default
            #line hidden
            
            #line 9 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MvcHost.MasterPageFile ));
            
            #line default
            #line hidden
            
            #line 9 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("\" Inherits=\"System.Web.Mvc.ViewPage<IEnumerable");
            
            #line default
            #line hidden
            
            #line 9 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( GetViewPageType() ));
            
            #line default
            #line hidden
            
            #line 9 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(">\" %>\r\n\r\n<asp:Content ID=\"Content1\" ContentPlaceHolderID=\"Title\" runat=\"server\">\r" +
                    "\n");
            
            #line default
            #line hidden
            
            #line 12 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MvcHost.ViewName ));
            
            #line default
            #line hidden
            
            #line 12 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("\r\n</asp:Content>\r\n\r\n<asp:Content ID=\"Content2\" ContentPlaceHolderID=\"");
            
            #line default
            #line hidden
            
            #line 15 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MvcHost.PrimaryContentPlaceHolderID ));
            
            #line default
            #line hidden
            
            #line 15 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("\" runat=\"server\">\r\n");
            
            #line default
            #line hidden
            
            #line 16 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

		PushIndent("\t");
	} else {

            
            #line default
            #line hidden
            
            #line 20 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("<%@ Page Language=\"C#\" Inherits=\"System.Web.Mvc.ViewPage<IEnumerable");
            
            #line default
            #line hidden
            
            #line 20 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( GetViewPageType() ));
            
            #line default
            #line hidden
            
            #line 20 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(">\" %>\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n\t<head runat=\"server\">\r\n\t\t<title>");
            
            #line default
            #line hidden
            
            #line 25 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MvcHost.ViewName ));
            
            #line default
            #line hidden
            
            #line 25 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("</title>\r\n\t</head>\r\n\t<body>\r\n");
            
            #line default
            #line hidden
            
            #line 28 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
 
		PushIndent("\t\t");
	} 

            
            #line default
            #line hidden
            
            #line 32 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("<p>\r\n\t<%: Html.ActionLink(\"Create\", \"Create\") %>\r\n</p>\r\n<table>\r\n");
            
            #line default
            #line hidden
            
            #line 36 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

	if (ModelHasProperties) {
		foreach (ModelProperty modelProperty in ModelProperties) {

            
            #line default
            #line hidden
            
            #line 40 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("\t<tr>\r\n\t\t<th>\r\n\t\t\t<%: Html.LabelFor(model => model.");
            
            #line default
            #line hidden
            
            #line 42 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( modelProperty.Name ));
            
            #line default
            #line hidden
            
            #line 42 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(") %>\r\n\t\t</th>\r\n\t\t<th></th>\r\n\t</tr>\r\n\t\r\n");
            
            #line default
            #line hidden
            
            #line 47 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

		}
	} 

            
            #line default
            #line hidden
            
            #line 51 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("<% foreach (var item in Model) { %>\r\n\t<tr>\r\n");
            
            #line default
            #line hidden
            
            #line 53 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

	if (ModelHasProperties) {
		foreach (ModelProperty modelProperty in ModelProperties) {

            
            #line default
            #line hidden
            
            #line 57 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("\t\t<td>\r\n\t\t\t<%: Html.DisplayFor(model => model.");
            
            #line default
            #line hidden
            
            #line 58 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( modelProperty.Name ));
            
            #line default
            #line hidden
            
            #line 58 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write(") %>\r\n\t\t</td>\r\n");
            
            #line default
            #line hidden
            
            #line 60 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

		}
	}

            
            #line default
            #line hidden
            
            #line 64 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("\t\t<td>\r\n\t\t\t<%: Html.ActionLink(\"Edit\", \"Edit\") %> |\r\n\t\t\t<%: Html.ActionLink(\"Deta" +
                    "ils\", \"Details\") %> |\r\n\t\t\t<%: Html.ActionLink(\"Delete\", \"Delete\") %>\r\n\t\t</td>\r\n\t" +
                    "</tr>\r\n<% } %>\r\n</table>\r\n");
            
            #line default
            #line hidden
            
            #line 72 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

	if (MvcHost.IsPartialView) {
		// Do nothing.
	} else if (MvcHost.IsContentPage) {
		PopIndent();

            
            #line default
            #line hidden
            
            #line 78 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("</asp:Content>\r\n");
            
            #line default
            #line hidden
            
            #line 79 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"

	} else { 
		PopIndent();

            
            #line default
            #line hidden
            
            #line 83 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
            this.Write("\t</body>\r\n</html>\r\n");
            
            #line default
            #line hidden
            
            #line 85 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\AspxCSharp\List.tt"
 } 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        protected virtual void Initialize() {
        }
    }
    
    public class ListBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private bool endsWithNewline;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            if (string.IsNullOrEmpty(textToAppend)) {
                return;
            }
            if ((((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline) 
                        && (this.CurrentIndent.Length > 0))) {
                this.GenerationEnvironment.Append(this.CurrentIndent);
            }
            this.endsWithNewline = false;
            char last = textToAppend[(textToAppend.Length - 1)];
            if (((last == '\n') 
                        || (last == '\r'))) {
                this.endsWithNewline = true;
            }
            if ((this.CurrentIndent.Length == 0)) {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            int lastNewline = 0;
            for (int i = 0; (i 
                        < (textToAppend.Length - 1)); i = (i + 1)) {
                char c = textToAppend[i];
                if ((c == '\r')) {
                    if ((textToAppend[(i + 1)] == '\n')) {
                        i = (i + 1);
                        if ((i 
                                    == (textToAppend.Length - 1))) {
                            goto breakLoop;
                        }
                    }
                }
                else {
                    if ((c != '\n')) {
                        goto continueLoop;
                    }
                }
                i = (i + 1);
                int len = (i - lastNewline);
                if ((len > 0)) {
                    this.GenerationEnvironment.Append(textToAppend, lastNewline, (i - lastNewline));
                }
                this.GenerationEnvironment.Append(this.CurrentIndent);
                lastNewline = i;
            continueLoop:
                ;
            }
        breakLoop:
            if ((lastNewline > 0)) {
                this.GenerationEnvironment.Append(textToAppend, lastNewline, (textToAppend.Length - lastNewline));
            }
            else {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        
        public void Write(string format, params object[] args) {
            this.Write(string.Format(format, args));
        }
        
        public void WriteLine(string textToAppend) {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        
        public void WriteLine(string format, params object[] args) {
            this.WriteLine(string.Format(format, args));
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((this.formatProvider == null)) {
                        throw new global::System.ArgumentNullException("formatProvider");
                    }
                    this.formatProvider = value;
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
