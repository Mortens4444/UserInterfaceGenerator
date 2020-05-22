using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceGenerator
{
	class CustomAttributeChecker
	{
		public static bool HasCustomAttribute<TCustomAttributeType>(ControlType controlType)
		{
			var memberInfo = typeof(ControlType).GetMember(controlType.ToString()).FirstOrDefault();
			if (memberInfo != null)
			{
				return memberInfo.GetCustomAttributes(typeof(TCustomAttributeType), false).FirstOrDefault() != null;
			}

			return false;
		}
	}
}
