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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class HttpNotificationDataText : HttpNotificationData
	{
		#region Constants
		public const string CONTENT = "content";
		#endregion

		#region Private Fields
		private StringValue _Content;
		#endregion

		#region Properties
		/// <summary>
		/// Use ContentAsDouble property instead
		/// </summary>
		[JsonProperty]
		public StringValue Content
		{
			get { return _Content; }
			set 
			{ 
				_Content = value;
				OnPropertyChanged("Content");
			}
		}
		#endregion

		#region CTor
		public HttpNotificationDataText()
		{
		}

		public HttpNotificationDataText(JToken node) : base(node)
		{
			if(node["content"] != null)
			{
				this._Content = ObjectFactory.Create<StringValue>(node["content"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaHttpNotificationDataText");
			kparams.AddIfNotNull("content", this._Content);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CONTENT:
					return "Content";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

