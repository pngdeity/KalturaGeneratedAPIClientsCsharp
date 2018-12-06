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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class ThumbParamsOutputGetRequestBuilder : RequestBuilder<ThumbParamsOutput>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public ThumbParamsOutputGetRequestBuilder()
			: base("thumbparamsoutput", "get")
		{
		}

		public ThumbParamsOutputGetRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ThumbParamsOutput>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ThumbParamsOutput>((IDictionary<string,object>)result);
		}
	}

	public class ThumbParamsOutputListRequestBuilder : RequestBuilder<ListResponse<ThumbParamsOutput>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ThumbParamsOutputFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public ThumbParamsOutputListRequestBuilder()
			: base("thumbparamsoutput", "list")
		{
		}

		public ThumbParamsOutputListRequestBuilder(ThumbParamsOutputFilter filter, FilterPager pager)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<ThumbParamsOutput>>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ListResponse<ThumbParamsOutput>>((IDictionary<string,object>)result);
		}
	}


	public class ThumbParamsOutputService
	{
		private ThumbParamsOutputService()
		{
		}

		public static ThumbParamsOutputGetRequestBuilder Get(int id)
		{
			return new ThumbParamsOutputGetRequestBuilder(id);
		}

		public static ThumbParamsOutputListRequestBuilder List(ThumbParamsOutputFilter filter = null, FilterPager pager = null)
		{
			return new ThumbParamsOutputListRequestBuilder(filter, pager);
		}
	}
}
