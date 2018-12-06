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
	public class DeliveryServerNode : ServerNode
	{
		#region Constants
		public const string DELIVERY_PROFILE_IDS = "deliveryProfileIds";
		public const string CONFIG = "config";
		#endregion

		#region Private Fields
		private IList<KeyValue> _DeliveryProfileIds;
		private string _Config = null;
		#endregion

		#region Properties
		public IList<KeyValue> DeliveryProfileIds
		{
			get { return _DeliveryProfileIds; }
			set 
			{ 
				_DeliveryProfileIds = value;
				OnPropertyChanged("DeliveryProfileIds");
			}
		}
		public string Config
		{
			get { return _Config; }
			set 
			{ 
				_Config = value;
				OnPropertyChanged("Config");
			}
		}
		#endregion

		#region CTor
		public DeliveryServerNode()
		{
		}

		public DeliveryServerNode(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "deliveryProfileIds":
						this._DeliveryProfileIds = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._DeliveryProfileIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
					case "config":
						this._Config = propertyNode.InnerText;
						continue;
				}
			}
		}

		public DeliveryServerNode(IDictionary<string,object> data) : base(data)
		{
			    this._DeliveryProfileIds = new List<KeyValue>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("deliveryProfileIds", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._DeliveryProfileIds.Add(ObjectFactory.Create<KeyValue>((IDictionary<string,object>)dataDictionary));
			    }
			    this._Config = data.TryGetValueSafe<string>("config");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDeliveryServerNode");
			kparams.AddIfNotNull("deliveryProfileIds", this._DeliveryProfileIds);
			kparams.AddIfNotNull("config", this._Config);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DELIVERY_PROFILE_IDS:
					return "DeliveryProfileIds";
				case CONFIG:
					return "Config";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

