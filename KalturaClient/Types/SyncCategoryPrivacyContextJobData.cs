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
	public class SyncCategoryPrivacyContextJobData : JobData
	{
		#region Constants
		public const string CATEGORY_ID = "categoryId";
		public const string LAST_UPDATED_CATEGORY_ENTRY_CREATED_AT = "lastUpdatedCategoryEntryCreatedAt";
		public const string LAST_UPDATED_CATEGORY_CREATED_AT = "lastUpdatedCategoryCreatedAt";
		#endregion

		#region Private Fields
		private int _CategoryId = Int32.MinValue;
		private int _LastUpdatedCategoryEntryCreatedAt = Int32.MinValue;
		private int _LastUpdatedCategoryCreatedAt = Int32.MinValue;
		#endregion

		#region Properties
		public int CategoryId
		{
			get { return _CategoryId; }
			set 
			{ 
				_CategoryId = value;
				OnPropertyChanged("CategoryId");
			}
		}
		public int LastUpdatedCategoryEntryCreatedAt
		{
			get { return _LastUpdatedCategoryEntryCreatedAt; }
			set 
			{ 
				_LastUpdatedCategoryEntryCreatedAt = value;
				OnPropertyChanged("LastUpdatedCategoryEntryCreatedAt");
			}
		}
		public int LastUpdatedCategoryCreatedAt
		{
			get { return _LastUpdatedCategoryCreatedAt; }
			set 
			{ 
				_LastUpdatedCategoryCreatedAt = value;
				OnPropertyChanged("LastUpdatedCategoryCreatedAt");
			}
		}
		#endregion

		#region CTor
		public SyncCategoryPrivacyContextJobData()
		{
		}

		public SyncCategoryPrivacyContextJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "categoryId":
						this._CategoryId = ParseInt(propertyNode.InnerText);
						continue;
					case "lastUpdatedCategoryEntryCreatedAt":
						this._LastUpdatedCategoryEntryCreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "lastUpdatedCategoryCreatedAt":
						this._LastUpdatedCategoryCreatedAt = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public SyncCategoryPrivacyContextJobData(IDictionary<string,object> data) : base(data)
		{
			    this._CategoryId = data.TryGetValueSafe<int>("categoryId");
			    this._LastUpdatedCategoryEntryCreatedAt = data.TryGetValueSafe<int>("lastUpdatedCategoryEntryCreatedAt");
			    this._LastUpdatedCategoryCreatedAt = data.TryGetValueSafe<int>("lastUpdatedCategoryCreatedAt");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSyncCategoryPrivacyContextJobData");
			kparams.AddIfNotNull("categoryId", this._CategoryId);
			kparams.AddIfNotNull("lastUpdatedCategoryEntryCreatedAt", this._LastUpdatedCategoryEntryCreatedAt);
			kparams.AddIfNotNull("lastUpdatedCategoryCreatedAt", this._LastUpdatedCategoryCreatedAt);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATEGORY_ID:
					return "CategoryId";
				case LAST_UPDATED_CATEGORY_ENTRY_CREATED_AT:
					return "LastUpdatedCategoryEntryCreatedAt";
				case LAST_UPDATED_CATEGORY_CREATED_AT:
					return "LastUpdatedCategoryCreatedAt";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

