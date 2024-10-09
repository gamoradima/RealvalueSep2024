namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b5af29aa-c2e2-46f6-b84a-2dce11549701");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aa1c37bd-de27-496c-b0e3-b2a9535db7eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,81,107,219,48,16,126,47,244,63,28,102,15,54,4,209,190,174,91,97,9,217,40,148,173,36,78,95,202,30,20,249,226,106,200,146,209,201,105,179,177,255,190,147,229,52,169,211,65,15,131,165,211,119,223,125,223,113,86,54,72,173,84,8,37,122,47,201,109,130,152,57,187,209,117,231,101,208,206,158,159,253,57,63,3,142,142,180,173,97,185,163,128,205,213,113,234,184,176,105,156,253,239,163,71,49,183,65,7,141,244,30,140,152,111,209,134,61,244,161,79,239,250,220,173,102,17,22,125,190,84,143,216,200,239,236,1,62,67,182,34,191,64,105,194,46,43,126,166,162,182,91,27,173,64,25,73,4,233,237,13,26,248,8,83,73,248,198,75,98,25,6,112,68,232,182,44,89,87,8,91,167,43,248,97,151,114,203,70,114,183,254,133,42,0,161,173,208,79,32,17,78,113,195,174,122,218,47,190,38,192,226,64,119,196,28,99,205,42,196,11,219,158,6,139,171,215,176,196,11,190,247,195,198,243,148,40,82,193,8,92,161,210,141,52,208,122,173,226,148,82,149,248,134,161,220,181,88,205,156,233,26,123,47,77,135,159,6,232,117,30,39,121,23,241,243,213,34,27,119,215,27,200,19,217,53,92,94,236,163,120,13,26,25,139,129,226,134,102,210,42,52,88,177,142,224,59,100,230,83,28,5,31,151,130,215,146,100,141,37,54,173,145,33,42,183,248,4,183,78,73,163,127,203,181,193,101,143,203,7,63,43,66,207,123,107,121,254,188,180,98,129,228,58,175,24,228,60,179,76,224,180,79,140,195,202,164,93,203,38,144,157,180,32,209,143,231,134,74,231,166,186,78,183,172,16,165,27,36,20,239,240,193,250,83,66,124,117,190,145,33,31,249,227,198,151,226,98,250,225,100,220,49,194,163,119,79,189,255,249,179,194,54,58,220,215,143,225,127,15,215,225,200,63,254,254,1,62,211,142,167,232,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f7683118-dc17-fbcb-a1c2-859c700c7bc7"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("aa1c37bd-de27-496c-b0e3-b2a9535db7eb"),
				CreatedInSchemaUId = new Guid("b5af29aa-c2e2-46f6-b84a-2dce11549701"),
				ModifiedInSchemaUId = new Guid("b5af29aa-c2e2-46f6-b84a-2dce11549701")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5af29aa-c2e2-46f6-b84a-2dce11549701"));
		}

		#endregion

	}

	#endregion

}

