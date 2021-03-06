using System;

namespace IL2CPU.API.Attribs {
	[AttributeUsage(AttributeTargets.Class, AllowMultiple=true)]
	public sealed class PlugField: Attribute {
		public PlugField() {
		}

		public string FieldId {
			get;
			set;
		}

		public bool IsExternalValue {
			get;
			set;
		}

		public Type FieldType {
			get;
			set;
		}

	}
}
