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
	public class SearchOperator : SearchItem
	{
		#region Constants
		public const string TYPE = "type";
		public const string ITEMS = "items";
		#endregion

		#region Private Fields
		private SearchOperatorType _Type = (SearchOperatorType)Int32.MinValue;
		private IList<SearchItem> _Items;
		#endregion

		#region Properties
		public SearchOperatorType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public IList<SearchItem> Items
		{
			get { return _Items; }
			set 
			{ 
				_Items = value;
				OnPropertyChanged("Items");
			}
		}
		#endregion

		#region CTor
		public SearchOperator()
		{
		}

		public SearchOperator(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "type":
						this._Type = (SearchOperatorType)ParseEnum(typeof(SearchOperatorType), propertyNode.InnerText);
						continue;
					case "items":
						this._Items = new List<SearchItem>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Items.Add(ObjectFactory.Create<SearchItem>(arrayNode));
						}
						continue;
				}
			}
		}

		public SearchOperator(IDictionary<string,object> data) : base(data)
		{
			    this._Type = (SearchOperatorType)ParseEnum(typeof(SearchOperatorType), data.TryGetValueSafe<int>("type"));
			    this._Items = new List<SearchItem>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("items", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._Items.Add(ObjectFactory.Create<SearchItem>((IDictionary<string,object>)dataDictionary));
			    }
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSearchOperator");
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("items", this._Items);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TYPE:
					return "Type";
				case ITEMS:
					return "Items";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

