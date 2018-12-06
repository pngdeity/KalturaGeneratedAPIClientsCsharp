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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class EntryIdentifier : ObjectIdentifier
	{
		#region Constants
		public const string IDENTIFIER = "identifier";
		#endregion

		#region Private Fields
		private EntryIdentifierField _Identifier = null;
		#endregion

		#region Properties
		public EntryIdentifierField Identifier
		{
			get { return _Identifier; }
			set 
			{ 
				_Identifier = value;
				OnPropertyChanged("Identifier");
			}
		}
		#endregion

		#region CTor
		public EntryIdentifier()
		{
		}

		public EntryIdentifier(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "identifier":
						this._Identifier = (EntryIdentifierField)StringEnum.Parse(typeof(EntryIdentifierField), propertyNode.InnerText);
						continue;
				}
			}
		}

		public EntryIdentifier(IDictionary<string,object> data) : base(data)
		{
			    this._Identifier = (EntryIdentifierField)StringEnum.Parse(typeof(EntryIdentifierField), data.TryGetValueSafe<string>("identifier"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryIdentifier");
			kparams.AddIfNotNull("identifier", this._Identifier);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case IDENTIFIER:
					return "Identifier";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

