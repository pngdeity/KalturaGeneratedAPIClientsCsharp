// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2016  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class IpAddressRestriction : BaseRestriction
	{
		#region Constants
		public const string IP_ADDRESS_RESTRICTION_TYPE = "ipAddressRestrictionType";
		public const string IP_ADDRESS_LIST = "ipAddressList";
		#endregion

		#region Private Fields
		private IpAddressRestrictionType _IpAddressRestrictionType = (IpAddressRestrictionType)Int32.MinValue;
		private string _IpAddressList = null;
		#endregion

		#region Properties
		public IpAddressRestrictionType IpAddressRestrictionType
		{
			get { return _IpAddressRestrictionType; }
			set 
			{ 
				_IpAddressRestrictionType = value;
				OnPropertyChanged("IpAddressRestrictionType");
			}
		}
		public string IpAddressList
		{
			get { return _IpAddressList; }
			set 
			{ 
				_IpAddressList = value;
				OnPropertyChanged("IpAddressList");
			}
		}
		#endregion

		#region CTor
		public IpAddressRestriction()
		{
		}

		public IpAddressRestriction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "ipAddressRestrictionType":
						this._IpAddressRestrictionType = (IpAddressRestrictionType)ParseEnum(typeof(IpAddressRestrictionType), propertyNode.InnerText);
						continue;
					case "ipAddressList":
						this._IpAddressList = propertyNode.InnerText;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIpAddressRestriction");
			kparams.AddIfNotNull("ipAddressRestrictionType", this._IpAddressRestrictionType);
			kparams.AddIfNotNull("ipAddressList", this._IpAddressList);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case IP_ADDRESS_RESTRICTION_TYPE:
					return "IpAddressRestrictionType";
				case IP_ADDRESS_LIST:
					return "IpAddressList";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}
