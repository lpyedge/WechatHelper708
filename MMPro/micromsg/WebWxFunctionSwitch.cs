using ProtoBuf;
using System;

namespace micromsg
{
	[ProtoContract(Name = "WebWxFunctionSwitch")]
	[Serializable]
	public class WebWxFunctionSwitch : IExtensible
	{
		private uint _FunctionId;

		private uint _SwitchValue;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "FunctionId", DataFormat = DataFormat.TwosComplement)]
		public uint FunctionId
		{
			get
			{
				return this._FunctionId;
			}
			set
			{
				this._FunctionId = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "SwitchValue", DataFormat = DataFormat.TwosComplement)]
		public uint SwitchValue
		{
			get
			{
				return this._SwitchValue;
			}
			set
			{
				this._SwitchValue = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
