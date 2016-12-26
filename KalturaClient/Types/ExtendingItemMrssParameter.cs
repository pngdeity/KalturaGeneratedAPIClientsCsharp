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
	public class ExtendingItemMrssParameter : ObjectBase
	{
		#region Constants
		public const string XPATH = "xpath";
		public const string IDENTIFIER = "identifier";
		public const string EXTENSION_MODE = "extensionMode";
		#endregion

		#region Private Fields
		private string _Xpath = null;
		private ObjectIdentifier _Identifier;
		private MrssExtensionMode _ExtensionMode = (MrssExtensionMode)Int32.MinValue;
		#endregion

		#region Properties
		public string Xpath
		{
			get { return _Xpath; }
			set 
			{ 
				_Xpath = value;
				OnPropertyChanged("Xpath");
			}
		}
		public ObjectIdentifier Identifier
		{
			get { return _Identifier; }
			set 
			{ 
				_Identifier = value;
				OnPropertyChanged("Identifier");
			}
		}
		public MrssExtensionMode ExtensionMode
		{
			get { return _ExtensionMode; }
			set 
			{ 
				_ExtensionMode = value;
				OnPropertyChanged("ExtensionMode");
			}
		}
		#endregion

		#region CTor
		public ExtendingItemMrssParameter()
		{
		}

		public ExtendingItemMrssParameter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "xpath":
						this._Xpath = propertyNode.InnerText;
						continue;
					case "identifier":
						this._Identifier = ObjectFactory.Create<ObjectIdentifier>(propertyNode);
						continue;
					case "extensionMode":
						this._ExtensionMode = (MrssExtensionMode)ParseEnum(typeof(MrssExtensionMode), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaExtendingItemMrssParameter");
			kparams.AddIfNotNull("xpath", this._Xpath);
			kparams.AddIfNotNull("identifier", this._Identifier);
			kparams.AddIfNotNull("extensionMode", this._ExtensionMode);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case XPATH:
					return "Xpath";
				case IDENTIFIER:
					return "Identifier";
				case EXTENSION_MODE:
					return "ExtensionMode";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}
