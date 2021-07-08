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
	public class ReportExportResponse : ObjectBase
	{
		#region Constants
		public const string REFERENCE_JOB_ID = "referenceJobId";
		public const string REPORT_EMAIL = "reportEmail";
		#endregion

		#region Private Fields
		private long _ReferenceJobId = long.MinValue;
		private string _ReportEmail = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ReferenceJobIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ReferenceJobId
		{
			get { return _ReferenceJobId; }
			set 
			{ 
				_ReferenceJobId = value;
				OnPropertyChanged("ReferenceJobId");
			}
		}
		/// <summary>
		/// Use ReportEmailAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ReportEmail
		{
			get { return _ReportEmail; }
			set 
			{ 
				_ReportEmail = value;
				OnPropertyChanged("ReportEmail");
			}
		}
		#endregion

		#region CTor
		public ReportExportResponse()
		{
		}

		public ReportExportResponse(JToken node) : base(node)
		{
			if(node["referenceJobId"] != null)
			{
				this._ReferenceJobId = ParseLong(node["referenceJobId"].Value<string>());
			}
			if(node["reportEmail"] != null)
			{
				this._ReportEmail = node["reportEmail"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaReportExportResponse");
			kparams.AddIfNotNull("referenceJobId", this._ReferenceJobId);
			kparams.AddIfNotNull("reportEmail", this._ReportEmail);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case REFERENCE_JOB_ID:
					return "ReferenceJobId";
				case REPORT_EMAIL:
					return "ReportEmail";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

