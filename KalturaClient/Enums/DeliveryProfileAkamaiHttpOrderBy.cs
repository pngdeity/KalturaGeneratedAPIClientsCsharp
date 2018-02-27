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
namespace Kaltura.Enums
{
	public sealed class DeliveryProfileAkamaiHttpOrderBy : StringEnum
	{
		public static readonly DeliveryProfileAkamaiHttpOrderBy CREATED_AT_ASC = new DeliveryProfileAkamaiHttpOrderBy("+createdAt");
		public static readonly DeliveryProfileAkamaiHttpOrderBy UPDATED_AT_ASC = new DeliveryProfileAkamaiHttpOrderBy("+updatedAt");
		public static readonly DeliveryProfileAkamaiHttpOrderBy CREATED_AT_DESC = new DeliveryProfileAkamaiHttpOrderBy("-createdAt");
		public static readonly DeliveryProfileAkamaiHttpOrderBy UPDATED_AT_DESC = new DeliveryProfileAkamaiHttpOrderBy("-updatedAt");

		private DeliveryProfileAkamaiHttpOrderBy(string name) : base(name) { }
	}
}
