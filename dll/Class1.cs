using System;

namespace dll {
	public class Class1 {
		[MyAttr(null)]
		public static int test;
	}

	class MyAttrAttribute : Attribute {
		public MyAttrAttribute(System.Type t) {}
	}
}
