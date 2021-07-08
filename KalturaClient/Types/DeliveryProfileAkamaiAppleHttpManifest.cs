// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2021  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class DeliveryProfileAkamaiAppleHttpManifest : DeliveryProfile
	{
		#region Constants
		public const string SUPPORT_CLIPPING = "supportClipping";
		#endregion

		#region Private Fields
		private bool? _SupportClipping = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use SupportClippingAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? SupportClipping
		{
			get { return _SupportClipping; }
			set 
			{ 
				_SupportClipping = value;
				OnPropertyChanged("SupportClipping");
			}
		}
		#endregion

		#region CTor
		public DeliveryProfileAkamaiAppleHttpManifest()
		{
		}

		public DeliveryProfileAkamaiAppleHttpManifest(JToken node) : base(node)
		{
			if(node["supportClipping"] != null)
			{
				this._SupportClipping = ParseBool(node["supportClipping"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDeliveryProfileAkamaiAppleHttpManifest");
			kparams.AddIfNotNull("supportClipping", this._SupportClipping);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SUPPORT_CLIPPING:
					return "SupportClipping";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

