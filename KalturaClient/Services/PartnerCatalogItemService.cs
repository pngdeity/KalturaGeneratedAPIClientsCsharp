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
// Copyright (C) 2006-2019  Kaltura Inc.
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
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class PartnerCatalogItemAddRequestBuilder : RequestBuilder<VendorCatalogItem>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public PartnerCatalogItemAddRequestBuilder()
			: base("reach_partnercatalogitem", "add")
		{
		}

		public PartnerCatalogItemAddRequestBuilder(int id)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<VendorCatalogItem>(result);
		}
	}

	public class PartnerCatalogItemDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public PartnerCatalogItemDeleteRequestBuilder()
			: base("reach_partnercatalogitem", "delete")
		{
		}

		public PartnerCatalogItemDeleteRequestBuilder(int id)
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

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}


	public class PartnerCatalogItemService
	{
		private PartnerCatalogItemService()
		{
		}

		public static PartnerCatalogItemAddRequestBuilder Add(int id)
		{
			return new PartnerCatalogItemAddRequestBuilder(id);
		}

		public static PartnerCatalogItemDeleteRequestBuilder Delete(int id)
		{
			return new PartnerCatalogItemDeleteRequestBuilder(id);
		}
	}
}