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
	public class FreewheelDistributionJobProviderData : DistributionJobProviderData
	{
		#region Constants
		public const string VIDEO_ASSET_FILE_PATHS = "videoAssetFilePaths";
		public const string THUMB_ASSET_FILE_PATH = "thumbAssetFilePath";
		#endregion

		#region Private Fields
		private IList<FreewheelDistributionAssetPath> _VideoAssetFilePaths;
		private string _ThumbAssetFilePath = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use VideoAssetFilePathsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<FreewheelDistributionAssetPath> VideoAssetFilePaths
		{
			get { return _VideoAssetFilePaths; }
			set 
			{ 
				_VideoAssetFilePaths = value;
				OnPropertyChanged("VideoAssetFilePaths");
			}
		}
		/// <summary>
		/// Use ThumbAssetFilePathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ThumbAssetFilePath
		{
			get { return _ThumbAssetFilePath; }
			set 
			{ 
				_ThumbAssetFilePath = value;
				OnPropertyChanged("ThumbAssetFilePath");
			}
		}
		#endregion

		#region CTor
		public FreewheelDistributionJobProviderData()
		{
		}

		public FreewheelDistributionJobProviderData(JToken node) : base(node)
		{
			if(node["videoAssetFilePaths"] != null)
			{
				this._VideoAssetFilePaths = new List<FreewheelDistributionAssetPath>();
				foreach(var arrayNode in node["videoAssetFilePaths"].Children())
				{
					this._VideoAssetFilePaths.Add(ObjectFactory.Create<FreewheelDistributionAssetPath>(arrayNode));
				}
			}
			if(node["thumbAssetFilePath"] != null)
			{
				this._ThumbAssetFilePath = node["thumbAssetFilePath"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFreewheelDistributionJobProviderData");
			kparams.AddIfNotNull("videoAssetFilePaths", this._VideoAssetFilePaths);
			kparams.AddIfNotNull("thumbAssetFilePath", this._ThumbAssetFilePath);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VIDEO_ASSET_FILE_PATHS:
					return "VideoAssetFilePaths";
				case THUMB_ASSET_FILE_PATH:
					return "ThumbAssetFilePath";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

